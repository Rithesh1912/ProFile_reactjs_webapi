import React, { useState,useContext } from "react";
import axios from "axios";
import "./StaffLogin.css";
import { useNavigate } from "react-router-dom";
import { CaseContext } from "../ContextAPI/CaseContext";
import { AuthContext } from "../ContextAPI/AuthContext";

const Login = () => {
     const { setCaseData } = useContext(CaseContext);
     const{setToken,setUserId}= useContext(AuthContext); 
  const [formData, setFormData] = useState({
    staffId: "",
    password: ""
  });
 const navigate = useNavigate();
 

  const handleChange = (e) => {
    setFormData({ ...formData, [e.target.name]: e.target.value });
  };

  const handleSubmit = async (e) => {
  e.preventDefault();
  try {
    const res = await axios.post("https://localhost:7277/api/auth/login", formData);

    alert(`Welcome ${res.data.staffName}`);
     navigate("/searchcasedetails");


    localStorage.setItem("userId", res.data.staffId);
    localStorage.setItem("token", res.data.token);

    // ✅ Then update context
    setToken(res.data.token);
    setUserId(res.data.staffId);

    setCaseData({
      
      staffId: res.data.staffId,
      userId: res.data.staffName,
    });

  } catch (err) {
    alert("Login failed");
    console.error("Login error:", err);
  }
};


  return (
    <div className="auth-container">
      <h2>Login</h2>
      <form onSubmit={handleSubmit} className="auth-form">
        <input type="text" name="staffId" placeholder="Staff ID" onChange={handleChange} />
        <input type="password" name="password" placeholder="Password" onChange={handleChange} />
        <button type="submit">Login</button>
      </form>
      
    </div>
  );
};

export default Login;
