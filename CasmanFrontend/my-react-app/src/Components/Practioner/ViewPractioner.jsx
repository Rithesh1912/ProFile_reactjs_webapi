import React, { useContext, useEffect, useState } from "react";
import "./ViewPractioner.css";
import { useNavigate } from "react-router-dom";
import { CaseContext } from "../ContextAPI/CaseContext";

const ViewPractioner = () => {
  const [practitioner, setPractitioner] = useState(null);
  const {caseData}=useContext(CaseContext);
    const { caseId, subsidId, status } = caseData;
    console.log("ViewPractitioner component - caseData from context:", caseData);
   
  const navigate = useNavigate();

  useEffect(() => {
    if (!caseId || !subsidId) return;

    fetch(`https://localhost:7277/api/Practioner/GetPractionerDetailsByCaseId/${caseId}/${subsidId}`)
      .then((res) => {
        if (!res.ok) {
          throw new Error("Failed to fetch practitioner details");
        }
        return res.json();
      })
      .then((data) => setPractitioner(data))
      .catch((err) => console.error("Error fetching practitioner:", err));
  }, [caseId, subsidId]);

  if (!practitioner) {
    return <p className="loading">Loading practitioner details...</p>;
  }

  const handleAddPractitioner = () => {
    navigate("/AddPractioner");
  };

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
            <td>
              <button className="btn">X</button>
            </td>
          </tr>
          <tr>
            <td colSpan="7" style={{ textAlign: "center" }}>
              <button className="btn" onClick={handleAddPractitioner}>
                Add Practitioner
              </button>
            </td>
          </tr>
        </tbody>
      </table>
    </div>
  );
};

export default ViewPractioner;
