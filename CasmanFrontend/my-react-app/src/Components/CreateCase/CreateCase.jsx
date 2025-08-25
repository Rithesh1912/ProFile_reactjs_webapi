import React, { useState } from "react";
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
  const [identifier, setIdentifier] = useState("");
  const [speciality, setSpeciality] = useState("");
  const [Role, setRole] = useState("");
  const userId = "robin"; // Replace with actual user ID logic

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
    if (!identifier) {
      alert("Identifier is required.");
      return;
    }
    // if (!role.trim()) {
    //   alert("Role is required.");
    //   return;
    // }
    const generatePracNum = () => {
  return "PRAC-" + Date.now() + "-" + Math.floor(Math.random() * 1000);
};


const payload = {
  PracNum: generatePracNum(),
  PracRole: "Lead",
  // MduUnit: mduUnit,
  PracLastName: surname,
  PracFirstName: forename,
  PracInit: initials,
  PracSex: sex,
  PracDefOrg: identifier,
  PracTow: speciality,
  // PracSource: pracSource,
  UserId: userId,
  CaseCreateSource: "Casman"
};
console.log("Payload to be sent:", payload);

    try {
      const response = await axios.post(
        "https://localhost:7277/api/Case/create",
        payload,
        {
          headers: {
            "Content-Type": "application/json"
          }
        }
      );
      console.log("Response from server:", response);

      if (response.status !=200) {
        throw new Error("Failed to save case");
      }

      const data = await response.data;
      const caseId = data.caseID;
      const subId = data.subID;
      alert("Case saved successfully!");
      console.log("Saved data:", caseId, subId);
      navigate(`/general?caseId=${caseId}&subId=${subId}`);


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
          <input
            type="text"
            value={pracNumber}
            onChange={(e) => setPracNumber(e.target.value)}
          />
          <button
            type="button"
            className="getmemberdetails"
            onClick={() => alert("Fetch member details logic here")}
          >
            <img src={getmemberdetails} alt="Get Member Details" />
          </button>
        </div>
      )}

      <div className="form-row">
        <label>Surname *</label>
        <input
          type="text"
          className="full-width"
          value={surname}
          onChange={(e) => setSurname(e.target.value)}
          disabled={selectedOption === "member"}
          required
        />
      </div>

      <div className="form-row">
        <label>Forename</label>
        <input
          type="text"
          className="full-width"
          value={forename}
          onChange={(e) => setForename(e.target.value)}
          disabled={selectedOption === "member"}
        />
      </div>

      <div className="form-row">
        <label>Initials</label>
        <input
          type="text"
          value={initials}
          onChange={(e) => setInitials(e.target.value)}
          disabled={selectedOption === "member"}
        />
        <label>Sex</label>
        <select value={sex} onChange={(e) => setSex(e.target.value)}>
          <option>Unknown</option>
          <option>Male</option>
          <option>Female</option>
        </select>
      </div>

      {(selectedOption === "known" || selectedOption === "other") ? (
        <div className="form-row">
          <label>Warnings</label>
          <input
            type="text"
            className="flex-grow"
            value={warnings}
            onChange={(e) => setWarnings(e.target.value)}
            disabled={false}
          />
        </div>
      ) : (
        <div className="form-row">
          <label>Flex Party Summary</label>
          <input
            type="text"
            className="flex-grow"
            value={flexPartySummary}
            onChange={(e) => setFlexPartySummary(e.target.value)}
            disabled={false}
          />
        </div>
      )}

      <div className="form-row">
        <label>Indemnifier *</label>
        <select
          className="flex-grow"
          value={identifier}
          onChange={(e) => setIdentifier(e.target.value)}
          required
        >
          <option value="">Select</option>
          
          <option value="MDU">MDU</option>
          <option value="MDU Connect ">MDU Connect </option>
          <option value="Blank">Blank </option>
          <option value="GP ELS">GP ELS </option>
          <option value="GP FLS">GP FLS </option>
          <option value="Group">Group </option>
          <option value="MDDUS">MDDUS </option>
          <option value="MPS">MPS </option>
          <option value="Other">Other </option>
        </select>
      </div>

      <div className="form-row">
        <label>Speciality at DOI</label>
        <select
          className="flex-grow"
          value={speciality}
          onChange={(e) => setSpeciality(e.target.value)}
        >
          <option value="">Select</option>
          
          <option value="ADVANCED NURSE PRACTITIONER">ADVANCED NURSE PRACTITIONER </option>
          <option value="ALTERNATIVE MEDICINE">ALTERNATIVE MEDICINE</option>
          <option value="CARDIAC SURGERY">CARDIAC SURGERY</option>
          <option value="BASICS">BASICS</option>
          <option value="AUDIOLOGICAL MEDICINE">AUDIOLOGICAL MEDICINE</option>
          <option value="ANAESTHETICS">ANAESTHETICS</option>
        </select>
        <label>Role *</label>
        <input
          type="text"
          value="Lead"
          onChange={(e) => setRole(e.target.value)}
          disabled={true}
          required
        />
      </div>

      <div className="button-group">
        <button type="submit" name="saveandgotogeneraldetails" onClick={handleSubmit}>
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
