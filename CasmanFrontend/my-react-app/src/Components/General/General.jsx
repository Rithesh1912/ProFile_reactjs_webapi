import React, { useState, useEffect, useContext } from "react";
import "./General.css";
import save from "../../Assets/save_goto_gen_details.gif";
import cancel from "../../Assets/cancel.gif";
import submit from "../../Assets/submit.gif";
import axios from "axios";
import getpostcode from "../../Assets/getpostcode.gif";
import clear from "../../Assets/clear.gif";
import { CaseContext } from "../ContextAPI/CaseContext";
import { useDropdowns } from "../ContextAPI/DropDownContext";
import CaseHeader from "../CaseHeader/CaseHeader";

function General() {
  const {caseId,subId,status,liability,handler,practitioner,setCaseData}=React.useContext(CaseContext);
  const { dropdowns, loading, error, reload } = useDropdowns();
  
  // const { addCase } = useContext(CaseContext);

  // useEffect(() => {
  //   if (caseData) {
  //     addCase(caseData);
  //   }
  // }, [caseData, addCase]);

  

  // const [searchParams] = useSearchParams();
  // const caseId = searchParams.get("caseId");
  // const subId = searchParams.get("subId");

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
    legalCaseDocumentStatus: "Electronic",
  });
   useEffect(() => {
    if (caseId) {
      setCaseData({
        caseId: formData.caseId,
        subId: formData.subsidId,
        status: "Active", // Assuming status is always Active here
        liability: formData.mduLiability,
        handler: formData.caseHandler1,
        practitioner: formData.leadPractitioner,
      });
    }
  }, [formData,caseId,setCaseData]);
  
 useEffect(() => {
  
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


  // change handler
  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData((prev) => ({
      ...prev,
      [name]: value,
    }));
  };

  // submit
  const handleSubmit = async (e) => {
    e.preventDefault();
    const payload = {
      ...formData,
      incdtDate: formData.incdtDate ? new Date(formData.incdtDate).toISOString() : null,
      claimDate: formData.claimDate ? new Date(formData.claimDate).toISOString() : null,
    };

    try {
      const response = await axios.put("https://localhost:7277/api/Case/update", payload, {
        headers: { "Content-Type": "application/json" },
      });
      alert("Case saved successfully!");
      console.log("Saved data:", response.data);
    } catch (error) {
      console.error(error);
      alert("Error: " + error.message);
    }
  };

  if (loading) return <p>Loading dropdowns...</p>;
  if (error) return <p>Error: {error}</p>;

  return (
    <div>
      <CaseHeader
        caseId={caseId}
        subId={formData.subsidId}
        status={status}
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
              <select name="caseType" value={formData.caseType} onChange={handleChange}>
                <option value="">Select</option>
                {dropdowns.caseTypes.map((ct, idx) => (
                  <option key={idx} value={ct}>
                    {ct}
                  </option>
                ))}
              </select>
            </div>

            <div className="form-row">
              <label>MDU Liability *</label>
              <select name="mduLiability" value={formData.mduLiability} onChange={handleChange}>
                <option value="">Select</option>
                {dropdowns.liabilities.map((ml, idx) => (
                  <option key={idx} value={ml}>
                    {ml}
                  </option>
                ))}
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
              <label>Department *</label>
              <select name="department" value={formData.department} onChange={handleChange}>
                <option value="">Select</option>
                {dropdowns.departments.map((dept, idx) => (
                  <option key={idx} value={dept}>
                    {dept}
                  </option>
                ))}
              </select>
            </div>

            <div className="form-row">
              <label>Case Handler 1</label>
              <select name="caseHandler1" value={formData.caseHandler1} onChange={handleChange}>
                <option value="">Select</option>
                {dropdowns.staff.map((ch1, idx) => (
                  <option key={idx} value={ch1}>
                    {ch1}
                  </option>
                ))}
              </select>
            </div>

            <div className="form-row">
              <label>Case Handler 2</label>
              <select name="caseHandler2" value={formData.caseHandler2} onChange={handleChange}>
                <option value="">Select</option>
                {dropdowns.staff.map((ch2, idx) => (
                  <option key={idx} value={ch2}>
                    {ch2}
                  </option>
                ))}
              </select>
            </div>
          </div>

          {/* RIGHT SIDE */}
          <div>
            <div className="form-row">
              <label>Date of Incident *</label>
              <input type="date" name="incdtDate" value={formData.incdtDate} onChange={handleChange} />
            </div>

            <div className="form-row">
              <label>Date of Notification *</label>
              <input type="date" name="claimDate" value={formData.claimDate} onChange={handleChange} />
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
              <label>Case Category *</label>
              <select name="caseCategory" value={formData.caseCategory} onChange={handleChange}>
                <option value="">Select</option>
                {dropdowns.categories.map((cc, idx) => (
                  <option key={idx} value={cc}>
                    {cc}
                  </option>
                ))}
              </select>
            </div>

            <div className="form-row">
              <label>Case Speciality *</label>
              <select name="caseSpeciality" value={formData.caseSpeciality} onChange={handleChange}>
                <option value="">Select</option>
                {dropdowns.specialties.map((cs, idx) => (
                  <option key={idx} value={cs}>
                    {cs}
                  </option>
                ))}
              </select>
            </div>

            <div className="form-row">
              <label>Case Practice *</label>
              <select name="casePractice" value={formData.casePractice} onChange={handleChange}>
                <option value="">Select</option>
                {dropdowns.practices.map((cp, idx) => (
                  <option key={idx} value={cp}>
                    {cp}
                  </option>
                ))}
              </select>
            </div>
          </div>
        </div>

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
