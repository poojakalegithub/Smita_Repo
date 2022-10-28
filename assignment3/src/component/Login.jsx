import React from 'react'
import { useState } from 'react'
import { Link, Navigate, useNavigate } from 'react-router-dom'

function Login() {
  
  const username = localStorage.getItem('UserName');
  const userpassword = localStorage.getItem('Userpassword')

  const [uname, setUName] = useState('')
  const [upassword, setupassword] = useState('')
// const navigate=useNavigate();

  const onChangeUName = (e) => {
    setUName(e.target.value);
  };
  const onChangeupassword = (e) => {
    setupassword(e.target.value);
  };

  const onSubmit = () => {
    console.log('registeration page:' + username);
    console.log('login page' + uname);
    console.log('registeration page:' + userpassword);
    console.log('login page' + upassword);

    if (username === uname && userpassword === upassword) {
      window.alert("Login Successfull..!")
      // navigate('/dashboard')
    }
    else {
      window.alert("Login Failed..!")
      // navigate('/dashboard')
    }
  }

  return (
    <div><div className=" col d-flex justify-content-center m-2">
      <div className="border border-success p-5">
        <h3>Login </h3>
        <label className="m-1 row">User name : </label>
        <input type='text' value={uname} onChange={onChangeUName} className="m-1 row form-control" placeholder='Enter user-ID' required></input>
        <label className="m-1 row">Password :</label>
        <input type='text' value={upassword} onChange={onChangeupassword} className="m-1 row form-control" placeholder='Enter Password  ' required></input>
        <div className="text-center">
          <button className="row mt-2 btn btn-success row " onClick={onSubmit} type='submit'>Login</button>
        </div>
        
        <h6>Don't have account ? <Link to="/user-registration"> Sign Up</Link></h6>
      </div>
    </div></div>
  )
}

export default Login