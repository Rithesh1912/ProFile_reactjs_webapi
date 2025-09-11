import React, { useContext, useEffect, useState } from "react";
import "./ViewPatient.css";
import { useNavigate } from "react-router-dom";
import { CaseContext } from "../Components/ContextAPI/CaseContext";
import CaseHeader from "../Components/CaseHeader/CaseHeader";
import axios from "axios";

const ViewPatient = () => {
  const [patients, setPatients] = useState([]);
  const { caseData = {} } = useContext(CaseContext);
  const { caseId, subsidId, status } = caseData || {};
  const [showModal, setShowModal] = useState(false);
  const [selectedPatient, setSelectedPatient] = useState(null);

  const navigate = useNavigate();

  // Fetch patients
  useEffect(() => {
    if (!caseId || !subsidId) return;

    axios
      .get(
        `https://localhost:7277/api/Patient/GetPatientByCaseId/${caseId}/${subsidId}`
      )
      .then((res) => {
        setPatients(res.data || []);
      })
      .catch((err) => {
        console.error("Fetch Error:", err.response || err.message);
      });
  }, [caseId, subsidId]);

  // Prepare patient object so form inputs always have values
  const preparePatientForEdit = (raw) => {
    const cleaned = {};
    for (const key in raw) {
      cleaned[key] = typeof raw[key] === "string" ? raw[key].trim() : raw[key];
    }

    const addrArr =
      cleaned.ptAddrArray ||
      [
        cleaned.ptAddr1 ?? "",
        cleaned.ptAddr2 ?? "",
        cleaned.ptAddr3 ?? "",
        cleaned.ptAddr4 ?? "",
        cleaned.ptAddr5 ?? "",
      ].map((v) => v ?? "");

    const solAddrArr =
      cleaned.ptSolAddrArray ||
      [
        cleaned.ptSolAddr1 ?? "",
        cleaned.ptSolAddr2 ?? "",
        cleaned.ptSolAddr3 ?? "",
        cleaned.ptSolAddr4 ?? "",
        cleaned.ptSolAddr5 ?? "",
      ].map((v) => v ?? "");

    const pd = {
      ...cleaned,
      address: addrArr,
      solicitorAddress: solAddrArr,
      ptAddrPostCode: cleaned.ptAddrPostCode ?? "",
      ptSolPostCode: cleaned.ptSolPostCode ?? "",
      ptFname: cleaned.ptFname ?? "",
      ptLname: cleaned.ptLname ?? "",
      ptInit: cleaned.ptInit ?? "",
      ptTitle: cleaned.ptTitle ?? "",
      ptSex: cleaned.ptSex ?? "U",
      ptNino: cleaned.ptNino ?? "",
      ptDob: cleaned.ptDob ?? "",
      ptIncomplete: cleaned.ptIncomplete ?? "N",
      ptDeceased: cleaned.ptDeceased ?? "N",
      patientInformed: cleaned.patientInformed ?? "N",
      userId: cleaned.userId ?? "system",
      lockNo: cleaned.lockNo?.toString() ?? "0",
    };

    // ensure ptAddr1..ptAddr5 and ptSolAddr1..ptSolAddr5 exist (mirror arrays)
    for (let i = 0; i < 5; i++) {
      const idx = i + 1;
      pd[`ptAddr${idx}`] = pd[`ptAddr${idx}`] ?? pd.address[i] ?? "";
      pd[`ptSolAddr${idx}`] =
        pd[`ptSolAddr${idx}`] ?? pd.solicitorAddress[i] ?? "";
    }

    return pd;
  };

  const handleEditClick = (patient) => {
    const patientData = preparePatientForEdit(patient);
    setSelectedPatient(patientData);
    setShowModal(true);
  };

  // Update address array + ptAddr fields so both UI and payload are in sync
  const handleAddressChange = (index, value, isSolicitor = false) => {
    if (!selectedPatient) return;

    if (isSolicitor) {
      const updated = [...(selectedPatient.solicitorAddress || ["", "", "", "", ""])];
      updated[index] = value;
      setSelectedPatient((prev) => ({
        ...prev,
        solicitorAddress: updated,
        [`ptSolAddr${index + 1}`]: value,
      }));
    } else {
      const updated = [...(selectedPatient.address || ["", "", "", "", ""])];
      updated[index] = value;
      setSelectedPatient((prev) => ({
        ...prev,
        address: updated,
        [`ptAddr${index + 1}`]: value,
      }));
    }
  };

  const handleUpdate = async (e) => {
    e.preventDefault();
    if (!selectedPatient) return;

    const payload = {
      ptLname: selectedPatient.ptLname || "",
      ptFname: selectedPatient.ptFname || "",
      ptTitle: selectedPatient.ptTitle || "",
      ptInit: selectedPatient.ptInit || "",
      ptSex: selectedPatient.ptSex || "U",
      ptNino: selectedPatient.ptNino || "",
      ptDob: selectedPatient.ptDob
        ? new Date(selectedPatient.ptDob).toISOString()
        : null,
      ptAgeInc: selectedPatient.ptAgeInc || "",
      ptSol: selectedPatient.ptSol || "",
      ptAddr1: selectedPatient.ptAddr1 || "",
      ptAddr2: selectedPatient.ptAddr2 || "",
      ptAddr3: selectedPatient.ptAddr3 || "",
      ptAddr4: selectedPatient.ptAddr4 || "",
      ptAddr5: selectedPatient.ptAddr5 || "",
      ptAddrPostCode: selectedPatient.ptAddrPostCode || "",
      ptSolAddr1: selectedPatient.ptSolAddr1 || "",
      ptSolAddr2: selectedPatient.ptSolAddr2 || "",
      ptSolAddr3: selectedPatient.ptSolAddr3 || "",
      ptSolAddr4: selectedPatient.ptSolAddr4 || "",
      ptSolAddr5: selectedPatient.ptSolAddr5 || "",
      ptSolPostCode: selectedPatient.ptSolPostCode || "",
      ptIncomplete: selectedPatient.ptIncomplete ? "Y" : "N",
      ptDeceased: selectedPatient.ptDeceased ? "Y" : "N",
      userId: selectedPatient.userId || "system",
      lockNo: selectedPatient.lockNo?.toString() || "0",
      patientInformed: selectedPatient.patientInformed ? "Y" : "N",
      ptLnameInit: selectedPatient.ptLnameInit || "",
      problem: selectedPatient.problem || "",
      sanction: selectedPatient.sanction || "N",
      sanctionDate: selectedPatient.sanctionDate
        ? new Date(selectedPatient.sanctionDate).toISOString()
        : null,
    };

    try {
      await axios.put(
        `https://localhost:7277/api/Patient/UpdatePatientby/${caseId}/${subsidId}/${selectedPatient.ptNumber}`,
        payload
      );
      alert("Patient updated successfully!");
      setShowModal(false);

      // refresh list
      const res = await axios.get(
        `https://localhost:7277/api/Patient/GetPatientByCaseId/${caseId}/${subsidId}`
      );
      setPatients(res.data || []);
    } catch (err) {
      console.error("Error updating patient:", err.response || err.message);
      alert("Error updating patient. Check console for details.");
    }
  };

  const handleDeletePatient = async (ptNumber) => {
    const confirmdelete = window.confirm(
      `Are you sure you want to delete patient ${ptNumber}?`
    );
    if (!confirmdelete) return;

    try {
      await axios.delete(
        `https://localhost:7277/api/Patient/DeletePatientby/${caseId}/${subsidId}/${ptNumber}`
      );
      setPatients((prev) => prev.filter((p) => p.ptNumber !== ptNumber));
      alert("Patient deleted successfully");
    } catch (err) {
      console.error("Error deleting patient:", err.response || err.message);
    }
  };

  const handleAddPatient = () => {
    navigate("/AddPatient");
  };

  const formatDateValue = (val) => {
    if (!val) return "";
    try {
      return String(val).split("T")[0];
    } catch {
      return "";
    }
  };

  return (
    <div className="patient-container">
      <CaseHeader
        caseId={caseId}
        subId={subsidId}
        status={status}
        liability={caseData?.mduLiability}
        handler={caseData?.caseHandler1}
        practitioner={caseData?.leadPractitioner}
      />

      <h2>Patient Details</h2>

      {!patients || patients.length === 0 ? (
        <p className="loading">No patients found for this case.</p>
      ) : (
        <table className="patient-table">
          <thead>
            <tr>
              <th>Patient No</th>
              <th>First Name</th>
              <th>Last Name</th>
              <th>DOB</th>
              <th>Gender</th>
              <th>Contact</th>
              <th>Solicitor</th>
              <th>Action</th>
            </tr>
          </thead>
          <tbody>
            {patients.map((p) => (
              <tr key={p.ptNumber}>
                <td>{p.ptNumber}</td>
                <td>{p.ptFname}</td>
                <td>{p.ptLname}</td>
                <td>{p.ptDob ? formatDateValue(p.ptDob) : ""}</td>
                <td>{p.ptSex}</td>
                <td>
                  {[p.ptAddr1, p.ptAddr2, p.ptAddr3].filter(Boolean).join(", ")}
                </td>
                <td>{p.ptSol}</td>
                <td>
                  <button
                    className="btn-delete"
                    onClick={() => handleDeletePatient(p.ptNumber)}
                  >
                    Delete
                  </button>
                  <button className="btn-edit" onClick={() => handleEditClick(p)}>
                    Edit
                  </button>
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      )}

      {/* Modal for editing */}
      {showModal && selectedPatient && (
        <div className="modal-overlay" onMouseDown={() => { /* don't close overlay on backdrop for safety */ }}>
          <div className="modal-content" role="dialog" aria-modal="true">
            <h2>Edit Patient</h2>
            <form className="modal-form" onSubmit={handleUpdate}>
              {/* Row 1 */}
              <div>
                <label>First Name</label>
                <input
                  type="text"
                  value={selectedPatient.ptFname ?? ""}
                  onChange={(e) =>
                    setSelectedPatient((prev) => ({ ...prev, ptFname: e.target.value }))
                  }
                />
              </div>

              <div>
                <label>Last Name</label>
                <input
                  type="text"
                  value={selectedPatient.ptLname ?? ""}
                  onChange={(e) =>
                    setSelectedPatient((prev) => ({ ...prev, ptLname: e.target.value }))
                  }
                />
              </div>

              {/* Row 2 */}
              <div>
                <label>Initials</label>
                <input
                  type="text"
                  value={selectedPatient.ptInit ?? ""}
                  onChange={(e) =>
                    setSelectedPatient((prev) => ({ ...prev, ptInit: e.target.value }))
                  }
                />
              </div>

              <div>
                <label>Title</label>
                <input
                  type="text"
                  value={selectedPatient.ptTitle ?? ""}
                  onChange={(e) =>
                    setSelectedPatient((prev) => ({ ...prev, ptTitle: e.target.value }))
                  }
                />
              </div>

              {/* Row 3 */}
              <div>
                <label>Gender</label>
                <select
                  value={selectedPatient.ptSex ?? "U"}
                  onChange={(e) =>
                    setSelectedPatient((prev) => ({ ...prev, ptSex: e.target.value }))
                  }
                >
                  <option value="U">Unknown</option>
                  <option value="M">Male</option>
                  <option value="F">Female</option>
                </select>
              </div>

              <div>
                <label>DOB</label>
                <input
                  type="date"
                  value={formatDateValue(selectedPatient.ptDob)}
                  onChange={(e) =>
                    setSelectedPatient((prev) => ({ ...prev, ptDob: e.target.value }))
                  }
                />
              </div>

              {/* NI No */}
              <div>
                <label>NI No</label>
                <input
                  type="text"
                  value={selectedPatient.ptNino ?? ""}
                  onChange={(e) =>
                    setSelectedPatient((prev) => ({ ...prev, ptNino: e.target.value }))
                  }
                />
              </div>

              {/* Checkboxes */}
              <div className="checkbox-group">
                <label>
                  <input
                    type="checkbox"
                    checked={(selectedPatient.ptIncomplete ?? "N") === "Y"}
                    onChange={(e) =>
                      setSelectedPatient((prev) => ({
                        ...prev,
                        ptIncomplete: e.target.checked ? "Y" : "N",
                      }))
                    }
                  />
                  Incomplete
                </label>
                <label>
                  <input
                    type="checkbox"
                    checked={(selectedPatient.ptDeceased ?? "N") === "Y"}
                    onChange={(e) =>
                      setSelectedPatient((prev) => ({
                        ...prev,
                        ptDeceased: e.target.checked ? "Y" : "N",
                      }))
                    }
                  />
                  Deceased
                </label>
                <label>
                  <input
                    type="checkbox"
                    checked={(selectedPatient.patientInformed ?? "N") === "Y"}
                    onChange={(e) =>
                      setSelectedPatient((prev) => ({
                        ...prev,
                        patientInformed: e.target.checked ? "Y" : "N",
                      }))
                    }
                  />
                  Patient Informed
                </label>
              </div>

              {/* Address (5 lines) */}
              <div style={{ gridColumn: "1 / -1" }}>
                <h3>Address</h3>
                <div className="address-grid">
                  {(selectedPatient.address || ["", "", "", "", ""]).map((addr, i) => (
                    <div key={i}>
                      <label>Address line {i + 1}</label>
                      <input
                        type="text"
                        value={
                          selectedPatient.address?.[i] ??
                          selectedPatient[`ptAddr${i + 1}`] ??
                          ""
                        }
                        onChange={(e) => handleAddressChange(i, e.target.value, false)}
                      />
                    </div>
                  ))}
                </div>

                <div style={{ marginTop: 8 }}>
                  <label>Postcode</label>
                  <input
                    type="text"
                    value={selectedPatient.ptAddrPostCode ?? ""}
                    onChange={(e) =>
                      setSelectedPatient((prev) => ({ ...prev, ptAddrPostCode: e.target.value }))
                    }
                  />
                </div>
              </div>

              {/* Solicitor */}
              <div style={{ gridColumn: "1 / -1" }}>
                <h3>Solicitor</h3>
                <div>
                  <label>Solicitor</label>
                  <input
                    type="text"
                    value={selectedPatient.ptSol ?? ""}
                    onChange={(e) =>
                      setSelectedPatient((prev) => ({ ...prev, ptSol: e.target.value }))
                    }
                  />
                </div>

                <div className="address-grid" style={{ marginTop: 8 }}>
                  {(selectedPatient.solicitorAddress || ["", "", "", "", ""]).map((addr, i) => (
                    <div key={`sol-${i}`}>
                      <label>Solicitor Address {i + 1}</label>
                      <input
                        type="text"
                        value={
                          selectedPatient.solicitorAddress?.[i] ??
                          selectedPatient[`ptSolAddr${i + 1}`] ??
                          ""
                        }
                        onChange={(e) => handleAddressChange(i, e.target.value, true)}
                      />
                    </div>
                  ))}
                </div>

                <div style={{ marginTop: 8 }}>
                  <label>Solicitor Postcode</label>
                  <input
                    type="text"
                    value={selectedPatient.ptSolPostCode ?? ""}
                    onChange={(e) =>
                      setSelectedPatient((prev) => ({ ...prev, ptSolPostCode: e.target.value }))
                    }
                  />
                </div>
              </div>

              {/* Modal actions spanning full width */}
              <div className="modal-actions" style={{ gridColumn: "1 / -1" }}>
                <button type="submit" className="btn btn-add">Save</button>
                <button
                  type="button"
                  className="btn btn-add"
                  onClick={() => setShowModal(false)}
                >
                  Cancel
                </button>
              </div>
            </form>
          </div>
        </div>
      )}

      <button className="btn-add" onClick={handleAddPatient}>
        Add Patient
      </button>
    </div>
  );
};

export default ViewPatient;
