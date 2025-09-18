import './App.css';
import ButtonComponent from './components/button_Component';
import MouseEvent from './components/MouseEvent';
import FormEventComponent from './components/FormEventComponent';
import LoginFormComponent  from './components/LoginFormComponent';
import useEffectComponent from './components/UseEffectComponent';


function App() {

  const buttonHandler = () => {
    console.log('Hello Words');

  };


  return (
    <>
       <ButtonComponent />
       <MouseEvent />
       <FormEventComponent/>
       {/* <LoginFormComponent/> */}
       <useEffectComponent/>


    </>
  );
}

export default App;
