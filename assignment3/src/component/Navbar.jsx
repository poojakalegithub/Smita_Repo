import React from 'react'
import { Link, Route, Routes } from 'react-router-dom';
import AddRestaurant from './OwnerRegistration';
import Login from './Login';
import ShowRestaurantInTable from './RestaurantList';
import array from './Add';
import RestaurantData from './RestaurantData.json';
import TodoList from './Add'
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
            <li className="nav-item">
              <Link className="nav-link" to="/login">Login</Link>
            </li>
            <li className="nav-item">
              <Link className="nav-link" to="/user-registration">Sign Up</Link>
            </li>
          </ul>
        </div>
      </nav>
     
      <div>
        <div><br/>
          <h4><i>Available Hotels on Our Website</i></h4>
          <hr/>
          <br/>
          <table class="container table table-striped table-hover ">
            <thead>
              <th>ID</th>
              <th>Title</th>
              <th>Address</th>
              <th>Contact</th>
            </thead>
            <tbody>
              {RestaurantData.map((values) => {
                return (
                  <tr>
                    <td>{values.id}</td>
                    <td>{values.title}</td>
                    <td>{values.address}</td>
                    <td>{values.MobNo}</td>
                  </tr>
                )
              })}
            </tbody>
          </table>

        </div>
              {TodoList}
      </div>
    </div>


  )
}

export default Navbar