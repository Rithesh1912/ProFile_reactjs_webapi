import React, { useState, useEffect } from "react";
import "./General.css";
import save from "../../Assets/save_goto_gen_details.gif";
import cancel from "../../Assets/cancel.gif";
import submit from "../../Assets/submit.gif";
import axios from "axios";
import getpostcode from "../../Assets/getpostcode.gif";
import clear from "../../Assets/clear.gif";
import { useSearchParams } from "react-router-dom";
import CaseHeader from "../CaseHeader/CaseHeader";
import { fetchAndStoreDropdowns } from "../../Service/DropDownservice";

function General() {
  const [searchParams] = useSearchParams();
  const caseId = searchParams.get("caseId");
  const subId = searchParams.get("subId");
  const [caseTypes, setCaseTypes] = useState([]);
  const [caseLiabilities, setcaseLiabilities] = useState([]);
  const [casedepartment, setcasedepartment] = useState([]);
  const [casehandler1, setcasehandler1] = useState([]);
  const [casehandler2, setcasehandler2] = useState([]);
  const [casecategory, setcasecategory] = useState([]);
  const [casespeciality, setcasespeciality] = useState([]);
  const [casepractice, setcasepractice] = useState([]);

  const [dropdowns, setDropdowns] = useState({
    specialties: [],
    liabilities: [],
    caseTypes: [],
    statuses: [],
    departments: [],
    categories: [],
    practices: [],
    classifications: [],
    staff: [],
    countries: [],
    indemnifiers: [],
  });


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
    const loadDropdowns = async () => {
      const storedDropdowns = sessionStorage.getItem("dropdowns");
      if (storedDropdowns) {
        setDropdowns(JSON.parse(storedDropdowns));
      } else {
        const data = await fetchAndStoreDropdowns();
        setDropdowns(data);
      }
    };

    loadDropdowns();
  }, []);

  // Fetch case details if editing
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


  // Generic change handler for all form fields
  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData((prev) => ({
      ...prev,
      [name]: value,
    }));
  };




  // Form submit
  const handleSubmit = async (e) => {
    e.preventDefault();

    //console.log("Payload going to backend:", JSON.stringify(formData, null, 2));

    const payload = {
      ...formData,
      incdtDate: formData.incdtDate ? new Date(formData.incdtDate).toISOString() : null,
      claimDate: formData.claimDate ? new Date(formData.claimDate).toISOString() : null,
      closeDate: formData.closeDate ? new Date(formData.closeDate).toISOString() : null,
      dateLastUpdated: formData.dateLastUpdated ? new Date(formData.dateLastUpdated).toISOString() : null,
      dateClaimIntimated: formData.dateClaimIntimated ? new Date(formData.dateClaimIntimated).toISOString() : null,
    };

    console.log("Payload going to backend:", payload);

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
                <option value="" onClick={fetchAndStoreDropdowns}>Select</option>
                {JSON.parse(sessionStorage.getItem("dropdowns"))?.caseTypes
                  ?.filter(ct => ct !== "")
                  .sort((a, b) => (a.startsWith("~") ? 1 : 0) - (b.startsWith("~") ? 1 : 0))
                  .map((ct, idx) => (
                    <option key={idx} value={ct}>
                      {ct}
                    </option>
                  ))}
              </select>
            </div>

            <div className="form-row">
              <label>MDU Liability *</label>
              <select
                name="mduLiability"
                value={formData.mduLiability}
                onChange={handleChange}
              >
                <option value="" onClick={fetchAndStoreDropdowns}>Select</option>
                {JSON.parse(sessionStorage.getItem("dropdowns"))?.liabilities 
                  ?.filter(ml => ml !== "")
                  .sort((a, b) => (a.startsWith("~") ? 1 : 0) - (b.startsWith("~") ? 1 : 0))
                  .map((ml, idx) => (
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
              <label>Department*</label>
              <select
                name="department"
                value={formData.department}
                onChange={handleChange}
                required
              >
                <option value="" onClick={fetchAndStoreDropdowns}>Select</option>

                {JSON.parse(sessionStorage.getItem("dropdowns"))?.departments
                  ?.filter(dept => dept !== "")
                  .sort((a, b) => (a.startsWith("~") ? 1 : 0) - (b.startsWith("~") ? 1 : 0))
                  .map((dept, idx) => (
                    <option key={idx} value={dept}>
                      {dept}
                    </option>
                  ))}
              </select>
            </div>

            <div className="form-row">
              <label>Case Handler 1</label>
              <select
                name="caseHandler1"
                value={formData.caseHandler1}
                onChange={handleChange}
              >
                <option value="" onClick={fetchAndStoreDropdowns}>Select</option>
                {JSON.parse(sessionStorage.getItem("dropdowns"))?.staff
                  ?.filter(ch1 => ch1 !== "")
                  .map((ch1, idx) => (
                    <option key={idx} value={ch1}>
                      {ch1}
                    </option>
                  ))}

              </select>
            </div>

            <div className="form-row">
              <label>Case Handler 2</label>
              <select
                name="caseHandler2"
                value={formData.caseHandler2}
                onChange={handleChange}
              >
                <option value="" onClick={fetchAndStoreDropdowns}>Select</option>
                {JSON.parse(sessionStorage.getItem("dropdowns"))?.staff
                  ?.filter(ch1 => ch1 !== "")
                  .map((ch1, idx) => (
                    <option key={idx} value={ch1}>
                      {ch1}
                    </option>
                  ))}
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

            <div className="form-row">
              <label>Case Category *</label>
              <select
                name="caseCategory"
                value={formData.caseCategory}
                onChange={handleChange}
              >
                <option value="" onClick={fetchAndStoreDropdowns}>Select</option>
                {JSON.parse(sessionStorage.getItem("dropdowns"))?.categories
                  ?.filter(cc => cc !== "")
                  .sort((a, b) => (a.startsWith("~") ? 1 : 0) - (b.startsWith("~") ? 1 : 0))
                  .map((cc, idx) => (
                    <option key={idx} value={cc}>
                      {cc}
                    </option>
                  ))}
              </select>
            </div>

            <div className="form-row">
              <label>Case Speciality *</label>
              <select
                name="caseSpeciality"
                value={formData.caseSpeciality}
                onChange={handleChange}
              >
                <option value="" onClick={fetchAndStoreDropdowns}>Select</option>
                {JSON.parse(sessionStorage.getItem("dropdowns"))?.specialties
                  ?.filter(cs => cs !== "")
                  .sort((a, b) => (a.startsWith("~") ? 1 : 0) - (b.startsWith("~") ? 1 : 0))
                  .map((cs, idx) => (
                    <option key={idx} value={cs}>
                      {cs}
                    </option>
                  ))}
              </select>
            </div>

            <div className="form-row">
              <label>Case Practice *</label>
              <select
                name="casePractice"
                value={formData.casePractice}
                onChange={handleChange}
              >
                <option value="" onClick={fetchAndStoreDropdowns}>Select</option>
                {JSON.parse(sessionStorage.getItem("dropdowns"))?.practices
                  ?.filter(cp => cp !== "")
                  .sort((a, b) => (a.startsWith("~") ? 1 : 0) - (b.startsWith("~") ? 1 : 0))
                  .map((cp, idx) => (
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
