import React, { useState } from "react";
import "./ConflictSearch.css";
import axios from "axios";

const ConflictSearch = () => {
  const [surnames, setSurnames] = useState([]);
  const [forenames, setForenames] = useState([]);
  const [surnameInput, setSurnameInput] = useState("");
  const [forenameInput, setForenameInput] = useState("");
  const [joinType, setJoinType] = useState("AND");
  const [soundex, setSoundex] = useState(false);
  const [results, setResults] = useState([]);
  const [loading, setLoading] = useState(false);

  // ✅ add surname
  const handleAddSurname = () => {
    if (surnameInput.trim()) {
      setSurnames([...surnames, surnameInput.trim()]);
      setSurnameInput("");
    }
  };

  // ✅ add forename
  const handleAddForename = () => {
    if (forenameInput.trim()) {
      setForenames([...forenames, forenameInput.trim()]);
      setForenameInput("");
    }
  };

  // ✅ remove surname
  const handleRemoveSurname = (idx) => {
    setSurnames(surnames.filter((_, i) => i !== idx));
  };

  // ✅ remove forename
  const handleRemoveForename = (idx) => {
    setForenames(forenames.filter((_, i) => i !== idx));
  };

  // ✅ reset everything
  const handleReset = () => {
    setSurnames([]);
    setForenames([]);
    setJoinType("AND");
    setSurnameInput("");
    setForenameInput("");
    setSoundex(false);
    setResults([]);
  };

  // Build DTO for API
  const requestDto = {
  surname: surnames.length > 0 ? surnames[surnames.length - 1] : null,
  forename: forenames.length > 0 ? forenames[forenames.length - 1] : null,
  joinType: joinType
};

console.log("Request DTO:", requestDto);

  // ✅ Search API handler
  const handleSearch = async (type) => {
    setLoading(true);
    try {
      let endpoint = "";
      switch (type) {
        case "PATIENT":
          endpoint = "https://localhost:7277/api/Patient/Search";
          break;
        case "PRACTITIONER":
          endpoint = "https://localhost:7277/api/Practioner/GetPracdetailsByName";
          break;
        case "ALL":
          endpoint = "https://localhost:7277/api/Conflict/SearchAll";
          break;
        default:
          return;
      }

      const response = await axios.post(endpoint, requestDto);
      console.log("Search results:", response);
      setResults(response.data || []);
    } catch (error) {
      console.error("Error searching:", error);
      setResults([]);
    } finally {
      setLoading(false);
    }
  };

  return (
    <div className="conflict-container">
      <h2 className="header">Conflict Search</h2>

      <div className="conflict-box">
        {/* Surname Panel */}
        <div className="side-panel">
          <strong>Surnames</strong>
          <div className="input-row">
            <input
              type="text"
              value={surnameInput}
              onChange={(e) => setSurnameInput(e.target.value)}
              placeholder="Enter surname"
            />
            <button type="button" className="add-btn" onClick={handleAddSurname}>
              Add
            </button>
          </div>
          <ul className="list-row">
            {surnames.map((name, idx) => (
              <li key={idx}>
                {name}
                <button
                  type="button"
                  className="remove-btn"
                  onClick={() => handleRemoveSurname(idx)}
                >
                  ✕
                </button>
              </li>
            ))}
          </ul>
        </div>

        {/* Join Panel */}
        <div className="middle-panel">
          <div className="join-row">
            <span>Join</span>
            <label>
              <input
                type="radio"
                value="AND"
                checked={joinType === "AND"}
                onChange={() => setJoinType("AND")}
              />{" "}
              AND
            </label>
            <label>
              <input
                type="radio"
                value="OR"
                checked={joinType === "OR"}
                onChange={() => setJoinType("OR")}
              />{" "}
              OR
            </label>
          </div>
          <button type="button" className="reset-btn" onClick={handleReset}>
            Reset
          </button>
        </div>

        {/* Forename Panel */}
        <div className="side-panel">
          <strong>Forenames</strong>
          <div className="input-row">
            <input
              type="text"
              value={forenameInput}
              onChange={(e) => setForenameInput(e.target.value)}
              placeholder="Enter forename"
            />
            <button type="button" className="add-btn" onClick={handleAddForename}>
              Add
            </button>
          </div>
          <ul className="list-row">
            {forenames.map((name, idx) => (
              <li key={idx}>
                {name}
                <button
                  type="button"
                  className="remove-btn"
                  onClick={() => handleRemoveForename(idx)}
                >
                  ✕
                </button>
              </li>
            ))}
          </ul>
        </div>
      </div>

      {/* Footer Actions */}
      <div className="footer-row">
        <label>
          <input
            type="checkbox"
            checked={soundex}
            onChange={(e) => setSoundex(e.target.checked)}
          />
          Soundex
        </label>
        <button className="action-btn" onClick={() => handleSearch("PATIENT")}>
          Search Patient
        </button>
        <button className="action-btn" onClick={() => handleSearch("PRACTITIONER")}>
          Search Practitioner
        </button>
        <button className="action-btn" onClick={() => handleSearch("ALL")}>
          Search All
        </button>
        <button className="action-btn clear-btn" onClick={handleReset}>
          Clear
        </button>
      </div>

      {/* Results Table */}
      <div className="results">
        {loading && <p>Loading...</p>}
        {!loading && results.length > 0 && (
          <table className="results-table">
            <thead>
              <tr>
                <th>Case ID</th>
                <th>Sub ID</th>
                <th>First Name</th>
                <th>Last Name</th>
                <th>Solicitor</th>
              </tr>
            </thead>
            <tbody>
              {results.map((r, idx) => (
                <tr key={idx}>
                  <td>{r.caseId}</td>
                  <td>{r.subId}</td>
                  <td>{r.pracFirstName}</td>
                  <td>{r.pracLastName}</td>
                  <td>{r.solicitor}</td>
                </tr>
              ))}
            </tbody>
          </table>
        )}
        {!loading && results.length === 0 && <p>No results found.</p>}
      </div>
    </div>
  );
};

export default ConflictSearch;
