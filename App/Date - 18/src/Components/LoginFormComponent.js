import react, {createRef, useState} from "react";

function LoginFormComponent() {

    const [loginState, setLoginState] = useState({

        username: "",
        password: ""

    });

    const onUsernameChangeHandler = (e) => {
        setLogininState({
            ...loginState,
            username:e.target.value
        })
    }

    const onPasswordChangeHandler = (e) => {
        setLogininState({
            ...loginState,
            password:e.target.value
        })
    }    

    return(
        <>
        welcome to login page
        <br />
        <form >
        <input type = "text" value = {loginState.username} onChange={onUsernameChangeHandler} />
        <br />
        <input type = "password" value = {loginState.password} onChange={onUsernameChangeHandler} />
        <br />
        <button type = "submit">login</button>    
        <button type = "reset">login</button> 
        </form>
    </>

    );

}

export default LoginFormComponent;

