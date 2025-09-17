import './App.css';
import ButtonComponent from './components/button_Component';
import MouseEvent from './components/MouseEvent';
import FormEventComponent from './components/FormEventComponent';

function App() {

  const buttonHandler = () => {
    console.log('Hello Words');

  };


  return (
    <>
       <ButtonComponent />
       <MouseEvent />
       <FormEventComponent/>


    </>
  );
}

export default App;
