import logo from './logo.svg';
import './App.css';
import { BrowserRouter, Router } from 'react-router-dom';
import NavBar from './components/NavBar';
import { Routes, Route } from 'react-router-dom';
import HomePage from './pages/HomePage';
import AboutPage from './pages/AboutPage';
import ApiPage from './pages/ApiPage';

function App() {
  return (
    <>
  <BrowserRouter>
  <NavBar />

    <Routes>
      <Route path="/" element={<HomePage />}/>
      <Route path="/about" element={<AboutPage />}/>
      <Route path="/api" element={<ApiPage />}/>
    </Routes>

   footer
  </BrowserRouter>
    </>
  );
}

export default App;
