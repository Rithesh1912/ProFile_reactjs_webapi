import React, { useState } from "react";
import "./General.css";
import save from "../../Assets/save_goto_gen_details.gif";
import cancel from "../../Assets/cancel.gif";
import submit from "../../Assets/submit.gif"
import axios from "axios";
import getpostcode from "../../Assets/getpostcode.gif";
import clear from "../../Assets/clear.gif";

function General() {
  
  const [formData, setFormData] = useState({
    type: "",
    mduLiability: "",
    caseDocumentStatus: "Electronic",
    legalCaseDocumentStatus: "Electronic",
    dateOfIncident: "",
    dateOfNotification: "",
    dateClaimIntimated: "",
    caseOrigin: "Casman",
    department: "",
    caseHandler1: "",
    caseHandler2: "",
    caseCategory: "",
    caseSpeciality: "",
    casePractice: "",
    caseFileClassification: "",
    country: "",
    location: "",
    facilityPostcode: "",
    scanningId: ""
  });

  
  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData((prev) => ({ ...prev, [name]: value }));
  };

  const handleSubmit = async (e) => {
    e.preventDefault();

    
    if (!formData.type) {
      alert("Type is required.");
      return;
    }
    if (!formData.dateOfIncident) {
      alert("Date of Incident is required.");
      return;
    }

    try {
       const response = await axios.post(
    "api url", 
    formData, 
    {
      headers: { "Content-Type": "application/json" }
    }
  );

      if (!response.ok) {
        throw new Error("Failed to save case");
      }

      const data = await response.json();
      alert("Case saved successfully!");
      console.log("Saved data:", data);
    } catch (error) {
      alert("Error: " + error.message);
    }
  };

  return (
    <form className="general-container" onSubmit={handleSubmit}>
      <h3 className="form-title-general">General</h3>

      <div className="form-grid">
        
        <div>
          <div className="form-row">
            <label>Type *</label>
            <select name="type" value={formData.type} onChange={handleChange}>
              <option value="">Select</option>
              <option value="type1">Type 1</option>
              <option value="type2">Type 2</option>
            </select>
          </div>

          <div className="form-row">
            <label>MDU Liability *</label>
            <select
              name="mduLiability"
              value={formData.mduLiability}
              onChange={handleChange}
            >
              <option value="">Select</option>
              <option value="yes">Yes</option>
              <option value="no">No</option>
            </select>
          </div>

          <div className="form-row">
            <label>Case Document Status *</label>
            <select
              name="caseDocumentStatus"
              value={formData.caseDocumentStatus}
              onChange={handleChange}
            >
              <option value="Electronic">Electronic</option>
              <option value="Paper">Paper</option>
            </select>
          </div>

          <div className="form-row">
            <label>Legal Case Document Status</label>
            <select
              name="legalCaseDocumentStatus"
              value={formData.legalCaseDocumentStatus}
              onChange={handleChange}
            >
              <option value="Electronic">Electronic</option>
              <option value="Paper">Paper</option>
            </select>
          </div>

          <div className="form-row">
            <label>Department *</label>
            <select
              name="department"
              value={formData.department}
              onChange={handleChange}
            >
              <option value="">Select</option>
            </select>
          </div>

          <div className="form-row">
            <label>Case Handler 1</label>
            <select
              name="caseHandler1"
              value={formData.caseHandler1}
              onChange={handleChange}
            >
              <option value="">Select</option>
            </select>
          </div>

          <div className="form-row">
            <label>Case Handler 2</label>
            <select
              name="caseHandler2"
              value={formData.caseHandler2}
              onChange={handleChange}
            >
              <option value="">Select</option>
            </select>
          </div>
        </div>

        
        <div>
          <div className="form-row">
            <label>Date of Incident *</label>
            <input
              type="date"
              name="dateOfIncident"
              value={formData.dateOfIncident}
              onChange={handleChange}
            />
          </div>

          <div className="form-row">
            <label>Date of Notification *</label>
            <input
              type="date"
              name="dateOfNotification"
              value={formData.dateOfNotification}
              onChange={handleChange}
            />
          </div>

          <div className="form-row">
            <label>Date Claim Intimated</label>
            <input
              type="date"
              name="dateClaimIntimated"
              value={formData.dateClaimIntimated}
              onChange={handleChange}
            />
          </div>

          <div className="form-row">
            <label>Case Origin</label>
            <input
              type="text"
              name="caseOrigin"
              disabled
              value={formData.caseOrigin}
              onChange={handleChange}
            />
          </div>

          <div className="form-row">
            <label>Case Category *</label>
            <select
              name="caseCategory"
              value={formData.caseCategory}
              onChange={handleChange}
            >
              <option value="">Select</option>
            </select>
          </div>

          <div className="form-row">
            <label>Case Speciality *</label>
            <select
              name="caseSpeciality"
              value={formData.caseSpeciality}
              onChange={handleChange}
            >
              <option value="">Select</option>
            </select>
          </div>

          <div className="form-row">
            <label>Case Practice *</label>
            <select
              name="casePractice"
              value={formData.casePractice}
              onChange={handleChange}
            >
              <option value="">Select</option>
            </select>
          </div>

          <div className="form-row">
            <label>Case File Classification</label>
            <select
              name="caseFileClassification"
              value={formData.caseFileClassification}
              onChange={handleChange}
            >
              <option value="">Select</option>
            </select>
          </div>
        </div>
      </div>

      
      <div className="form-row">
        <label>Country *</label>
        <select
          name="country"
          value={formData.country}
          onChange={handleChange}
        >
          <option value="">Select</option>
        </select>
      </div>

      <div className="form-row">
        <label>Location (Hospital/Clinic/Practice)</label>
        <input
          type="text"
          name="location"
          value={formData.location}
          onChange={handleChange}
        />
      </div>

      <div className="form-row postcode-row">
        <label>Facility Postcode</label>
        <input
          type="text"
          name="facilityPostcode"
          value={formData.facilityPostcode}
          onChange={handleChange}
        />
        <button className="button-group"><img src={getpostcode} alt="postcode"></img></button>
        <button className="button-group"><img src={clear} alt="postcode"></img></button>
      </div>

      <div className="form-row">
        <label>Scanning ID</label>
        <input
          type="text"
          name="scanningId"
          value={formData.scanningId}
          onChange={handleChange}
        />
      </div>

      
      <div className="button-group">
        <button type="submit">
          <img src={submit} alt="submit" />
        </button>
        {/* <button type="button" onClick={() => alert("Cancel action")}>
          <img src={cancel} alt="Cancel" />
        </button> */}
      </div>
    </form>
  );
}

export default General;
