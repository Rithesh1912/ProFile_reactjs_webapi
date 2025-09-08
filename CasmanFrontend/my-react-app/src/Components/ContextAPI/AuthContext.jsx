
import React, { createContext, useState, useEffect } from "react";

export const AuthContext = createContext();

export const AuthProvider = ({ children }) => {
  const [token, setToken] = useState(() => localStorage.getItem('token') || '');
  const [userId, setUserId] = useState(() => localStorage.getItem('userId') || '');

  

//   useEffect(() => {
//     const savedToken = localStorage.getItem("token");
//     const savedUserId = localStorage.getItem("userId");

//     if (savedToken) setToken(savedToken);
//     if (savedUserId) setUserId(savedUserId);
//   }, []);
  
  useEffect(() => {
    if (token) {
      localStorage.setItem("token", token);
    } else {
      localStorage.removeItem("token");
    }

    if (userId) {
      localStorage.setItem("userId", userId);
    } else {
      localStorage.removeItem("userId");
    }
  }, [token, userId]);

 

  return (
    <AuthContext.Provider value={{ token, setToken,userId,setUserId }}>
      {children}
    </AuthContext.Provider>
  );
};
