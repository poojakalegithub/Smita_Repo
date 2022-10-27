import React from 'react'
import { useState } from 'react'
import { Link, useNavigate } from 'react-router-dom'
import Dashboard from './Dashboard';

function AdminLogin() {
  // const username = JSON.parse(localStorage.getItem('username'));
  // const userpassword = JSON.parse(localStorage.getItem('password'));
  const adminname = localStorage.getItem('UserName');
  const adminpassword = localStorage.getItem('Userpassword')
  // const adminname = "Admin"
  // const adminpassword = "123"

  const [aname, setaName] = useState('')
  const [apassword, setapassword] = useState('')
const navigate=useNavigate();

  const onChangeUName = (e) => {
    setaName(e.target.value);
  };
  const onChangeupassword = (e) => {
    setapassword(e.target.value);
  };

  const onSubmit = () => {
   
    if (adminname === aname && adminpassword === apassword) {
      window.alert("Login Successfull..!")
      navigate('/Dashboard')
    }
    else {
      window.alert("Login Failed..!")
    }
  }

  return (
    <div><div className=" col d-flex justify-content-center m-2">
      <div className="border border-success p-5">
        <h3>Admin Login </h3>
        <label className="m-1 row">Admin name : </label>
        <input type='text' value={aname} onChange={onChangeUName} className="m-1 row form-control" placeholder='Enter Admin-name' required></input>
        <label className="m-1 row">Password :</label>
        <input type='password' value={apassword} onChange={onChangeupassword} className="m-1 row form-control" placeholder='Enter Password  ' required></input>
        <div className="text-center">
          <button className="row mt-2 btn btn-success row " onClick={onSubmit} type='submit'>Login</button>
        </div>
        <h6>Don't have account? <Link to="/OwnerRegistration"> Sign Up</Link></h6>
      </div>
    </div></div>
  )
}

export default AdminLogin