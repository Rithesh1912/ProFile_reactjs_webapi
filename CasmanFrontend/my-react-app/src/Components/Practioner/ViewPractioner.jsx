import React, {useContext, useEffect, useState } from "react";
import "./ViewPractioner.css";
import { Navigate } from "react-router-dom";
import { CaseContext } from "../ContextAPI/CaseContext";


const ViewPractioner = () => {
  const [practitioner, setPractitioner] = useState(null);
  const{caseId,subId,setCaseData}=useContext(CaseContext);
 useEffect(() => {
    fetch(`https://localhost:7277/api/Practioner/GetPracDetailsByCaseId/${caseId}/${subId}`)
      .then((res) => res.json())
      .then((data) => setPractitioner(data))
      .catch((err) => console.error("Error fetching practitioner:", err));
  }, [setCaseData,caseId,subId]);

  if (!practitioner) {
    return <p className="loading">Loading practitioner details...</p>;
  }
  const handleAddPractitioner = () => {
    Navigate('/AddPractioner');
  }

  return (
    <div className="prac-container">
      <h2>Practitioner Details</h2>
      <table className="prac-table">
        <thead>
          <tr>
            <th>Practitioner No</th>
            <th>First Name</th>
            <th>Last Name</th>
            <th>Role</th>
            <th>Indemnifier</th>
            <th>% Involved</th>
            <th>Action</th>
          </tr>
        </thead>
        <tbody>
          <tr>
            <td>{practitioner.prac_Num}</td>
            <td>{practitioner.prac_FirstName}</td>
            <td>{practitioner.prac_LastName}</td>
            <td>{practitioner.prac_Role}</td>
            <td>{practitioner.idemnifier}</td>
            <td>{practitioner.perCent_Involved}</td>
            <td><button className="btn">X</button></td>
          </tr>
          <tr><td colSpan="12"><button className="btn" onClick={handleAddPractitioner}>Add</button></td></tr>
        </tbody>
      </table>
    </div>
  );
};

export default ViewPractioner;
