import React, { useState, useContext } from 'react';
import './CaseSearch.css';
import cancelimage from "../../Assets/cancel.jpg";
import search from "../../Assets/search.gif";
import axios from "axios";
import { Link } from 'react-router-dom';
import { CaseContext } from '../ContextAPI/CaseContext';
import CaseHeader from '../CaseHeader/CaseHeader';
import { useNavigate } from 'react-router-dom';

const CaseSearch = () => {
  const { caseData, setCaseData } = useContext(CaseContext);
  const [caseID, setCaseID] = useState('');
  const [subID, setSubID] = useState('');
  const [results, setResults] = useState([]);
  const [totalCount, setTotalCount] = useState(0);
  const [pageNumber, setPageNumber] = useState(1);
  const [pageSize] = useState(5); // fixed size per page
  const [loading, setLoading] = useState(false);
   const navigate = useNavigate();
  const totalPages = Math.ceil(totalCount / pageSize);

  const handleCaseIDChange = (e) => setCaseID(e.target.value);
  const handleSubIDChange = (e) => setSubID(e.target.value);

  const fetchCases = async (page = 1) => {
    if (!caseID && !subID) {
      alert("Please enter at least CaseID or SubID to search.");
      return;
    }

    const requestDto = {
      caseID: caseID || null,
      subsidID: subID || null,
      pageNumber: page,
      pageSize: pageSize
    };

    setLoading(true);
    try {
      const response = await axios.post("https://localhost:7277/api/Case/search", requestDto);
      setResults(response.data.items || []);
      setTotalCount(response.data.totalCount || 0);
      setPageNumber(response.data.pageNumber || page);
    } catch (error) {
      console.error("Error searching case details:", error);
      setResults([]);
    } finally {
      setLoading(false);
    }
  };

  const handleSearchClick = () => fetchCases(1);

  const handleCancelClick = () => {
    setCaseID('');
    setSubID('');
    setResults([]);
    setTotalCount(0);
    setPageNumber(1);
  };
 
const handleRowClick = async (item) => {
  try {
    const response = await axios.get(
      `https://localhost:7277/api/Case/GetCaseDetailsByCaseId/${item.caseId}/${item.subsidId}`
    );
    const caseDetails = response.data;
    console.log("✅ Fetched case details:", caseDetails);
    

    // Save in context
    setCaseData(caseDetails);

    // Save in sessionStorage for persistence
    sessionStorage.setItem("caseData", JSON.stringify(caseDetails));

    // Navigate to General page
    navigate("/General");
  } catch (error) {
    console.error("❌ Error fetching case details:", error);
    alert("Failed to load case details");
  }
};


  return (
    <div className="container">
      <CaseHeader
        caseId={caseData?.caseId}
        subId={caseData?.subId}
        status={caseData?.status}
        liability={caseData?.liability}
        handler={caseData?.handler}
        practitioner={caseData?.practitioner}
      />

      <h2>🔎 Search Case Details</h2>

      <div className="search-box">
        <input
          type="text"
          placeholder="CaseID"
          value={caseID}
          onChange={handleCaseIDChange}
        />
        <input
          type="text"
          placeholder="SubID"
          value={subID}
          onChange={handleSubIDChange}
        />
        <button className="search-btn" onClick={handleSearchClick}>
          <img src={search} alt="Search" />
        </button>
        <button className="cancel-btn" onClick={handleCancelClick}>
          <img src={cancelimage} alt="Cancel" />
        </button>
      </div>

      {loading && <p>Loading cases...</p>}

      {results.length > 0 && (
        <>
          <table className="case-table">
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
    <tr key={index} onClick={() => handleRowClick(item)} style={{ cursor: "pointer" }}>
      <td><a>{item.caseId}</a></td>
      <td>{item.subsidId}</td>
      <td>{item.mduUnit}</td>
      <td>{item.incdtDate ? new Date(item.incdtDate).toLocaleDateString() : ""}</td>
      <td>{item.openDate ? new Date(item.openDate).toLocaleDateString() : ""}</td>
      <td>{item.closeDate ? new Date(item.closeDate).toLocaleDateString() : ""}</td>
      <td>{item.userId}</td>
      <td>{item.legalCaseDocumentStatus}</td>
    </tr>
  ))}
            </tbody>
          </table>

          {/* Pagination Controls */}
          <div className="pagination">
            <button
              disabled={pageNumber === 1}
              onClick={() => fetchCases(pageNumber - 1)}
            >
              ⬅ Prev
            </button>
            <span>
              Page {pageNumber} of {totalPages}
            </span>
            <button
              disabled={pageNumber === totalPages}
              onClick={() => fetchCases(pageNumber + 1)}
            >
              Next ➡
            </button>
          </div>
        </>
      )}

      {results.length === 0 && !loading && totalCount === 0 && (
        <p>No results found. Try another search.</p>
      )}
    </div>
  );
};

export default CaseSearch;
