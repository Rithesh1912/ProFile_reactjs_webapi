import React, { useState } from "react";
import "./AddPractioner.css";

const AddPractitioner = () => {
  const [formData, setFormData] = useState({
    pracNumber: "",
    surname: "",
    forename: "",
    initials: "",
    sex: "Unknown",
    warnings: "",
    groupType: "",
    mduNo: "",
    surnameOrg: "",
    indemnifier: "",
    role: "Non-Lead",
    percentInvolvement: 0,
    dateInvolvement: "",
    dateNotified: "",
    dateIrishClaim: "",
    dateClaim: "",
    claimType: "",
    ddr: "",
    caseSpeciality: ""
  });

  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData((prev) => ({ ...prev, [name]: value }));
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    console.log("Form Data Submitted: ", formData);
  };

  return (
    <div className="form-container">
      <h2>Add Practitioner</h2>
      <form onSubmit={handleSubmit} className="prac-form">
        <div className="form-section">
          <label>Prac Number</label>
          <input type="text" name="pracNumber" value={formData.pracNumber} onChange={handleChange} />
          <button type="button" className="search-btn">Search</button>
        </div>

        <div className="form-section">
          <label>Surname *</label>
          <input type="text" name="surname" value={formData.surname} onChange={handleChange} />
        </div>

        <div className="form-section">
          <label>Forename</label>
          <input type="text" name="forename" value={formData.forename} onChange={handleChange} />
        </div>

        <div className="form-section">
          <label>Initials</label>
          <input type="text" name="initials" value={formData.initials} onChange={handleChange} />
        </div>

        <div className="form-section">
          <label>Sex</label>
          <select name="sex" value={formData.sex} onChange={handleChange}>
            <option>Unknown</option>
            <option>Male</option>
            <option>Female</option>
          </select>
        </div>

        <div className="form-section full-width">
          <label>Warnings</label>
          <textarea name="warnings" value={formData.warnings} onChange={handleChange}></textarea>
        </div>

        <div className="form-section">
          <label>Indemnifier *</label>
          <select name="indemnifier" value={formData.indemnifier} onChange={handleChange}>
            <option value="">-- Select --</option>
            <option value="MDU">MDU</option>
            <option value="Other">Other</option>
          </select>
        </div>

        <div className="form-section">
          <label>Role *</label>
          <select name="role" value={formData.role} onChange={handleChange}>
            <option>Non-Lead</option>
            <option>Lead</option>
          </select>
        </div>

        <div className="form-section">
          <label>% Involvement of MDU</label>
          <input type="number" name="percentInvolvement" value={formData.percentInvolvement} onChange={handleChange} />
        </div>

        <div className="form-section">
          <label>Date of Involvement</label>
          <input type="date" name="dateInvolvement" value={formData.dateInvolvement} onChange={handleChange} />
        </div>

        <div className="form-section">
          <label>Date Notified to MDU</label>
          <input type="date" name="dateNotified" value={formData.dateNotified} onChange={handleChange} />
        </div>

        <div className="form-section">
          <label>Date Irish Claim Made</label>
          <input type="date" name="dateIrishClaim" value={formData.dateIrishClaim} onChange={handleChange} />
        </div>

        <div className="form-section">
          <label>Date Claim Made</label>
          <input type="date" name="dateClaim" value={formData.dateClaim} onChange={handleChange} />
        </div>

        <div className="form-section">
          <label>Case Speciality</label>
          <input type="text" name="caseSpeciality" value={formData.caseSpeciality} onChange={handleChange} />
        </div>

        <div className="btn-section">
          <button type="submit" className="btn">Save</button>
          <button type="button" className="btn cancel">Cancel</button>
        </div>
      </form>
    </div>
  );
};

export default AddPractitioner;
