

function ButtonComponent() {

  const buttonHandler = () => {
    console.log('Hello Words');

  };


  return (
    <>
    <button onClick={buttonHandler}>click me </button>
    </>
  );
}

export default ButtonComponent;
