-- Create the database if it doesn't exist and switch to it.
CREATE DATABASE IF NOT EXISTS psychiatry_system;
USE psychiatry_system;

-- Doctors Table
CREATE TABLE IF NOT EXISTS doctors (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    email VARCHAR(255) UNIQUE NOT NULL,
    password VARCHAR(255) NOT NULL  -- In production, store hashed passwords
);

-- Patients Table
CREATE TABLE IF NOT EXISTS patients (
    id INT AUTO_INCREMENT PRIMARY KEY,
    doctor_id INT,                   -- The doctor responsible for this patient
    name VARCHAR(255) NOT NULL,
    email VARCHAR(255) NOT NULL,
    intake_details TEXT,             -- Additional text data from the intake form
    intake_file VARCHAR(255),        -- File path or URL for the uploaded intake form
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (doctor_id) REFERENCES doctors(id)
);

-- Assessments Table (tracks test assignments and history)
CREATE TABLE IF NOT EXISTS assessments (
    id INT AUTO_INCREMENT PRIMARY KEY,
    patient_id INT NOT NULL,
    doctor_id INT,                   -- The doctor who assigned the test
    assessment_type VARCHAR(50) NOT NULL,  -- e.g., 'DASS-21', 'K9', 'PHQ-12'
    status VARCHAR(50) NOT NULL,           -- e.g., 'pending', 'completed'
    score INT,                             -- The computed total score for the test
    responses TEXT,                        -- JSON string of the test responses
    breakdown TEXT,                        -- JSON string for section breakdown (for DASS-21, etc.)
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (patient_id) REFERENCES patients(id),
    FOREIGN KEY (doctor_id) REFERENCES doctors(id)
);
