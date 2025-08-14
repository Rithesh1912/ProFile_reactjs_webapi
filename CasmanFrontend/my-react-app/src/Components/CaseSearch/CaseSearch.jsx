import React, { useState } from 'react';
import './CaseSearch.css';
import casedetails from "../../Assets/case_details.gif";
import cancelimage from "../../Assets/cancel.jpg";
import search from "../../Assets/search.gif";
import axios from "axios";

const CaseSearch = () => {
  const [caseID, setCaseID] = useState('');
  const [subID, setSubID] = useState('');
  const [results, setResults] = useState([]); // 

  const handleCaseIDChange = (e) => setCaseID(e.target.value);
  const handleSubIDChange = (e) => setSubID(e.target.value);

  const handleCaseDetailsClick = () => {
    if (!caseID) {
      alert("Please enter a CaseID to get case details.");
      return;
    }

    axios
      .get("/test.json")
      .then((response) => {
        
        const record = response.data.find(user => user.CaseID.toString() === caseID);
        setResults(record ? [record] : []);
      })
      .catch((error) => {
        console.error("Error fetching case details:", error);
      });
  };

  const handleSearchClick = () => {
    if (!caseID && !subID) {
      alert("Please enter at least CaseID or SubID to search.");
      return;
    }

    // axios
    //   .get("https://jsonplaceholder.typicode.com/users") // dummy API
    //   .then((response) => {
    //     // Filter locally
    //     const filtered = response.data.filter(user =>
    //       (!caseID || user.id.toString() === caseID) &&
    //       (!subID || user.username.toLowerCase().includes(subID.toLowerCase()))
    //     );
    //     setResults(filtered);
    //   })
    //   .catch((error) => {
    //     console.error("Error fetching case details:", error);
    //   });
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
        <button className='casedetails' onClick={handleCaseDetailsClick}>
          <img src={casedetails} alt="Case Details" />
        </button>
        <button className='search' onClick={handleSearchClick}>
          <img src={search} alt="Search" />
        </button>
        <button className='cnclbtn' onClick={handleCancelClick}>
          <img src={cancelimage} alt="Cancel" />
        </button>
      </div>

      
      {results.length > 0 && (
        <table border="1" style={{ marginTop: "30px", width: "70%" }}>
          <thead>
            <tr>
              <th>Case ID</th>
              <th>Sub ID</th>
              
            </tr>
          </thead>
          <tbody>
            {results.map((item) => (
              <tr key={item.CaseID}>
                <td>{item.CaseID}</td>
                <td>{item.SubID}</td>
                
              </tr>
            ))}
          </tbody>
        </table>
      )}
    </div>
  );
};

export default CaseSearch;
