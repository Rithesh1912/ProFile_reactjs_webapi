import React, { useState, useEffect, useContext } from "react";
import "./AddPractioner.css";
import axios from "axios";
import { CaseContext } from "../ContextAPI/CaseContext";
import CaseHeader from "../CaseHeader/CaseHeader";
import { useNavigate } from "react-router-dom";

const AddPractitioner = () => {
  const { caseData } = useContext(CaseContext);
  const navigate = useNavigate();

  const [formData, setFormData] = useState({
    caseId: caseData.caseId || "",
    subsidId: caseData.subsidId || "",
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
    userId: localStorage.getItem("userId") || "admin"
  });

  const [indemnifiers, setIndemnifiers] = useState([]);
  const [specialityOfDOI, setSpecialityOfDOI] = useState([]);

  // Update form data when caseData changes
  useEffect(() => {
    setFormData((prev) => ({
      ...prev,
      caseId: caseData.caseId || "",
      subsidId: caseData.subsidId || "",
      userId: localStorage.getItem("userId") || "admin"
    }));
  }, [caseData]);

  // Fetch dropdowns from cache or API
  useEffect(() => {
    const getDropdownsFromCache = async () => {
      try {
        const cache = await caches.open("dropdowns");
        const cachedResponse = await cache.match("dropdowns");
        let dropdowns;

        if (cachedResponse) {
          dropdowns = await cachedResponse.json();
        } else {
          const res = await axios.get(
            "https://localhost:7277/api/DropDown/getall"
          );
          dropdowns = res.data;
          await cache.put("dropdowns", new Response(JSON.stringify(dropdowns)));
        }

        setIndemnifiers(dropdowns.indemnifiers || []);
        setSpecialityOfDOI(dropdowns.specialties || []);
      } catch (err) {
        console.error("Error fetching dropdowns:", err);
      }
    };

    getDropdownsFromCache();
  }, []);

  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData((prev) => ({ ...prev, [name]: value }));
  };

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

  const validateForm = () => {
    if (!formData.surName.trim()) return "Surname is required.";
    if (!formData.indemnifier) return "Indemnifier is required.";
    if (!formData.percentInvolMdu) return "% Involvement of MDU is required.";
    if (!formData.dateOfInvolved) return "Date of Involvement is required.";
    if (!formData.dateOfNotifiedMdu) return "Date Notified to MDU is required.";
    if (!formData.dateClaimMode) return "Date Claim Made is required.";
    return null;
  };

  const handleSubmit = async (e) => {
    e.preventDefault();

    const errorMsg = validateForm();
    if (errorMsg) {
      alert(errorMsg);
      return;
    }

    const payload = buildPayload();

    try {
      await axios.post(
        "https://localhost:7277/api/Practioner/AddPractitioner",
        payload
      );

      alert("Practitioner saved successfully!");
      navigate("/ViewPractioner");

      // Reset form
      setFormData({
        caseId: caseData.caseId || "",
        subsidId: caseData.subsidId || "",
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
        userId: localStorage.getItem("userId") || "admin"
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
          <input
            type="text"
            name="pracNum"
            value={formData.pracNum}
            onChange={handleChange}
          />
          <button type="button" className="search-btn">
            Search
          </button>
        </div>

        {/* Surname */}
        <div className="form-section">
          <label>Surname *</label>
          <input
            type="text"
            name="surName"
            value={formData.surName}
            onChange={handleChange}
          />
        </div>

        {/* ForeName */}
        <div className="form-section">
          <label>Forename</label>
          <input
            type="text"
            name="foreName"
            value={formData.foreName}
            onChange={handleChange}
          />
        </div>

        {/* Initial */}
        <div className="form-section">
          <label>Initial</label>
          <input
            type="text"
            name="initial"
            value={formData.initial}
            onChange={handleChange}
          />
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
          <select
            name="indemnifier"
            value={formData.indemnifier}
            onChange={handleChange}
          >
            <option value="">Select</option>
            {indemnifiers.map((item, idx) => (
              <option key={idx} value={item}>
                {item}
              </option>
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
          <input
            type="date"
            name="dateOfInvolved"
            value={formData.dateOfInvolved}
            onChange={handleChange}
          />
        </div>

        <div className="form-section">
          <label>Date Notified to MDU *</label>
          <input
            type="date"
            name="dateOfNotifiedMdu"
            value={formData.dateOfNotifiedMdu}
            onChange={handleChange}
          />
        </div>

        <div className="form-section">
          <label>Date Claim Made *</label>
          <input
            type="date"
            name="dateClaimMode"
            value={formData.dateClaimMode}
            onChange={handleChange}
          />
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
              <option key={idx} value={item}>
                {item}
              </option>
            ))}
          </select>
        </div>

        {/* Buttons */}
        <div className="btn-section">
          <button type="submit" className="btn">
            Save
          </button>
          <button
            type="button"
            onClick={() => navigate("/ViewPractioner")}
            className="btn"
          >
            Cancel
          </button>
        </div>
      </form>
    </div>
  );
};

export default AddPractitioner;
