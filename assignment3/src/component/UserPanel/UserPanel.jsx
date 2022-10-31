import React from 'react'
import { Link } from 'react-router-dom'

const UserPanel = () => {
    const img1=require('./hotel.jpg')
  return (

<div>

         <nav className="navbar navbar-expand-lg navbar-light navbar-dark bg-dark ">
        <a className="navbar-brand" href="#">Welcome to User Dashborad {localStorage.getItem('UserName')}</a>
        <button className="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarText" aria-controls="navbarText" aria-expanded="false" aria-label="Toggle navigation">
          <span className="navbar-toggler-icon"></span>
        </button>
        <div className="collapse navbar-collapse" id="navbarText">
          <ul className="navbar-nav mr-auto">
            <li className="nav-item active">
              <Link className="nav-link" to='/ShowUserData'>Users List </Link>
            </li>
            <li className="nav-item">
              <Link className="nav-link" to="/Rooms">Rooms</Link>
            </li>
            <li className="nav-item">
              <Link className="nav-link" to="/">Log Out</Link>
            </li>
          </ul>
        </div>
      </nav>
      <img class="d-block w-100" src={img1} height='500px' width='10px' alt="First slide"/>

    </div>
  )
}

export default UserPanel