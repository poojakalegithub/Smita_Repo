import React from 'react'
import { Link } from 'react-router-dom'
import { useNavigate } from 'react-router-dom'

function Dashboard() {
  const img=require('./UserPanel/hotel2.jpg')
  const navigate=useNavigate()
  const onLogOut = () => {
    navigate('/')
  }

  return (
    <div>

      <nav className="navbar navbar-expand-lg navbar-light navbar-dark bg-dark ">
        <a className="navbar-brand" href="">Welcome To Dashboard {localStorage.getItem('UserName')}</a>
        <button><Link to="/Add">Add Restaurant</Link></button>
        <button onClick={onLogOut}>Log Out</button>
      </nav>
      <img src={img} className='w-100 rounded float-start'></img>
      

    </div>
  )
}

export default Dashboard