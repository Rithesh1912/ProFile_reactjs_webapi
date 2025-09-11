import React, { useContext } from "react";
import { CaseContext } from "../ContextAPI/CaseContext";

const RecentCases = () => {
  const { RecentCases } = useContext(CaseContext);

  return (
    <div>
      <h2>Recent Cases</h2>
      {RecentCases.length === 0 ? (
        <p>No recent cases visited.</p>
      ) : (
        <ul>
          {RecentCases.map((c) => (
            <li key={c.caseId}>
              <strong>{c.caseId}</strong> - {c.subId}
            </li>
          ))}
        </ul>
      )}
    </div>
  );
};

export default RecentCases;
