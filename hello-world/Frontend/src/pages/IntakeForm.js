// src/pages/IntakeForm.js
import React, { useState } from 'react';
import axios from 'axios';

const IntakeForm = () => {
  const [formData, setFormData] = useState({
    name: '',
    email: '',
    doctor_id: '',
    details: '',
  });

  const handleChange = (e) => {
    setFormData({ ...formData, [e.target.name]: e.target.value });
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    axios
      .post('http://localhost:5000/api/intake', formData)
      .then((response) => {
        alert('Intake form submitted successfully!');
      })
      .catch((error) => {
        console.error(error);
        alert('Error submitting intake form');
      });
  };

  return (
    <div>
      <h2>Patient Intake Form</h2>
      <form onSubmit={handleSubmit}>
        <div>
          <label>Name:</label>
          <input type="text" name="name" value={formData.name} onChange={handleChange} required />
        </div>
        <div>
          <label>Email:</label>
          <input type="email" name="email" value={formData.email} onChange={handleChange} required />
        </div>
        <div>
          <label>Doctor ID:</label>
          <input type="number" name="doctor_id" value={formData.doctor_id} onChange={handleChange} required />
        </div>
        <div>
          <label>Intake Details:</label>
          <textarea name="details" value={formData.details} onChange={handleChange} required></textarea>
        </div>
        <button type="submit">Submit</button>
      </form>
    </div>
  );
};

export default IntakeForm;
