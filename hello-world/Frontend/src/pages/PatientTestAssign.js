// src/pages/PatientTestAssign.js
import React, { useState } from 'react';
import axios from 'axios';
import { useParams, useNavigate } from 'react-router-dom';

const PatientTestAssign = ({ doctor }) => {
  const { patientId } = useParams();
  const navigate = useNavigate();
  const [assessmentType, setAssessmentType] = useState('DASS-21');

  const handleChange = (e) => {
    setAssessmentType(e.target.value);
  };

  const assignTest = (e) => {
    e.preventDefault();
    axios
      .post('http://localhost:5000/api/assessments', {
        patient_id: patientId,
        doctor_id: doctor.id,
        assessment_type: assessmentType,
      })
      .then((response) => {
        alert('Test assigned successfully!');
        navigate('/dashboard');
      })
      .catch((error) => {
        console.error(error);
        alert('Error assigning test');
      });
  };

  return (
    <div>
      <h2>Assign Test to Patient ID: {patientId}</h2>
      <form onSubmit={assignTest}>
        <div>
          <label>Select Assessment Type:</label>
          <select value={assessmentType} onChange={handleChange}>
            <option value="DASS-21">DASS-21</option>
            <option value="K9">K9</option>
            <option value="PHQ-12">PHQ-12</option>
          </select>
        </div>
        <button type="submit">Assign Test</button>
      </form>
    </div>
  );
};

export default PatientTestAssign;
