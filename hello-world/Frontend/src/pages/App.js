// src/App.js
import React, { useState, useEffect } from 'react';
import { Route, Routes, Navigate } from 'react-router-dom';
import DoctorLogin from './DoctorLogin';
import DoctorDashboard from './DoctorDashboard';
import PatientTestAssign from './PatientTestAssign';
import IntakeForm from './IntakeForm';
import PatientTest from './PatientTest';
import PatientPortal from './PatientPortal';

function App() {
  // Initialize doctor state from localStorage if available.
  const [doctor, setDoctor] = useState(() => {
    const storedDoctor = localStorage.getItem('doctor');
    return storedDoctor ? JSON.parse(storedDoctor) : null;
  });

  // Optionally, update localStorage whenever doctor state changes.
  useEffect(() => {
    if (doctor) {
      localStorage.setItem('doctor', JSON.stringify(doctor));
    }
  }, [doctor]);

  // A simple guard to check if doctor is logged in.
  const ProtectedRoute = ({ children }) => {
    if (!doctor) {
      return <Navigate to="/login" />;
    }
    return children;
  };

  return (
    <div className="App">
      <Routes>
        {/* Doctor routes */}
        <Route path="/login" element={<DoctorLogin setDoctor={setDoctor} />} />
        <Route
          path="/dashboard"
          element={
            <ProtectedRoute>
              <DoctorDashboard doctor={doctor}  setDoctor={setDoctor} />
            </ProtectedRoute>
          }
        />
        <Route
          path="/assign-test/:patientId"
          element={
            <ProtectedRoute>
              <PatientTestAssign doctor={doctor} />
            </ProtectedRoute>
          }
        />

        {/* Patient routes */}
        <Route path="/patient/intake" element={<IntakeForm />} />
        <Route path="/patient/test" element={<PatientTest assessmentType="DASS-21" patientId={123} />} />
        <Route path="/patient/portal" element={<PatientPortal patientId={123} />} />

        {/* Catch-all route */}
        <Route path="*" element={<Navigate to="/login" />} />
      </Routes>
    </div>
  );
}

export default App;
