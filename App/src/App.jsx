import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'

function Button({label, onClick}) {
  return (
    <button onClick={onClick}>
      {label}
    </button>
  )
}

function App() {

  const handleIncrement = () => {
    const element = document.getElementById('a');
    var Count = parseInt(element.textContent);
    element.textContent = Count + 1;
    console.log("Increment clicked");
  }

  const handleDecrement = () => {
    const element = document.getElementById('a');
    var Count = parseInt(element.textContent);
    element.textContent = Count - 1;
    console.log("Decrement clicked");
  }

  return (
    <>
      <div>
        <h2 id = "a"> 0 </h2>
        <Button label= "Increment" onClick={handleIncrement} />
        <Button label= "Decrement" onClick={handleDecrement} />
      </div>

      <h1>Vite + React</h1>
      <div className="card">
        <p>
          Edit <code>src/App.jsx</code> and save to test HMR
        </p>
      </div>
      <p className="read-the-docs">
        Click on the Vite and React logos to learn more
      </p>
    </>
  )
}

export default App
