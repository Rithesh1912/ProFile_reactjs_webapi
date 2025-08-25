import React, { useState } from 'react';
import './CaseSearch.css';
import casedetails from "../../Assets/case_details.gif";
import cancelimage from "../../Assets/cancel.jpg";
import search from "../../Assets/search.gif";
import axios from "axios";
import { Link } from 'react-router-dom';


const CaseSearch = () => {
  const [caseID, setCaseID] = useState('');
  const [subID, setSubID] = useState('');
  const [results, setResults] = useState([]);

  const handleCaseIDChange = (e) => setCaseID(e.target.value);
  const handleSubIDChange = (e) => setSubID(e.target.value);

  const handleSearchClick = () => {
    if (!caseID && !subID) {
      alert("Please enter at least CaseID or SubID to search.");
      return;
    }

    // Match backend CaseSearchRequestDto properties
    const requestDto = {
      caseID: caseID || null,
      subsidID: subID || null
    };

    axios
      .post("https://localhost:7277/api/Case/search", requestDto)
      .then((response) => {
        setResults(response.data || []);
      })
      .catch((error) => {
        console.error("Error searching case details:", error);
        setResults([]);
      });
  };

  const handleCancelClick = () => {
    setCaseID('');
    setSubID('');
    setResults([]);
  };

  return (
    <div className="container">
      <h2>Search - Case Details Criteria</h2>
      <div className="box">
        <input
          type="text"
          placeholder="CaseID"
          className="input"
          value={caseID}
          onChange={handleCaseIDChange}
        />
        <input
          type="text"
          placeholder="SubID"
          className="input"
          value={subID}
          onChange={handleSubIDChange}
        />
        <button className='search' onClick={handleSearchClick}>
          <img src={search} alt="Search" />
        </button>
        <button className='cnclbtn' onClick={handleCancelClick}>
          <img src={cancelimage} alt="Cancel" />
        </button>
      </div>

      {results.length > 0 && (
        <table border="1" style={{ marginTop: "30px", width: "90%" }}>
          <thead>
            <tr>
              <th>Case ID</th>
              <th>Sub ID</th>
              <th>MDU Unit</th>
              <th>Incident Date</th>
              <th>Open Date</th>
              <th>Close Date</th>
              <th>User ID</th>
              <th>Status</th>
            </tr>
          </thead>
          <tbody>
            {results.map((item, index) => (
              <tr key={index}>
                <td><Link to={`/General?caseId=${item.caseId}&subId=${item.subsidId}`}>{item.caseId}</Link></td>
                <td>{item.subsidId}</td>
                <td>{item.mduUnit}</td>
                <td>{item.incdtDate ? new Date(item.incdtDate).toLocaleDateString() : ''}</td>
                <td>{item.openDate ? new Date(item.openDate).toLocaleDateString() : ''}</td>
                <td>{item.closeDate ? new Date(item.closeDate).toLocaleDateString() : ''}</td>
                <td>{item.userId}</td>
                <td>{item.legalCaseDocumentStatus}</td>
              </tr>
            ))}
          </tbody>
        </table>
      )}
    </div>
  );
};

export default CaseSearch;
