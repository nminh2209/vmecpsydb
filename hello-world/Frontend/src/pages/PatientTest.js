// src/pages/PatientTest.js
import React, { useState } from 'react';
import axios from 'axios';
import '../styling/PatientTest.css';

// Full sets of questions for each assessment type
const testData = {
  "DASS-21": [
    { id: 1, question: "I found it hard to wind down." },
    { id: 2, question: "I was aware of dryness of my mouth." },
    { id: 3, question: "I couldn’t seem to experience any positive feeling at all." },
    { id: 4, question: "I experienced breathing difficulty (e.g. excessively rapid breathing, breathlessness in the absence of physical exertion)." },
    { id: 5, question: "I found it difficult to work up the initiative to do things." },
    { id: 6, question: "I tended to over-react to situations." },
    { id: 7, question: "I experienced trembling (e.g. in the hands)." },
    { id: 8, question: "I felt that I was using a lot of nervous energy." },
    { id: 9, question: "I was worried about situations in which I might panic and make a fool of myself." },
    { id: 10, question: "I felt that I had nothing to look forward to." },
    { id: 11, question: "I found myself getting agitated." },
    { id: 12, question: "I found it difficult to relax." },
    { id: 13, question: "I felt down-hearted and blue." },
    { id: 14, question: "I was intolerant of anything that kept me from getting on with what I was doing." },
    { id: 15, question: "I felt I was close to panic." },
    { id: 16, question: "I was unable to become enthusiastic about anything." },
    { id: 17, question: "I felt I wasn’t worth much as a person." },
    { id: 18, question: "I felt that I was rather touchy." },
    { id: 19, question: "I was aware of the action of my heart in the absence of physical exertion." },
    { id: 20, question: "I felt scared without any good reason." },
    { id: 21, question: "I felt that life was meaningless." }
  ],
  "K9": [
    { id: 1, question: "I feel calm and at ease." },
    { id: 2, question: "I am easily stressed." },
    { id: 3, question: "I often feel restless." },
    { id: 4, question: "I find it hard to concentrate." },
    { id: 5, question: "I get upset quickly." },
    { id: 6, question: "I enjoy social interactions." },
    { id: 7, question: "I prefer to work alone." },
    { id: 8, question: "I feel overwhelmed by responsibilities." },
    { id: 9, question: "I am optimistic about the future." },
    { id: 10, question: "I feel confident in my abilities." }
  ],
  "PHQ-12": [
    { id: 1, question: "Little interest or pleasure in doing things." },
    { id: 2, question: "Feeling down, depressed, or hopeless." },
    { id: 3, question: "Trouble falling or staying asleep, or sleeping too much." },
    { id: 4, question: "Feeling tired or having little energy." },
    { id: 5, question: "Poor appetite or overeating." },
    { id: 6, question: "Feeling bad about yourself or that you are a failure." },
    { id: 7, question: "Trouble concentrating on things." },
    { id: 8, question: "Moving or speaking so slowly that other people could notice, or the opposite." },
    { id: 9, question: "Thoughts that you would be better off dead or of hurting yourself." },
    { id: 10, question: "Feeling anxious or on edge." },
    { id: 11, question: "Difficulty making decisions." },
    { id: 12, question: "Feeling overwhelmed by daily tasks." }
  ]
};

// Answer options for each question (values 0-3)
const options = [
  { value: 0, label: "Did not apply to me at all" },
  { value: 1, label: "Applied to me to some degree, or some of the time" },
  { value: 2, label: "Applied to me to a considerable degree or a good part of the time" },
  { value: 3, label: "Applied to me very much or most of the time" }
];

const PatientTest = ({ assessmentType, patientId }) => {
  // Choose the appropriate question set based on the assessment type.
  const questions = testData[assessmentType] || testData["DASS-21"];
  // State to hold responses and result breakdown (if applicable)
  const [responses, setResponses] = useState({});
  const [resultBreakdown, setResultBreakdown] = useState(null);

  const handleOptionChange = (questionId, value) => {
    setResponses({ ...responses, [questionId]: value });
  };

  const handleSubmit = async (e) => {
    e.preventDefault();

    // For DASS-21, compute separate subscale scores
    let breakdown = {};
    if (assessmentType === "DASS-21") {
      const subscales = {
        Stress: [1, 6, 8, 11, 12, 14, 18],
        Anxiety: [2, 4, 7, 9, 15, 19, 20],
        Depression: [3, 5, 10, 13, 16, 17, 21],
      };
      Object.keys(subscales).forEach((scale) => {
        breakdown[scale] = subscales[scale].reduce(
          (sum, qId) => sum + (Number(responses[qId]) || 0),
          0
        );
      });
    }

    try {
      // Send the test responses and breakdown to the backend.
      // Note: The backend should be modified to handle the 'breakdown' field.
      await axios.post('http://localhost:5000/api/assessments/submit', {
        patient_id: patientId,
        assessment_type: assessmentType,
        responses,
        breakdown,  // <-- Added this line to send breakdown
      });
      // If DASS-21, set the breakdown so results are displayed on the page.
      if (assessmentType === "DASS-21") {
        setResultBreakdown(breakdown);
      } else {
        alert('Test submitted successfully!');
      }
    } catch (error) {
      console.error(error);
      alert('Error submitting test');
    }
  };

  return (
    <div className="patient-test-container">
      <h2>{assessmentType} Test</h2>
      <form onSubmit={handleSubmit}>
        {questions.map((q) => (
          <div key={q.id} className="question">
            <p>{q.id}. {q.question}</p>
            {options.map((opt) => (
              <label key={opt.value}>
                <input
                  type="radio"
                  name={`question-${q.id}`}
                  value={opt.value}
                  checked={responses[q.id] === opt.value}
                  onChange={() => handleOptionChange(q.id, opt.value)}
                />
                {opt.label}
              </label>
            ))}
          </div>
        ))}
        <button type="submit">Submit Test</button>
      </form>
      {resultBreakdown && (
        <div style={{ marginTop: '1rem' }}>
          <h3>Results Breakdown (DASS-21)</h3>
          <p><strong>Stress:</strong> {resultBreakdown.Stress}</p>
          <p><strong>Anxiety:</strong> {resultBreakdown.Anxiety}</p>
          <p><strong>Depression:</strong> {resultBreakdown.Depression}</p>
        </div>
      )}
    </div>
  );
};

export default PatientTest;
