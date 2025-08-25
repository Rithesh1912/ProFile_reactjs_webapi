import React, { useState } from "react";
import "./General.css";
import save from "../../Assets/save_goto_gen_details.gif";
import cancel from "../../Assets/cancel.gif";
import submit from "../../Assets/submit.gif";
import axios from "axios";
import getpostcode from "../../Assets/getpostcode.gif";
import clear from "../../Assets/clear.gif";
import { useSearchParams } from "react-router-dom";
import { useEffect } from 'react';
import CaseHeader from "../CaseHeader/CaseHeader";

function General() {
  const [searchParams] = useSearchParams();
  const caseId = searchParams.get("caseId");
  const subId = searchParams.get("subId");

  const [formData, setFormData] = useState({
    caseId: caseId || "",
    subsidId: subId || "",
    department: "",
    caseType: "",
    mduLiability: "",
    caseCategory: "",
    caseSpeciality: "",
    casePractice: "",
    caseHandler1: "",
    caseHandler2: "",
    incdtDate: "",        
    claimDate: "",
    legalCaseDocumentStatus: "Electronic"
  });
   
 useEffect(() => {
  console.log("caseId:", caseId, "subId:", subId);
  if (caseId && subId) {
    axios
      .get(`https://localhost:7277/api/Case/GetCaseDetailsByCaseId/${caseId}/${subId}`)
      .then((res) => {
        const data = res.data;
        
        setFormData((prev) => ({
          ...prev,
          ...data,
          incdtDate: data.incdtDate ? data.incdtDate.split("T")[0] : "",
          claimDate: data.claimDate ? data.claimDate.split("T")[0] : "",
          
        }));
      })
      .catch((err) => console.error("Error fetching case:", err));
  }
}, [caseId, subId]);



  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData((prev) => ({
      ...prev,
      [name]: value,
    }));
  };

  const handleSubmit = async (e) => {
    e.preventDefault();

   
    const payload = {
      ...formData,
      incdtDate: formData.incdtDate
        ? new Date(formData.incdtDate).toISOString()
        : null,
      claimDate: formData.claimDate
        ? new Date(formData.claimDate).toISOString()
        : null,
      closeDate: formData.closeDate
        ? new Date(formData.closeDate).toISOString()
        : null,
      dateLastUpdated: formData.dateLastUpdated
        ? new Date(formData.dateLastUpdated).toISOString()
        : null,
      dateClaimIntimated: formData.dateClaimIntimated
        ? new Date(formData.dateClaimIntimated).toISOString()
        : null,
    };

    console.log("Submitting data:", payload);

    try {
      const response = await axios.put(
        "https://localhost:7277/api/Case/update",
        payload,
        { headers: { "Content-Type": "application/json" } }
      );

      alert("Case saved successfully!");
      console.log("Saved data:", response.data);
    } catch (error) {
      console.error(error);
      alert("Error: " + error.message);
    }
  };

  return (
     <div>
      
      <CaseHeader
        caseId={formData.caseId}
        subId={formData.subsidId}
        status={formData.status}
        liability={formData.mduLiability}
        handler={formData.caseHandler1}
        practitioner={formData.leadPractitioner}
      />
    <form className="general-container" onSubmit={handleSubmit}>
      <h3 className="form-title-general">General</h3>

      <div className="form-grid">
        {/* LEFT SIDE */}
        <div>
          <div className="form-row">
            <label>Case Type *</label>
            <select
              name="caseType"
              value={formData.caseType}
              onChange={handleChange}
            >
              <option value="">Select</option>
              <option value="Advice">Advice</option>
              <option value="Assistance">Assistance</option>
              <option value="Claim">Claim</option>
              <option value="Duplicate">Duplicate</option>
              <option value="Old">Old</option>
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
              <option value="Actual Claim">Actual Claim</option>
              <option value="No Indemnity">No Indemnity</option>
              <option value="Potential Claim">Potential Claim</option>
              <option value="Unassigned">Unassigned</option>
              <option value="None">None</option>
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
              <option value="Hybrid">Hybrid</option>
            </select>
          </div>

          <div className="form-row">
            <label>Department*</label>
            <select
              name="department"
              value={formData.department}
              onChange={handleChange}
              required
            >
              <option value="">Select</option>
              <option value="SUPPORT">SUPPORT</option>
              <option value="DENTAL">Dental</option>
              <option value="LEGAL">LEGAL</option>
              <option value="ADVISORY">ADVISORY</option>
              <option value="ACCOUNTS">ACCOUNTS</option>
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
              <option value="Rupesh">Rupesh</option>
              <option value="Rithesh">Rithesh</option>
              <option value="Vignesh">Vignesh</option>
              <option value="Yeswanth">Yeswanth</option>
              <option value="Robin">Robin</option>
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
              <option value="Rupesh">Rupesh</option>
              <option value="Rithesh">Rithesh</option>
              <option value="Vignesh">Vignesh</option>
              <option value="Yeswanth">Yeswanth</option>
              <option value="Robin">Robin</option>
            </select>
          </div>
        </div>

        {/* RIGHT SIDE */}
        <div>
          <div className="form-row">
            <label>Date of Incident *</label>
            <input
              type="date"
              name="incdtDate"
              value={formData.incdtDate}
              onChange={handleChange}
            />
          </div>

          <div className="form-row">
            <label>Date of Notification *</label>
            <input
              type="date"
              name="claimDate"
              value={formData.claimDate}
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

          {/* <div className="form-row">
            <label>Case Origin</label>
            <input
              type="text"
              name="caseOrigin"
              disabled
              value={formData.caseOrigin}
              onChange={handleChange}
            />
          </div> */}

          <div className="form-row">
            <label>Case Category *</label>
            <select
              name="caseCategory"
              value={formData.caseCategory}
              onChange={handleChange}
            >
              <option value="">Select</option>
              <option value="Clinical">Clinical</option>
              <option value="Non-Clinical">Non-Clinical</option>
              <option value="Legal">Legal</option>
              <option value="Other">Other</option>
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
              <option value="Cardiology">Cardiology</option>
              <option value="Dermatology">Dermatology</option>
              <option value="Neurology">Neurology</option>
              <option value="Oncology">Oncology</option>
              <option value="Pediatrics">Pediatrics</option>
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
              <option value="General Practice">General Practice</option>
              <option value="Specialist Practice">Specialist Practice</option>
              <option value="Hospital">Hospital</option>
              <option value="Clinic">Clinic</option>
              <option value="Other">Other</option>
            </select>
          </div>
        </div>
      </div>

      {/* <div className="form-row">
        <label>Country *</label>
        <select
          name="country"
          value={formData.country}
          onChange={handleChange}
        >
          <option value="">Select</option>
          <option value="United Kingdom">United Kingdom</option>
          <option value="United States">United States</option>
          <option value="Canada">Canada</option>
          <option value="Australia">Australia</option>
          <option value="India">India</option>
          <option value="Other">Other</option>
        </select>
      </div> */}

      {/* <div className="form-row">
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
        <button className="button-group">
          <img src={getpostcode} alt="postcode"></img>
        </button>
        <button className="button-group">
          <img src={clear} alt="postcode"></img>
        </button>
      </div> */}

      {/* <div className="form-row">
        <label>Scanning ID</label>
        <input
          type="text"
          name="scanningId"
          value={formData.scanningId}
          onChange={handleChange}
        />
      </div> */}

      <div className="button-group">
        <button type="submit">
          <img src={submit} alt="submit" />
        </button>
      </div>
    </form>
    </div>
  );
}

export default General;
