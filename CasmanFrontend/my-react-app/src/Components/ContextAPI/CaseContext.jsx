import React, { createContext, useState, useEffect } from "react";

export const CaseContext = createContext({
  caseData: null,
  setCaseData: () => {},
  RecentCases: [],
  addCase: () => {}
});

export const CaseProvider = ({ children }) => {
  const [caseData, setCaseData] = useState({
    caseId: null,
    subsidId: null,
    userId: null,
    staffName: null,
    status: null,
    liability: null,
    caseHandler1: null,
    caseHandler2: null
  });

  const [RecentCases, setRecentCases] = useState([]);

  // Restore caseData from sessionStorage when app starts
  useEffect(() => {
    const savedCase = sessionStorage.getItem("caseData");
    if (savedCase) {
      setCaseData(JSON.parse(savedCase));
    }
  }, []);

  // Keep sessionStorage updated whenever caseData changes
  useEffect(() => {
    if (caseData && caseData.caseId) {
      sessionStorage.setItem("caseData", JSON.stringify(caseData));
    }
  }, [caseData]);

  // const addCase = (newCase) => {
  //   setCaseData(newCase);

  //   setRecentCases((prevCases) => {
  //     const updatedCases = prevCases.filter((c) => c.caseId !== newCase.caseId);
  //     return [newCase, ...updatedCases].slice(0, 10);
  //   });
  // };

  return (
    <CaseContext.Provider value={{ caseData, setCaseData, RecentCases }}>
      {children}
    </CaseContext.Provider>
  );
};
