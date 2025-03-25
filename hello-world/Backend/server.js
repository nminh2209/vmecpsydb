const express = require('express');
const bodyParser = require('body-parser');
const mysql = require('mysql2');
const cors = require('cors');
const multer = require('multer');
const path = require('path');

const app = express();
const port = 5000;

// Middleware
app.use(cors());
app.use(bodyParser.json());

// MySQL Connection – adjust credentials as needed
const connection = mysql.createConnection({
  host: 'localhost',
  user: 'root',
  password: 'minh1234minh', // update with your MySQL password
  database: 'psychiatry_system'
});

connection.connect(err => {
  if (err) {
    console.error('Error connecting to MySQL:', err);
    return;
  }
  console.log('Connected to MySQL database');
});

// --- File Upload Setup using Multer ---
// Ensure you have a folder named "uploads" in your project root.
const storage = multer.diskStorage({
  destination: (req, file, cb) => {
    cb(null, 'uploads/');
  },
  filename: (req, file, cb) => {
    // Create a unique filename using timestamp and original name.
    cb(null, Date.now() + '-' + file.originalname);
  }
});
const upload = multer({ storage });

// --- API Endpoints ---

// 1. Doctor Login
app.post('/api/doctors/login', (req, res) => {
  const { email, password } = req.body;
  const sql = 'SELECT * FROM doctors WHERE email = ? AND password = ?';
  connection.query(sql, [email, password], (err, results) => {
    if (err) {
      console.error(err);
      return res.status(500).send('Server error');
    }
    if (results.length > 0) {
      res.status(200).send(results[0]); // In production, never return password info
    } else {
      res.status(401).send({ message: "Invalid credentials" });
    }
  });
});

// 2. Patient Intake Form Submission (Optional – if using direct form fields)
app.post('/api/intake', (req, res) => {
  const { name, email, doctor_id, details } = req.body;
  const sql = 'INSERT INTO patients (name, email, doctor_id, intake_details) VALUES (?, ?, ?, ?)';
  connection.query(sql, [name, email, doctor_id, details], (err, results) => {
    if (err) {
      console.error(err);
      return res.status(500).send('Error saving intake form');
    }
    res.status(200).send({ patientId: results.insertId });
  });
});

// 3. Retrieve Patients for a Specific Doctor
app.get('/api/doctors/:doctorId/patients', (req, res) => {
  const doctorId = req.params.doctorId;
  const sql = 'SELECT * FROM patients WHERE doctor_id = ?';
  connection.query(sql, [doctorId], (err, results) => {
    if (err) {
      console.error(err);
      return res.status(500).send('Error fetching patients');
    }
    res.status(200).send(results);
  });
});

// 4. Doctor Assigns an Assessment (for record-keeping)
app.post('/api/assessments', (req, res) => {
  const { patient_id, doctor_id, assessment_type } = req.body;
  const sql = 'INSERT INTO assessments (patient_id, doctor_id, assessment_type, status) VALUES (?, ?, ?, ?)';
  connection.query(sql, [patient_id, doctor_id, assessment_type, 'pending'], (err, results) => {
    if (err) {
      console.error(err);
      return res.status(500).send('Error assigning assessment');
    }
    res.status(200).send({ assessmentId: results.insertId });
  });
});

// 5. Retrieve Assessments for a Patient
app.get('/api/patients/:patientId/assessments', (req, res) => {
  const patientId = req.params.patientId;
  const sql = 'SELECT * FROM assessments WHERE patient_id = ?';
  connection.query(sql, [patientId], (err, results) => {
    if (err) {
      console.error(err);
      return res.status(500).send('Error fetching assessments');
    }
    res.status(200).send(results);
  });
});

// 6. Submit Assessment Responses (Full Test Submission)
// Modified to insert a new record for each submission, so that each test submission becomes a new history entry.
app.post('/api/assessments/submit', (req, res) => {
  const { patient_id, assessment_type, responses, doctor_id } = req.body;
  
  // Compute total score by summing responses
  let score = 0;
  for (let key in responses) {
    score += Number(responses[key]) || 0;
  }
  
  // Compute subscale breakdown for supported assessments
  let breakdown = null;
  if (assessment_type === "DASS-21") {
    const subscales = {
      Stress: [1, 6, 8, 11, 12, 14, 18],
      Anxiety: [2, 4, 7, 9, 15, 19, 20],
      Depression: [3, 5, 10, 13, 16, 17, 21],
    };
    breakdown = {};
    Object.keys(subscales).forEach((scale) => {
      breakdown[scale] = subscales[scale].reduce(
        (sum, qId) => sum + (Number(responses[qId]) || 0),
        0
      );
    });
  } else if (assessment_type === "K9") {
    const subscales = {
      "Emotional Stability": [1, 2, 3, 4, 5],
      "Social Function": [6, 7, 8, 9, 10]
    };
    breakdown = {};
    Object.keys(subscales).forEach((scale) => {
      breakdown[scale] = subscales[scale].reduce(
        (sum, qId) => sum + (Number(responses[qId]) || 0),
        0
      );
    });
  } else if (assessment_type === "PHQ-12") {
    // For PHQ-12, we divide the 12 questions into two aspects:
    const subscales = {
      "Cognitive/Affective": [1, 2, 3, 4, 5, 6],
      "Somatic": [7, 8, 9, 10, 11, 12]
    };
    breakdown = {};
    Object.keys(subscales).forEach((scale) => {
      breakdown[scale] = subscales[scale].reduce(
        (sum, qId) => sum + (Number(responses[qId]) || 0),
        0
      );
    });
  }
  
  const responsesJSON = JSON.stringify(responses);
  const breakdownJSON = breakdown ? JSON.stringify(breakdown) : null;
  
  // Insert a new assessment record with the submission data
  const sql = 'INSERT INTO assessments (patient_id, doctor_id, assessment_type, responses, score, breakdown, status) VALUES (?, ?, ?, ?, ?, ?, ?)';
  connection.query(sql, [patient_id, doctor_id, assessment_type, responsesJSON, score, breakdownJSON, 'completed'], (err, results) => {
    if (err) {
      console.error(err);
      return res.status(500).send('Error submitting assessment responses');
    }
    res.status(200).send({ message: 'Test responses submitted', score, breakdown });
  });
});

// 7. New Endpoint: File Upload for Intake Form
// This endpoint allows the patient to upload a Word document of their intake form.
app.post('/api/upload-intake', upload.single('intakeForm'), (req, res) => {
  if (!req.file) {
    return res.status(400).send('No file uploaded.');
  }
  
  // Get patient ID from the request body (ensure the client sends this)
  const patientId = req.body.patient_id;
  const filePath = req.file.path; // This is the path where the file was saved
  
  if (patientId) {
    // Update the patient's record with the file path
    const updateSql = 'UPDATE patients SET intake_file = ? WHERE id = ?';
    connection.query(updateSql, [filePath, patientId], (err, results) => {
      if (err) {
        console.error(err);
        return res.status(500).send('Error updating patient record with file path');
      }
      res.status(200).send({ message: 'Intake form uploaded and patient record updated', file: req.file });
    });
  } else {
    // If no patient_id is provided, just return success
    res.status(200).send({ message: 'Intake form uploaded successfully (no patient update)', file: req.file });
  }
});

// Start Server
app.listen(port, () => {
  console.log(`Server is running on port ${port}`);
});
