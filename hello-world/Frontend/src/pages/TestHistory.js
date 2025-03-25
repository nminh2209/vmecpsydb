// src/pages/TestHistory.js
import React, { useState, useEffect } from 'react';
import axios from 'axios';
import '../styling/TestHistory.css';

const TestHistory = ({ patientId, assessmentType }) => {
  const [history, setHistory] = useState([]);

  useEffect(() => {
    axios
      .get(`http://localhost:5000/api/patients/${patientId}/assessments`)
      .then((response) => setHistory(response.data))
      .catch((error) => console.error(error));
  }, [patientId]);

  // Filter history by the selected assessment type
  const filteredHistory = history.filter(
    (test) => test.assessment_type === assessmentType
  );

  return (
    <div className="test-history-container">
      <h4>{assessmentType} Test History</h4>
      {filteredHistory.length === 0 ? (
        <p>No history available for {assessmentType}.</p>
      ) : (
        filteredHistory.map((test) => {
          let breakdownDisplay = null;
          if (test.breakdown) {
            try {
              const breakdown =
                typeof test.breakdown === "object"
                  ? test.breakdown
                  : JSON.parse(test.breakdown);
              // Render each key/value pair from the breakdown
              breakdownDisplay = (
                <div style={{ marginLeft: "20px" }}>
                  {Object.entries(breakdown).map(([key, value]) => (
                    <p key={key}>
                      <strong>{key}:</strong> {value}
                    </p>
                  ))}
                </div>
              );
            } catch (err) {
              console.error("Error parsing breakdown", err);
            }
          }
          return (
            <div
              key={test.id}
              className="test-history-item"
              style={{
                marginBottom: "1rem",
                borderBottom: "1px solid #ccc",
                paddingBottom: "1rem",
              }}
            >
              <p>
                <strong>{test.assessment_type}</strong> - Status: {test.status} - Total Score:{" "}
                {test.score || "N/A"}
              </p>
              {test.created_at && (
                <p className="info">
                  Date: {new Date(test.created_at).toLocaleString()}
                </p>
              )}
              {breakdownDisplay}
            </div>
          );
        })
      )}
    </div>
  );
};

export default TestHistory;
