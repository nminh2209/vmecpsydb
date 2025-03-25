// src/pages/PatientPortal.js
import React, { useEffect, useState } from 'react';
import axios from 'axios';
import { useNavigate } from 'react-router-dom';

const PatientPortal = ({ patientId }) => {
  const [tests, setTests] = useState([]);
  const navigate = useNavigate();

  useEffect(() => {
    axios
      .get(`http://localhost:5000/api/patients/${patientId}/assigned-tests`)
      .then((response) => setTests(response.data))
      .catch((error) => console.error(error));
  }, [patientId]);

  const handleTakeTest = (test) => {
    // Navigate to the test page.
    // You could pass test info via query params or state; here we simply use the test's assessment type.
    navigate(`/patient/test?assessmentType=${test.assessment_type}&testId=${test.id}`);
  };

  return (
    <div>
      <h2>Your Assigned Tests</h2>
      {tests.length === 0 ? (
        <p>No tests assigned.</p>
      ) : (
        <ul>
          {tests.map((test) => (
            <li key={test.id}>
              {test.assessment_type} - Status: {test.status}{' '}
              {test.status === 'pending' && (
                <button onClick={() => handleTakeTest(test)}>Take Test</button>
              )}
            </li>
          ))}
        </ul>
      )}
    </div>
  );
};

export default PatientPortal;
