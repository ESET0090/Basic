
import { useState } from 'react'
import React from 'react'

const dummyJson ={
    "firstName": "myFirstName",
    "lastName": "myLastName",
    "jsonKey":{


    }

}

export default function FormEventComponent() {
    //console.log(dummyJson.firstName)

    const [username, SetUsername] = useState("dsaewfree");

    const onChangeHandler = (event) =>{
        SetUsername(event.target.value)
        alert("this is alert")
    } 
  return (
    <div>
      <input type = "text"  value = {username}  placeholder = "Enter Your username" onChange={onChangeHandler}/>
    </div>
  )
}
