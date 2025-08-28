import React, { useState,useEffect } from "react";
import "./CreateCase.css";
import save from "../../Assets/save_goto_gen_details.gif";
import cancel from "../../Assets/cancel.gif";
import getmemberdetails from "../../Assets/GetMemberDetails.gif";
import { useNavigate } from "react-router-dom";
import axios from "axios";


function CreateCase() {
  const navigate = useNavigate();

  const [selectedOption, setSelectedOption] = useState("member");

  const [pracNumber, setPracNumber] = useState("");
  const [surname, setSurname] = useState("");
  const [forename, setForename] = useState("");
  const [initials, setInitials] = useState("");
  const [sex, setSex] = useState("Unknown");
  const [warnings, setWarnings] = useState("");
  const [flexPartySummary, setFlexPartySummary] = useState("");

  // Dropdowns from session
  const [indemnifiers, setIndemnifiers] = useState([]);
  const [specialities, setSpecialities] = useState([]);

  const userId = "robin";

  const [formData, setFormData] = useState({
    caseType: "",
    department: "",
    indemnifier: "",
    speciality: ""
  });

  useEffect(() => {
    // Load dropdowns from session storage
    const dropdowns = JSON.parse(sessionStorage.getItem("dropdowns"));
    if (dropdowns) {
      setIndemnifiers(dropdowns.indemnifiers || []);
      setSpecialities(dropdowns.specialties || []);
    } else {
      // Fetch from API if not in session
      const fetchDropdowns = async () => {
        const res = await axios.get("https://localhost:7277/api/DropDown/getall");
        sessionStorage.setItem("dropdowns", JSON.stringify(res.data));
        setIndemnifiers(res.data.indemnifiers || []);
        setSpecialities(res.data.specialties || []);
      };
      fetchDropdowns();
    }
  }, []);

  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData((prev) => ({ ...prev, [name]: value }));
  };

  const handleSubmit = async (e) => {
    e.preventDefault();

    if ((selectedOption === "member" || selectedOption === "known") && !pracNumber.trim()) {
      alert("Prac Number is required.");
      return;
    }
    if (!surname.trim()) {
      alert("Surname is required.");
      return;
    }
    if (!formData.indemnifier) {
      alert("Indemnifier is required.");
      return;
    }

    const generatePracNum = () => "PRAC-" + Date.now() + "-" + Math.floor(Math.random() * 1000);

    const payload = {
      PracNum: generatePracNum(),
      PracRole: "Lead",
      PracLastName: surname,
      PracFirstName: forename,
      PracInit: initials,
      PracSex: sex,
      PracDefOrg: formData.indemnifier,
      PracTow: formData.speciality,
      UserId: userId,
      CaseCreateSource: "Casman"
    };

    try {
      const response = await axios.post("https://localhost:7277/api/Case/create", payload, {
        headers: { "Content-Type": "application/json" }
      });

      if (response.status !== 200) throw new Error("Failed to save case");

      const data = response.data;
      alert("Case saved successfully!");
      navigate(`/general?caseId=${data.caseID}&subId=${data.subID}`);
    } catch (error) {
      alert("Error: " + error.message);
    }
  };

  return (
    <form className="practitioner-container" onSubmit={handleSubmit}>
      <h3 className="form-title">Practitioner</h3>

      <div className="radio-group">
        <label>
          <input
            type="radio"
            name="practitionerType"
            value="member"
            checked={selectedOption === "member"}
            onChange={(e) => setSelectedOption(e.target.value)}
          />
          Member (Past/Present)
        </label>
        <label>
          <input
            type="radio"
            name="practitionerType"
            value="known"
            checked={selectedOption === "known"}
            onChange={(e) => setSelectedOption(e.target.value)}
          />
          Known Practitioner
        </label>
        <label>
          <input
            type="radio"
            name="practitionerType"
            value="other"
            checked={selectedOption === "other"}
            onChange={(e) => setSelectedOption(e.target.value)}
          />
          Other
        </label>
      </div>

      {(selectedOption === "member" || selectedOption === "known") && (
        <div className="form-row">
          <label>Prac Number</label>
          <input type="text" value={pracNumber} onChange={(e) => setPracNumber(e.target.value)} />
          <button type="button" className="getmemberdetails" onClick={() => alert("Fetch member details logic here")}>
            <img src={getmemberdetails} alt="Get Member Details" />
          </button>
        </div>
      )}

      <div className="form-row">
        <label>Surname *</label>
        <input type="text" value={surname} onChange={(e) => setSurname(e.target.value)} disabled={selectedOption === "member"} required />
      </div>

      <div className="form-row">
        <label>Forename</label>
        <input type="text" value={forename} onChange={(e) => setForename(e.target.value)} disabled={selectedOption === "member"} />
      </div>

      <div className="form-row">
        <label>Initials</label>
        <input type="text" value={initials} onChange={(e) => setInitials(e.target.value)} disabled={selectedOption === "member"} />
        <label>Sex</label>
        <select value={sex} onChange={(e) => setSex(e.target.value)}>
          <option>Unknown</option>
          <option>Male</option>
          <option>Female</option>
        </select>
      </div>

      <div className="form-row">
        <label>Indemnifier *</label>
        <select name="indemnifier" value={formData.indemnifier} onChange={handleChange} required>
          <option value="">Select</option>
          {indemnifiers.map((item, idx) => (
            <option key={idx} value={item}>{item}</option>
          ))}
        </select>
      </div>

      <div className="form-row">
        <label>Speciality at DOI</label>
        <select name="speciality" value={formData.speciality} onChange={handleChange}>
          <option value="">Select</option>
          {specialities.map((item, idx) => (
            <option key={idx} value={item}>{item}</option>
          ))}
        </select>
      </div>

      <div className="button-group">
        <button type="submit" name="saveandgotogeneraldetails">
          <img src={save} alt="Save" />
        </button>
        <button type="button" name="cancel" onClick={() => alert("Cancel action here")}>
          <img src={cancel} alt="Cancel" />
        </button>
      </div>
    </form>
  );
}

export default CreateCase;
