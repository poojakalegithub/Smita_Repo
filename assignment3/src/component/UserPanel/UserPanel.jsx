import React from 'react'
import { Link } from 'react-router-dom'
import UserPanelNavbar from './UserPanelNavbar'

const UserPanel = () => {
  const img1 = require('./hotel.jpg')
  return (
    <div>
      <UserPanelNavbar/>  
      <img class="d-block w-100" src={img1} height='500px' width='10px' alt="First slide" />
    </div>
  )
}

export default UserPanel