import React, { useState, useEffect, useContext } from "react";
import "./AddPractioner.css";
import axios from "axios";
import { CaseContext } from "../ContextAPI/CaseContext";
import CaseHeader from "../CaseHeader/CaseHeader";

const AddPractitioner = () => {
    const {caseData, setCaseData} = useContext(CaseContext);
  const { caseId,subsidId,userId } = useContext(CaseContext);
  

  // Sync context whenever caseData changes
//   useEffect(() => {
//     if (caseData) {
//       addCase(caseData);
//     }
//   }, [caseData, addCase]);

  const [formData, setFormData] = useState({
    caseId: caseId || "",
    subsidId: subsidId || "",
    pracNum: "",
    surName: "",
    foreName: "",
    initial: "",
    sex: "Unknown",
    indemnifier: "",
    role: "Non-Lead",
    percentInvolMdu: "",
    dateOfInvolved: "",
    dateOfNotifiedMdu: "",
    dateClaimMode: "",
    specialityOfDOI: "",
    userId: caseData.userId || "admin" // default from context
  });

  const [indemnifiers, setIndemnifiers] = useState([]);
  const [specialityOfDOI, setSpecialityOfDOI] = useState([]);

  // ✅ Keep formData updated if caseData in context changes
  useEffect(() => {
    setFormData((prev) => ({
      ...prev,
      caseId:caseId || "",
      subsidId: subsidId || "",
      userId: userId || "admin"
    }));
  }, [caseData]);

  // Fetch dropdowns (cached in sessionStorage)
  useEffect(() => {
    const dropdowns = JSON.parse(sessionStorage.getItem("dropdowns"));
    if (dropdowns) {
      setIndemnifiers(dropdowns.indemnifiers || []);
      setSpecialityOfDOI(dropdowns.specialties || []);
    } else {
      const fetchDropdowns = async () => {
        try {
          const res = await axios.get("https://localhost:7277/api/DropDown/getall");
          sessionStorage.setItem("dropdowns", JSON.stringify(res.data));
          setIndemnifiers(res.data.indemnifiers || []);
          setSpecialityOfDOI(res.data.specialties || []);
        } catch (err) {
          console.error("Error fetching dropdowns:", err);
        }
      };
      fetchDropdowns();
    }
  }, []);

  // Generic change handler
  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData((prev) => ({ ...prev, [name]: value }));
  };

  // DTO mapping for API
  const buildPayload = () => ({
    ...formData,
    percentInvolMdu: formData.percentInvolMdu?.toString() || "0",
    dateOfInvolved: formData.dateOfInvolved
      ? new Date(formData.dateOfInvolved).toISOString()
      : null,
    dateOfNotifiedMdu: formData.dateOfNotifiedMdu
      ? new Date(formData.dateOfNotifiedMdu).toISOString()
      : null,
    dateClaimMode: formData.dateClaimMode
      ? new Date(formData.dateClaimMode).toISOString()
      : null
  });

  // Validation
  const validateForm = () => {
    if (!formData.surName.trim()) return "Surname is required.";
    if (!formData.indemnifier) return "Indemnifier is required.";
    if (!formData.percentInvolMdu) return "% Involvement of MDU is required.";
    if (!formData.dateOfInvolved) return "Date of Involvement is required.";
    if (!formData.dateOfNotifiedMdu) return "Date Notified to MDU is required.";
    if (!formData.dateClaimMode) return "Date Claim Made is required.";
    return null;
  };

  // Submit
  const handleSubmit = async (e) => {
    e.preventDefault();

    const errorMsg = validateForm();
    if (errorMsg) {
      alert(errorMsg);
      return;
    }

    const payload = buildPayload();
    console.log("✅ Payload sent to API:", payload);

    try {
      const response = await axios.post(
        "https://localhost:7277/api/Practioner/AddPractioner",
        payload
      );

      console.log("✅ Form saved successfully:", response.data);
      alert("Practitioner saved successfully!");

      // Reset form (keep caseId/subId from context)
      setFormData({
        caseId: caseData.caseId || "",
        subsidId: caseData.subId || "",
        pracNum: "",
        surName: "",
        foreName: "",
        initial: "",
        sex: "Unknown",
        indemnifier: "",
        role: "Non-Lead",
        percentInvolMdu: "",
        dateOfInvolved: "",
        dateOfNotifiedMdu: "",
        dateClaimMode: "",
        specialityOfDOI: "",
        userId: caseData.userId || "admin"
      });
    } catch (error) {
      console.error("❌ Error saving practitioner:", error);

      if (error.response) {
        console.error("❌ Backend error response:", error.response.data);
        if (error.response.data.errors) {
          console.error("❌ Validation errors:", error.response.data.errors);
        }
      }

      alert("Failed to save practitioner. Please check inputs or server.");
    }
  };

  return (
    <div className="form-container">
      <CaseHeader
        caseId={caseData.caseId}
        subId={caseData.subId}
        status={caseData.status}
        liability={caseData.liability}
        handler={caseData.handler}
        practitioner={caseData.practitioner}
      />

      <h2>Add Practitioner</h2>
      <form onSubmit={handleSubmit} className="prac-form">
        {/* Prac Number */}
        <div className="form-section">
          <label>Prac Number</label>
          <input type="text" name="pracNum" value={formData.pracNum} onChange={handleChange} />
          <button type="button" className="search-btn">Search</button>
        </div>

        {/* Surname */}
        <div className="form-section">
          <label>Surname *</label>
          <input type="text" name="surName" value={formData.surName} onChange={handleChange} />
        </div>

        {/* ForeName */}
        <div className="form-section">
          <label>Forename</label>
          <input type="text" name="foreName" value={formData.foreName} onChange={handleChange} />
        </div>

        {/* Initial */}
        <div className="form-section">
          <label>Initial</label>
          <input type="text" name="initial" value={formData.initial} onChange={handleChange} />
        </div>

        {/* Sex */}
        <div className="form-section">
          <label>Sex</label>
          <select name="sex" value={formData.sex} onChange={handleChange}>
            <option>Unknown</option>
            <option>Male</option>
            <option>Female</option>
          </select>
        </div>

        {/* Indemnifier */}
        <div className="form-section">
          <label>Indemnifier *</label>
          <select name="indemnifier" value={formData.indemnifier} onChange={handleChange}>
            <option value="">Select</option>
            {indemnifiers.map((item, idx) => (
              <option key={idx} value={item}>{item}</option>
            ))}
          </select>
        </div>

        {/* Role */}
        <div className="form-section">
          <label>Role *</label>
          <select name="role" value={formData.role} onChange={handleChange}>
            <option>Non-Lead</option>
            <option>Lead</option>
          </select>
        </div>

        {/* % Involvement */}
        <div className="form-section">
          <label>% Involvement of MDU *</label>
          <input
            type="number"
            name="percentInvolMdu"
            value={formData.percentInvolMdu}
            onChange={handleChange}
          />
        </div>

        {/* Dates */}
        <div className="form-section">
          <label>Date of Involvement *</label>
          <input type="date" name="dateOfInvolved" value={formData.dateOfInvolved} onChange={handleChange} />
        </div>

        <div className="form-section">
          <label>Date Notified to MDU *</label>
          <input type="date" name="dateOfNotifiedMdu" value={formData.dateOfNotifiedMdu} onChange={handleChange} />
        </div>

        <div className="form-section">
          <label>Date Claim Made *</label>
          <input type="date" name="dateClaimMode" value={formData.dateClaimMode} onChange={handleChange} />
        </div>

        {/* Speciality */}
        <div className="form-section">
          <label>Case Speciality</label>
          <select
            name="specialityOfDOI"
            value={formData.specialityOfDOI}
            onChange={handleChange}
          >
            <option value="">Select</option>
            {specialityOfDOI.map((item, idx) => (
              <option key={idx} value={item}>{item}</option>
            ))}
          </select>
        </div>

        {/* Buttons */}
        <div className="btn-section">
          <button type="submit" className="btn">Save</button>
          <button type="button" className="btn cancel">Cancel</button>
        </div>
      </form>
    </div>
  );
};

export default AddPractitioner;
