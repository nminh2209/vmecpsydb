import React from "react";
import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
import { Toaster } from "react-hot-toast";
import Home from "./pages/Home";
import Patients from "./pages/Patients";
import Assessments from "./pages/Assessments";
import Navbar from "./components/Navbar";

function App() {
  return (
    <Router>
      <Toaster position="top-right" />
      <Navbar />
      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="/patients" element={<Patients />} />
        <Route path="/assessments" element={<Assessments />} />
      </Routes>
    </Router>
  );
}

export default App;
