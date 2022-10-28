import React from 'react'
import { Link } from 'react-router-dom'
import Add from './Add'
import { useNavigate } from 'react-router-dom'

function Dashboard() {
  
 
 
  return (
    <div>

      <nav className="navbar navbar-expand-lg navbar-light navbar-dark bg-dark ">
        <a className="navbar-brand" href="">Welcome To Dashboard {localStorage.getItem('UserName')}</a>
        
        <button className="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarText" aria-controls="navbarText" aria-expanded="false" aria-label="Toggle navigation">
          <span className="navbar-toggler-icon"></span>
        </button>
      
      </nav>

      {/* <Link to="/Add"> Add List Of Restaurants</Link><br/> */}
      {<Add/>}
      
      {/* <Link to="/RestaurantList"> List Restaurant</Link><br/>
      <Link to="/RestaurantAdd"> Book Restaurant</Link><br/>
      <Link to="/RestaurantAdd"> Cancel Booking</Link><br/>
      <Link to="/RestaurantAdd"> User List</Link> */}



      
      

    </div>
  )
}

export default Dashboard