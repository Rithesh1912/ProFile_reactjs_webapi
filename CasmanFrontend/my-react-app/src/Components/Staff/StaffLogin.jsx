import React, { useState,useContext } from "react";
import axios from "axios";
import "./StaffLogin.css";
import { useNavigate } from "react-router-dom";
import { CaseContext } from "../ContextAPI/CaseContext";

const Login = () => {
     const { setCaseData } = useContext(CaseContext); 
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
       setCaseData({
        caseId: null,
        subId: null,
        staffId: res.data.staffId,
        staffName: res.data.staffName,
      });
       setTimeout(() => {
        navigate("/searchcasedetails");
      }, 1000);
    } catch (err) {
      alert("Login failed");
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
