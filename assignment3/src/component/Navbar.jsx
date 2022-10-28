import React from 'react'
import {Link, Route, Routes} from 'react-router-dom';
import AddRestaurant from './OwnerRegistration';
import HomePage from './HomePage';
import Login from './Login';


function Navbar() {
  return (
    <div>
        <nav className="navbar navbar-expand-lg navbar-light navbar-dark bg-dark ">
  <a className="navbar-brand" href="#">The Imperial Hotel</a>
  <button className="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarText" aria-controls="navbarText" aria-expanded="false" aria-label="Toggle navigation">
    <span className="navbar-toggler-icon"></span>
  </button>
  <div className="collapse navbar-collapse" id="navbarText">
    <ul className="navbar-nav mr-auto">
      <li className="nav-item active">
        <Link className="nav-link" to='/adminLogin'>Add Restaurant </Link>
      </li>
      {/* <li className="nav-item">
        <Link className="nav-link" to='/OwnerRegistration'>Admin Registration</Link>
      </li> */}
      <li className="nav-item">
        <Link className="nav-link" to="/login">Login</Link>
      </li>
      <li className="nav-item">
        <Link className="nav-link" to="/user-registration">Sign Up</Link>
      </li>
    </ul>
    
  </div>
</nav>
    </div>
   
    
  )
}

export default Navbar