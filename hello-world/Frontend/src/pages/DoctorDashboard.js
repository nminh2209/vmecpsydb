// src/pages/DoctorDashboard.js
import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { useNavigate } from 'react-router-dom';
import PatientTest from './PatientTest';
import TestHistory from './TestHistory';
import '../styling/DoctorDashboard.css';

const AddPatientForm = ({ doctorId, onPatientAdded }) => {
  const [formData, setFormData] = useState({
    name: '',
    email: '',
    intake_details: ''
  });
  
  const handleChange = (e) => {
    setFormData({ ...formData, [e.target.name]: e.target.value });
  };
  
  const handleSubmit = async (e) => {
    e.preventDefault();
    try {
      const response = await axios.post('http://localhost:5000/api/intake', {
        ...formData,
        doctor_id: doctorId
      });
      alert("Patient added successfully!");
      onPatientAdded(response.data.patientId);
      setFormData({
        name: '',
        email: '',
        intake_details: ''
      });
    } catch (error) {
      console.error(error);
      alert("Error adding patient");
    }
  };
  
  return (
    <div className="add-patient-form-container">
      <h3>Add New Patient</h3>
      <form onSubmit={handleSubmit}>
        <label>Name:</label>
        <input type="text" name="name" value={formData.name} onChange={handleChange} required />

        <label>Email:</label>
        <input type="email" name="email" value={formData.email} onChange={handleChange} required />

        <label>Intake Details:</label>
        <textarea name="intake_details" value={formData.intake_details} onChange={handleChange} required />

        <button type="submit">Add Patient</button>
      </form>
    </div>
  );
};

const DoctorDashboard = ({ doctor, setDoctor }) => {
  const [patients, setPatients] = useState([]);
  const [selectedPatientId, setSelectedPatientId] = useState(null);
  const [selectedAssessmentType, setSelectedAssessmentType] = useState('DASS-21');
  const [showAddPatient, setShowAddPatient] = useState(false);
  const [uploadMode, setUploadMode] = useState(false);
  const [uploadFile, setUploadFile] = useState(null);
  const [uploadStatus, setUploadStatus] = useState('');
  const navigate = useNavigate();

  // Fetch patients for the logged in doctor
  const fetchPatients = () => {
    if (doctor) {
      axios
        .get(`http://localhost:5000/api/doctors/${doctor.id}/patients`)
        .then((response) => setPatients(response.data))
        .catch((error) => console.error(error));
    }
  };

  useEffect(() => {
    fetchPatients();
  }, [doctor]);

  const handleShowPatient = (patientId) => {
    // Toggle collapse: if same patient is selected, hide the section.
    if (selectedPatientId === patientId) {
      setSelectedPatientId(null);
      setUploadMode(false); // also hide upload section if open
    } else {
      setSelectedPatientId(patientId);
    }
  };

  const handleAssessmentTypeChange = (e) => {
    setSelectedAssessmentType(e.target.value);
  };

  const handleLogout = () => {
    localStorage.removeItem('doctor');
    setDoctor(null);
    navigate('/login');
  };

  // Callback to refresh patient list when a new patient is added
  const onPatientAdded = (newPatientId) => {
    fetchPatients();
    setShowAddPatient(false);
  };

  // File upload handlers
  const handleFileChange = (e) => {
    setUploadFile(e.target.files[0]);
  };

  const toggleUploadMode = () => {
    setUploadMode(!uploadMode);
    setUploadStatus('');
    setUploadFile(null);
  };

  const handleFileUpload = async (e) => {
    e.preventDefault();
    if (!uploadFile) {
      alert('Please select a file to upload.');
      return;
    }
    const formData = new FormData();
    formData.append('intakeForm', uploadFile);
    // Send patient_id with the file so the backend can update the record.
    formData.append('patient_id', selectedPatientId);

    try {
      const response = await axios.post('http://localhost:5000/api/upload-intake', formData, {
        headers: { 'Content-Type': 'multipart/form-data' },
      });
      setUploadStatus('File uploaded successfully!');
      fetchPatients(); // refresh to see updated file info
    } catch (error) {
      console.error('Upload error:', error);
      setUploadStatus('File upload failed.');
    }
  };

  if (!doctor) {
    return <div>Loading...</div>;
  }

  return (
    <div className="dashboard-container">
      <div className="dashboard-header">
        <h2>Welcome, Dr. {doctor.name}</h2>
        <button className="logout-button" onClick={handleLogout}>Logout</button>
      </div>
      <h3>Your Patients</h3>
      <button onClick={() => setShowAddPatient(!showAddPatient)}>
        {showAddPatient ? 'Hide Add Patient Form' : 'Add New Patient'}
      </button>
      {showAddPatient && <AddPatientForm doctorId={doctor.id} onPatientAdded={onPatientAdded} />}
      <ul className="patient-list">
        {patients.map((patient) => (
          <li key={patient.id}>
            <span>
              {patient.name} ({patient.email})
            </span>
            <button onClick={() => handleShowPatient(patient.id)}>
              {selectedPatientId === patient.id ? 'Hide Details' : 'Show Details'}
            </button>
          </li>
        ))}
      </ul>

      {selectedPatientId && (
        <div className="section-container">
          <h3>Patient ID: {selectedPatientId}</h3>
          {/* Display basic patient info if desired */}
          {/* <p>Intake File: {selectedPatient.intake_file || 'None uploaded'}</p> */}
          
          {/* File Upload Section */}
          <div style={{ marginTop: '1rem' }}>
            <button onClick={toggleUploadMode}>
              {uploadMode ? 'Cancel Upload' : 'Upload Intake Form'}
            </button>
            {uploadMode && (
              <form onSubmit={handleFileUpload} style={{ marginTop: '0.5rem' }}>
                <input type="file" onChange={handleFileChange} accept=".doc,.docx" />
                <button type="submit">Submit File</button>
              </form>
            )}
            {uploadStatus && <p>{uploadStatus}</p>}
          </div>

          <div style={{ marginTop: '1rem' }}>
            <label>Select Assessment Type: </label>
            <select value={selectedAssessmentType} onChange={handleAssessmentTypeChange}>
              <option value="DASS-21">DASS-21</option>
              <option value="K9">K9</option>
              <option value="PHQ-12">PHQ-12</option>
            </select>
          </div>
          <div style={{ marginTop: '1rem' }}>
            <h4>{selectedAssessmentType} Test</h4>
            <PatientTest assessmentType={selectedAssessmentType} patientId={selectedPatientId} />
          </div>
          <div style={{ marginTop: '1rem' }}>
            <TestHistory patientId={selectedPatientId} assessmentType={selectedAssessmentType} />
          </div>
        </div>
      )}
    </div>
  );
};

export default DoctorDashboard;
