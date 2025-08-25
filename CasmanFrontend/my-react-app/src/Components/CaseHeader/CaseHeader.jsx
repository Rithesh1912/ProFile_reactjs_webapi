import React from "react";
import "./CaseHeader.css"; // optional for styling

const CaseHeader = ({ caseId, subId, status, liability, handler, practitioner }) => {
  return (
    <div className="case-header">
      <table className="case-header-table">
        <tbody>
          <tr>
            <td className="label">Case ID</td>
            <td>{caseId}</td>
            <td className="label">Sub</td>
            <td>{subId}</td>
            <td className="label">Status</td>
            <td>{status}</td>
            <td className="label">Liability</td>
            <td>{liability}</td>
          </tr>
          <tr>
            <td className="label">Lead Practitioner</td>
            <td>{practitioner}</td>
            <td className="label">Case Handler</td>
            <td>{handler}</td>
            <td className="label">Shared</td>
            <td>-</td>
            <td className="label">Salutation</td>
            <td>-</td>
          </tr>
        </tbody>
      </table>
    </div>
  );
};

export default CaseHeader;
