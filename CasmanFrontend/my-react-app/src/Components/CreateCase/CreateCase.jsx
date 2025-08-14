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
  const [role, setRole] = useState("");

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


    const payload = {
      practitionerType: selectedOption,
      pracNumber,
      surname,
      forename,
      initials,
      sex,
      warnings: selectedOption === "known" || selectedOption === "other" ? warnings : undefined,
      flexPartySummary: selectedOption === "member" ? flexPartySummary : undefined,
      identifier,
      speciality,
      role,
    };

    try {
      const response = await axios.post(
        "api url",
        payload,
        {
          headers: {
            "Content-Type": "application/json"
          }
        }
      );

      if (!response.ok) {
        throw new Error("Failed to save case");
      }

      const data = await response.json();
      alert("Case saved successfully!");
      console.log("Saved data:", data);
      navigate("/general");


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
          
          <option value="id1">MDU</option>
          <option value="id2">MDU Connect </option>
          <option value="id3">Blank </option>
          <option value="id4">GP ELS </option>
          <option value="id5">GP FLS </option>
          <option value="id6">Group </option>
          <option value="id7">MDDUS </option>
          <option value="id8">MPS </option>
          <option value="id9">Other </option>
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
          
          <option value="spec1">ADVANCED NURSE PRACTITIONER </option>
          <option value="spec2">ALTERNATIVE MEDICINE</option>
          <option value="spec3">CARDIAC SURGERY</option>
          <option value="spec4">BASICS</option>
          <option value="spec5">AUDIOLOGICAL MEDICINE</option>
          <option value="spec6">ANAESTHETICS</option>
        </select>
        <label>Role *</label>
        <input
          type="text"
          value="lead"
          onChange={(e) => setRole(e.target.value)}
          disabled={true}
          required
        />
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
