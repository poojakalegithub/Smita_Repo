import React from 'react'
import { Link } from 'react-router-dom'
import { useNavigate } from 'react-router-dom'
import AdminNavbar from './AdminNavbar'

function Dashboard() {
  const img = require('./UserPanel/hotel2.jpg')
  const navigate = useNavigate()
  return (
    <div>
      <AdminNavbar />
      <img src={img} className='w-100 rounded float-start'></img>
    </div>
  )
}

export default Dashboard