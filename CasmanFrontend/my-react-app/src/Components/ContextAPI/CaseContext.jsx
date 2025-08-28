import React, { createContext, useState } from "react";

export const CaseContext = createContext({
  caseId: null,
  subId: null,
  userId: null,
  setCaseData: () => {},
});

export const CaseProvider = ({ children }) => {
  const [caseData, setCaseData] = useState({ caseId: null, subId: null,userId: null });
  const[RecentCases,setRecentCases]=useState([]);
  // Function to set current case and add to recent list
  const addCase = (newCase) => {
    setCaseData(newCase);

    setRecentCases((prevCases) => 
     { const updatedCases = prevCases.filter((c) => c.caseId !== newCase.caseId);

      
      return [newCase, ...updatedCases].slice(0, 10); 
    });
  };

  return (
    <CaseContext.Provider value={{ ...caseData,RecentCases,addCase, setCaseData }}>
      {children}
    </CaseContext.Provider>
  );
};
