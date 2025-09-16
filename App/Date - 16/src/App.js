import './App.css';
import { useState } from 'react';


function App(){
  const ContainerStyle = {
  
  };

  const [counter, setCounter] = useState(0);

  const buttonHandler = () => {
    // setCounter(prev => prev + 1)
    setCounter(counter + 1)
  }


  return (
  <div classname = "container"
  style={ContainerStyle}
  >
  <p style={{fontsize: "100px" }}>(counter)</p>
  <div>
  <button onClick={buttonHandler}>Increment</button>
  </div>
</div>  
);

export default App;