import React, { useContext, useEffect, useState } from "react";
import "./ViewPractioner.css";
import { useNavigate } from "react-router-dom";
import { CaseContext } from "../ContextAPI/CaseContext";
import CaseHeader from "../CaseHeader/CaseHeader";
import axios from "axios";

const ViewPractioner = () => {
  const [practitioner, setPractitioner] = useState([]);
  const { caseData } = useContext(CaseContext);
  const { caseId, subsidId, status } = caseData || {};
  const [showModal, setShowModal] = useState(false);
  const [selectedPractitioner, setSelectedPractitioner] = useState(null);
  const [indemnifiers, setIndemnifiers] = useState([]);
  const [specialityOfDOI, setSpecialityOfDOI] = useState([]);

  const navigate = useNavigate();

  // Fetch practitioners
  useEffect(() => {
    if (!caseId || !subsidId) return;

    axios
      .get(
        `https://localhost:7277/api/Practioner/GetPractitionerByCaseId/${caseId}/${subsidId}`
      )
      .then((res) => {
        console.log("📢 Practitioner API Response 👉", res.data);
        setPractitioner(res.data || []);
      })
      .catch((err) => {
        console.error("❌ Error fetching practitioner:", err);
      });
  }, [caseId, subsidId]);

  // Fetch dropdowns
  useEffect(() => {
    const getDropdowns = async () => {
      try {
        const cache = await caches.open("dropdowns");
        const cachedResponse = await cache.match("dropdowns");
        let dropdowns;

        if (cachedResponse) {
          dropdowns = await cachedResponse.json();
        } else {
          const res = await axios.get("https://localhost:7277/api/DropDown/getall");
          dropdowns = res.data;
          await cache.put("dropdowns", new Response(JSON.stringify(dropdowns)));
        }

        setIndemnifiers(dropdowns.indemnifiers || []);
        setSpecialityOfDOI(dropdowns.specialties || []);
      } catch (err) {
        console.error("Error fetching dropdowns:", err);
      }
    };
    getDropdowns();
  }, []);

  const handleAddPractitioner = () => {
    navigate("/AddPractioner");
  };

  const handleDelete = async (pracNum) => {
    const confirmDelete = window.confirm(
      `Are you sure you want to delete practitioner ${pracNum}?`
    );
    if (!confirmDelete) return;

    try {
      await axios.delete(
        `https://localhost:7277/api/Practioner/DeletePractionerby/${caseId}/${subsidId}/${pracNum}`
      );
      setPractitioner((prev) => prev.filter((prac) => prac.prac_Num !== pracNum));
      alert("Practitioner deleted successfully!");
    } catch (error) {
      console.error("Error deleting practitioner:", error);
      alert("Failed to delete practitioner. Please try again.");
    }
  };

  
  // Prepare practitioner data for modal
const preparePractitionerForEdit = (raw) => ({
  prac_Num: raw.prac_Num,
  prac_FirstName: raw.prac_FirstName || "",
  prac_LastName: raw.prac_LastName || "",
  prac_Role: raw.prac_Role === "Lead" || raw.prac_Role === "Non-Lead" ? raw.prac_Role : "Non-Lead",
  indemnifiers: raw.indemnifiers || "",
  perCent_Involved: raw.perCent_Involved?.toString() || "0",
  dateOfInvolved: raw.dateOfInvolved ? raw.dateOfInvolved.split("T")[0] : "",
  dateOfNotifiedMdu: raw.dateOfNotifiedMdu ? raw.dateOfNotifiedMdu.split("T")[0] : "",
  dateClaimMode: raw.dateClaimMode ? raw.dateClaimMode.split("T")[0] : "",
  specialityOfDOI: raw.specialityOfDOI || "",
  sex: raw.sex || "Unknown",
  initial: raw.initial || ""
});

// Open modal with selected practitioner
const handleEditClick = (prac) => {
  setSelectedPractitioner(preparePractitionerForEdit(prac));
  setShowModal(true);
};

// Update modal inputs in state
const handleChange = (e) => {
  const { name, value } = e.target;
  setSelectedPractitioner((prev) => ({ ...prev, [name]: value }));
};

// Update practitioner in backend
const handleUpdate = async (e) => {
  e.preventDefault();
  if (!selectedPractitioner) return;

  const payload = {
    CaseId: caseId,
    SubsidId: subsidId,
    PracNum: selectedPractitioner.prac_Num,
    ForeName: selectedPractitioner.prac_FirstName,
    SurName: selectedPractitioner.prac_LastName,
    Role: selectedPractitioner.prac_Role,
    Indemnifier: selectedPractitioner.indemnifiers,
    PercentInvolMdu: selectedPractitioner.perCent_Involved,
    DateOfInvolved: selectedPractitioner.dateOfInvolved
      ? new Date(selectedPractitioner.dateOfInvolved).toISOString()
      : null,
    DateOfNotifiedMdu: selectedPractitioner.dateOfNotifiedMdu
      ? new Date(selectedPractitioner.dateOfNotifiedMdu).toISOString()
      : null,
    DateClaimMode: selectedPractitioner.dateClaimMode
      ? new Date(selectedPractitioner.dateClaimMode).toISOString()
      : null,
    SpecialityOfDOI: selectedPractitioner.specialityOfDOI || "GENERAL",
    Sex: selectedPractitioner.sex || "Unknown",
    Initial: selectedPractitioner.initial || "",
    UserId: "admin"
  };

  console.log("📤 Update Practitioner Payload =>", payload);

  try {
    await axios.put(
      `https://localhost:7277/api/Practioner/UpdatePractionerby/${caseId}/${subsidId}/${selectedPractitioner.prac_Num}`,
      payload
    );
    alert("Practitioner updated successfully!");
    setShowModal(false);

    // Refresh table
    const res = await axios.get(
      `https://localhost:7277/api/Practioner/GetPractitionerByCaseId/${caseId}/${subsidId}`
    );
    setPractitioner(res.data || []);
  } catch (err) {
    console.error("❌ Error updating practitioner:", err.response?.data || err);
    alert("Failed to update practitioner. Check console for details.");
  }
};


  return (
    <div className="prac-container">
      <CaseHeader
        caseId={caseId}
        subId={subsidId}
        status={status}
        liability={caseData?.mduLiability}
        handler={caseData?.caseHandler1}
        practitioner={caseData?.leadPractitioner}
      />

      <h2>Practitioner Details</h2>
      <table className="prac-table">
        <thead>
          <tr>
            <th>Practitioner No</th>
            <th>First Name</th>
            <th>Last Name</th>
            <th>Role</th>
            <th>Indemnifier</th>
            <th>% Involved</th>
            <th>Action</th>
          </tr>
        </thead>
        <tbody>
          {practitioner.length === 0 ? (
            <tr>
              <td colSpan="7" style={{ textAlign: "center" }}>No practitioners found</td>
            </tr>
          ) : (
            practitioner.map((prac) => (
              <tr key={prac.prac_Num}>
                <td>{prac.prac_Num}</td>
                <td>{prac.prac_FirstName}</td>
                <td>{prac.prac_LastName}</td>
                <td>{prac.prac_Role}</td>
                <td>{prac.indemnifiers || "-"}</td>
                <td>{prac.perCent_Involved || "-"}</td>
                <td>
                  <button className="btn-delete" onClick={() => handleDelete(prac.prac_Num)}>Delete</button>
                  <button className="btn-edit" onClick={() => handleEditClick(prac)}>Edit</button>
                </td>
              </tr>
            ))
          )}
          <tr>
            <td colSpan="7" style={{ textAlign: "center" }}>
              <button className="btn" onClick={handleAddPractitioner}>Add Practitioner</button>
            </td>
          </tr>
        </tbody>
      </table>

      {/* Edit Modal */}
      {showModal && selectedPractitioner && (
        <div className="modal-overlay">
          <div className="modal-content">
            <h2>Edit Practitioner</h2>
            <form onSubmit={handleUpdate} className="prac-form">
              <div className="form-section">
                <label>Practitioner Number</label>
                <input type="text" value={selectedPractitioner.prac_Num} disabled />
              </div>
              <div className="form-section">
                <label>First Name</label>
                <input type="text" name="prac_FirstName" value={selectedPractitioner.prac_FirstName} onChange={handleChange} />
              </div>
              <div className="form-section">
                <label>Last Name</label>
                <input type="text" name="prac_LastName" value={selectedPractitioner.prac_LastName} onChange={handleChange} />
              </div>
              <div className="form-section">
                <label>Indemnifier</label>
                <select name="indemnifiers" value={selectedPractitioner.indemnifiers} onChange={handleChange}>
                  <option value="">Select</option>
                  {indemnifiers.map((item, idx) => <option key={idx} value={item}>{item}</option>)}
                </select>
              </div>
              <div className="form-section">
                <label>Role</label>
                <select name="prac_Role" value={selectedPractitioner.prac_Role} onChange={handleChange}>
                  <option>Non-Lead</option>
                  <option>Lead</option>
                </select>
              </div>
              <div className="form-section">
                <label>% Involved</label>
                <input type="number" name="perCent_Involved" value={selectedPractitioner.perCent_Involved} onChange={handleChange} />
              </div>
              <div className="form-section">
                <label>Date of Involvement</label>
                <input type="date" name="dateOfInvolved" value={selectedPractitioner.dateOfInvolved} onChange={handleChange} />
              </div>
              <div className="form-section">
                <label>Date Notified to MDU</label>
                <input type="date" name="dateOfNotifiedMdu" value={selectedPractitioner.dateOfNotifiedMdu} onChange={handleChange} />
              </div>
              <div className="form-section">
                <label>Date Claim Made</label>
                <input type="date" name="dateClaimMode" value={selectedPractitioner.dateClaimMode} onChange={handleChange} />
              </div>
              <div className="form-section">
                <label>Speciality</label>
                <select name="specialityOfDOI" value={selectedPractitioner.specialityOfDOI} onChange={handleChange}>
                  <option value="">Select</option>
                  {specialityOfDOI.map((item, idx) => <option key={idx} value={item}>{item}</option>)}
                </select>
              </div>
              <div className="modal-actions">
                <button type="submit" className="btn">Save</button>
                <button type="button" className="btn" onClick={() => setShowModal(false)}>Cancel</button>
              </div>
            </form>
          </div>
        </div>
      )}
    </div>
  );
};

export default ViewPractioner;
