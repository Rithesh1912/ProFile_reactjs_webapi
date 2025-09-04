import React from "react";
import "./CaseHeader.css"; // optional for styling
import { CaseContext } from "../ContextAPI/CaseContext";

const CaseHeader = () => {
  const {caseData}=React.useContext(CaseContext);
  const{caseId,subsidId,status,mduLiability,caseHandler1,caseHandler2}=caseData;
  
  return (
    <div className="case-header">
      <table className="case-header-table">
        <tbody>
          <tr>
            <td className="label">Case ID</td>
            <td>{caseId}</td>
            <td className="label">Sub</td>
            <td>{subsidId}</td>
            <td className="label">Status</td>
            <td>Active</td>
            <td className="label">Liability</td>
            <td>{mduLiability}</td>
          </tr>
          <tr>
            <td className="label">Lead Practitioner</td>
            <td>{caseHandler1}</td>
            <td className="label">Case Handler</td>
            <td>{caseHandler2}</td>
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
