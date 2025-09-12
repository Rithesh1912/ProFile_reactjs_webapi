import React, { createContext, useState, useEffect } from "react";

export const CaseContext = createContext({
  caseData: null,
  setCaseData: () => {},
  RecentCases: [],
});

export const CaseProvider = ({ children }) => {
  const [caseData, setCaseData] = useState({
    caseId: null,
    subsidId: null,
    userId: null,
    staffName: null,
    status: 'Active',
    liability: null,
    caseHandler1: null,
    caseHandler2: null,
  });

  const [RecentCases, setRecentCases] = useState([]);
   const [isRestored, setIsRestored] = useState(false);

   useEffect(() => {
    const savedCase =
      localStorage.getItem("caseData") || sessionStorage.getItem("caseData");

    if (savedCase) {
      setCaseData(JSON.parse(savedCase));
    }
    setIsRestored(true); // Mark restore done
  }, []);

  // ✅ Only persist after restore is done
  useEffect(() => {
    if (isRestored && caseData) {
      localStorage.setItem("caseData", JSON.stringify(caseData));
      sessionStorage.setItem("caseData", JSON.stringify(caseData));
    }
  }, [caseData, isRestored]);

  return (
    <CaseContext.Provider value={{ caseData, setCaseData, RecentCases, setRecentCases }}>
      {children}
    </CaseContext.Provider>
  );
};
