import React, { useState } from "react";
import axios from "axios";
import './StaffRegister.css';

const Register = () => {
  const [formData, setFormData] = useState({
    staffNo: "",
    staffId: "",
    staffName: "",
    deptId: "",
    team: "",
    teamId: "",
    modifiedBy: "",
    password: ""
  });

  const [message, setMessage] = useState("");

  const handleChange = (e) => {
    setFormData({ ...formData, [e.target.name]: e.target.value });
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    try {
      const res = await axios.post("https://localhost:7277/api/auth/register", formData);
      setMessage(res.data);
    } catch (err) {
      setMessage(err.response?.data || "Registration failed");
    }
  };

  return (
    <div className="auth-container">
      <h2>Register</h2>
      <form onSubmit={handleSubmit} className="auth-form">
        <input type="text" name="staffNo" placeholder="Staff No" onChange={handleChange} />
        <input type="text" name="staffId" placeholder="Staff ID" onChange={handleChange} />
        <input type="text" name="staffName" placeholder="Staff Name" onChange={handleChange} />
        <input type="text" name="deptId" placeholder="Dept ID" onChange={handleChange} />
        <input type="text" name="team" placeholder="Team" onChange={handleChange} />
        <input type="number" name="teamId" placeholder="Team ID" onChange={handleChange} />
        <input type="text" name="modifiedBy" placeholder="Modified By" onChange={handleChange} />
        <input type="password" name="password" placeholder="Password" onChange={handleChange} />
        <button type="submit">Register</button>
      </form>
      {message && <p className="msg">{message}</p>}
    </div>
  );
};

export default Register;
