// src/pages/DoctorLogin.js
import React, { useState } from 'react';
import axios from 'axios';
import { useNavigate } from 'react-router-dom';
import '../styling/DoctorLogin.css';

// Translation strings
const translations = {
  en: {
    loginTitle: "Doctor Login",
    emailLabel: "Email",
    emailPlaceholder: "Enter your email",
    passwordLabel: "Password",
    passwordPlaceholder: "Enter your password",
    loginButton: "Login",
    invalidAlert: "Invalid email or password",
    toggleLanguage: "Tiếng Việt"
  },
  vn: {
    loginTitle: "Đăng nhập bác sĩ",
    emailLabel: "Email",
    emailPlaceholder: "Nhập email của bạn",
    passwordLabel: "Mật khẩu",
    passwordPlaceholder: "Nhập mật khẩu của bạn",
    loginButton: "Đăng nhập",
    invalidAlert: "Email hoặc mật khẩu không hợp lệ",
    toggleLanguage: "English"
  }
};

const DoctorLogin = ({ setDoctor }) => {
  const [credentials, setCredentials] = useState({ email: '', password: '' });
  const [language, setLanguage] = useState('en'); // Default language is English
  const navigate = useNavigate();

  const handleChange = (e) => {
    setCredentials({ ...credentials, [e.target.name]: e.target.value });
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    axios
      .post('http://localhost:5000/api/doctors/login', credentials)
      .then((response) => {
        // Save doctor info in state and in localStorage for persistence
        setDoctor(response.data);
        localStorage.setItem('doctor', JSON.stringify(response.data));
        navigate('/dashboard');
      })
      .catch((error) => {
        console.error(error);
        alert(translations[language].invalidAlert);
      });
  };

  // Toggle between languages
  const toggleLanguage = () => {
    setLanguage(prev => (prev === 'en' ? 'vn' : 'en'));
  };

  return (
    <div className="doctor-login-container">
      <button className="language-toggle-button" onClick={toggleLanguage}>
        {translations[language].toggleLanguage}
      </button>
      <h2>{translations[language].loginTitle}</h2>
      <form onSubmit={handleSubmit}>
        <div className="form-group">
          <label>{translations[language].emailLabel}:</label>
          <input 
            type="email" 
            name="email" 
            placeholder={translations[language].emailPlaceholder}
            value={credentials.email} 
            onChange={handleChange} 
            required 
          />
        </div>
        <div className="form-group">
          <label>{translations[language].passwordLabel}:</label>
          <input 
            type="password" 
            name="password" 
            placeholder={translations[language].passwordPlaceholder}
            value={credentials.password} 
            onChange={handleChange} 
            required 
          />
        </div>
        <button type="submit">{translations[language].loginButton}</button>
      </form>
    </div>
  );
};

export default DoctorLogin;
