import React, { useState, useContext } from "react";
import "./AddPatient.css";
import { useNavigate } from "react-router-dom";
import { CaseContext } from "../Components/ContextAPI/CaseContext";
import CaseHeader from "../Components/CaseHeader/CaseHeader";
import axios from "axios";

const AddPatient = () => {
  const { caseData } = useContext(CaseContext);
  const { caseId, subsidId, status } = caseData;
  const navigate = useNavigate();

  const [form, setForm] = useState({
    surname: "",
    forename: "",
    initials: "",
    title: "",
    sex: "U",
    dob: "",
    ageAtIncident: "",
    nino: "",
    sanctionCheck: false,
    sanctionDate: "",
    incomplete: false,
    deceased: false,
    patientInitiated: false,
    address: ["", "", "", "", ""],
    postcode: "",
    solicitor: "",
    solicitorAddress: ["", "", "", "", ""],
    solicitorPostcode: ""
  });

  const handleChange = (e) => {
    const { name, value, type, checked } = e.target;
    setForm((prev) => ({
      ...prev,
      [name]: type === "checkbox" ? checked : value,
    }));
  };

  const handleAddressChange = (index, value, isSolicitor = false) => {
    if (isSolicitor) {
      const updated = [...form.solicitorAddress];
      updated[index] = value;
      setForm({ ...form, solicitorAddress: updated });
    } else {
      const updated = [...form.address];
      updated[index] = value;
      setForm({ ...form, address: updated });
    }
  };

  const handleSubmit = async (e) => {
    e.preventDefault();

    if (!caseData?.caseId) {
      alert("No case selected!");
      return;
    }

    // Map form state to API body
    const payload = {
      caseId: caseData.caseId,
      subsidId: caseData.subsidId,
      ptLname: form.surname,
      ptFname: form.forename,
      ptTitle: form.title,
      ptInit: form.initials,
      ptSex: form.sex,
      ptDob: form.dob ? new Date(form.dob).toISOString() : null,
      ptSol: form.solicitor,
      ptAddr1: form.address[0] || "",
      ptAddr2: form.address[1] || "",
      ptAddr3: form.address[2] || "",
      ptAddr4: form.address[3] || "",
      ptAddr5: form.address[4] || "",
      ptAddrPostCode: form.postcode,
      ptSolAddr1: form.solicitorAddress[0] || "",
      ptSolAddr2: form.solicitorAddress[1] || "",
      ptSolAddr3: form.solicitorAddress[2] || "",
      ptSolAddr4: form.solicitorAddress[3] || "",
      ptSolAddr5: form.solicitorAddress[4] || "",
      ptSolPostCode: form.solicitorPostcode,
      ptIncomplete: form.incomplete ? "Y" : "N",
      ptDeceased: form.deceased ? "Y" : "N",
      userId: caseData.userId || "system",
      lockNo: 0,
      patientInformed: form.patientInitiated ? "Y" : "N",
      problem: "",
      sanction: form.sanctionCheck ? "Y" : "N",
      sanctionDate:
        form.sanctionCheck && form.sanctionDate
          ? new Date(form.sanctionDate).toISOString()
          : null
    };

    try {
      const res = await axios.post(
        "https://localhost:7277/api/Patient/addpatient",
        payload,
        { headers: { "Content-Type": "application/json" } }
      );

      console.log("✅ Patient saved:", res.data);
      alert("Patient saved successfully!");
      navigate("/ViewPatient");
    } catch (err) {
      console.error("❌ Error saving patient:", err);
      alert("Error saving patient. Please try again.");
    }
  };

  return (
    <form className="add-patient" onSubmit={handleSubmit} autoComplete="off">
      <CaseHeader
        caseId={caseId}
        subId={subsidId}
        status={status}
        liability={caseData.mduLiability}
        handler={caseData.caseHandler1}
        practitioner={caseData.leadPractitioner}
      />

      <h2>General</h2>

      {/* Surname */}
      <div className="form-row">
        <label>Surname *</label>
        <input
          type="text"
          name="surname"
          maxLength="30"
          value={form.surname}
          onChange={handleChange}
        />
      </div>

      {/* Forename + Initials */}
      <div className="form-row">
        <label>Forename</label>
        <input
          type="text"
          name="forename"
          maxLength="25"
          value={form.forename}
          onChange={handleChange}
        />
        <label>Initials *</label>
        <input
          type="text"
          name="initials"
          maxLength="5"
          value={form.initials}
          onChange={handleChange}
        />
      </div>

      {/* Title + Sex */}
      <div className="form-row">
        <label>Title</label>
        <input
          type="text"
          name="title"
          maxLength="10"
          value={form.title}
          onChange={handleChange}
        />
        <label>Sex</label>
        <select name="sex" value={form.sex} onChange={handleChange}>
          <option value="U">Unknown</option>
          <option value="M">Male</option>
          <option value="F">Female</option>
        </select>
      </div>

      {/* DOB + Age at Incident */}
      <div className="form-row">
        <label>Date of Birth *</label>
        <input
          type="date"
          name="dob"
          value={form.dob}
          onChange={handleChange}
        />
        <label>Age @ Incident</label>
        <input
          type="text"
          name="ageAtIncident"
          readOnly
          value={form.ageAtIncident}
        />
      </div>

      {/* NI No */}
      <div className="form-row">
        <label>NI No</label>
        <input
          type="text"
          name="nino"
          maxLength="9"
          value={form.nino}
          onChange={handleChange}
        />
      </div>

      {/* Sanctions Check */}
      <div className="form-row">
        <label>Sanctions Check</label>
        <input
          type="checkbox"
          name="sanctionCheck"
          checked={form.sanctionCheck}
          onChange={handleChange}
        />
        <input
          name="sanctionDate"
          value={form.sanctionDate}
          onChange={handleChange}
          disabled={!form.sanctionCheck}
        />
      </div>

      {/* Incomplete + Deceased + Patient Initiated */}
      <div className="form-row">
        <input
          type="checkbox"
          name="incomplete"
          checked={form.incomplete}
          onChange={handleChange}
        /> Incomplete
        <input
          type="checkbox"
          name="deceased"
          checked={form.deceased}
          onChange={handleChange}
        /> Deceased
        <input
          type="checkbox"
          name="patientInitiated"
          checked={form.patientInitiated}
          onChange={handleChange}
        /> Patient Initiated
      </div>

      {/* Address Section */}
      <h2>Address</h2>
      {form.address.map((addr, i) => (
        <div className="form-row" key={i}>
          <input
            type="text"
            value={addr}
            maxLength="100"
            onChange={(e) => handleAddressChange(i, e.target.value)}
          />
        </div>
      ))}
      <div className="form-row">
        <label>Postcode</label>
        <input
          type="text"
          name="postcode"
          maxLength="8"
          value={form.postcode}
          onChange={handleChange}
        />
      </div>

      {/* Solicitor Section */}
      <h2>Solicitor</h2>
      <div className="form-row">
        <label>Solicitor</label>
        <input
          type="text"
          name="solicitor"
          maxLength="50"
          value={form.solicitor}
          onChange={handleChange}
        />
      </div>
      {form.solicitorAddress.map((addr, i) => (
        <div className="form-row" key={i}>
          <input
            type="text"
            value={addr}
            maxLength="50"
            onChange={(e) => handleAddressChange(i, e.target.value, true)}
          />
        </div>
      ))}
      <div className="form-row">
        <label>Postcode</label>
        <input
          type="text"
          name="solicitorPostcode"
          maxLength="8"
          value={form.solicitorPostcode}
          onChange={handleChange}
        />
      </div>
      
      <div className="form-actions">
        <button type="submit">Save</button>
        <button type="button" onClick={() => window.location.href = "/ViewPatient"}>
          Cancel
        </button>
      </div>
    </form>
  );
};

export default AddPatient;
