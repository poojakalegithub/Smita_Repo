import React from 'react'
import { Link } from 'react-router-dom'


function Dashboard() {
  return (
    <div>
      
      <Link to="/RestaurantAdd"> Add Restaurant</Link><br/>
      <Link to="/RestaurantAdd"> List Of Restaurants</Link><br/>
      <Link to="/RestaurantAdd"> Update Restaurant</Link><br/>
      <Link to="/RestaurantAdd"> Book Restaurant</Link><br/>
      <Link to="/RestaurantAdd"> Cancel Booking</Link><br/>
      <Link to="/RestaurantAdd"> User List</Link>
     

    </div>
  )
}

export default Dashboard