import React from 'react'
import { useState } from 'react';
import { Link, useNavigate } from 'react-router-dom';
import UserPanelNavbar from './UserPanelNavbar';

function CancelBooking() {

    const [reason, setReason] = useState('')
    const username=localStorage.getItem('UserName')
    const email=localStorage.getItem('UserEmail')
    const navigate=useNavigate();

    const onChangeReason=(e)=>{
        setReason(e.target.value)
    }

    //Function to call on click of cancel booking button
    function onSubmit() {
        const hotelcancel = JSON.parse(localStorage.getItem("hotelbookcancel") || "[]");
    const hotelbookcancel = {
        Cusername: username,
        Cemail: email,
        Creason: reason     
    };
        hotelcancel.push(hotelbookcancel);
        localStorage.setItem("hotelbookcancel", JSON.stringify(hotelcancel));
      window.alert("Successfully cancelled your booking")
      navigate('/CancelledBookings')  
    }
  
  return (
    <div>
    <UserPanelNavbar/>
      <div className=" col d-flex justify-content-center m-2">
                 <div className="border border-success p-5">
                    <h3>Cancel Booking </h3>
                    <input type='textbox' value={reason} onChange={onChangeReason} className="m-1 row form-control" placeholder='reason to cancel booking ' required></input>
                    <div className="text-center">
                        <button className="row mt-2 btn btn-success row " onClick={onSubmit} type='submit'>Cancel Booking</button>
                    </div>
                    
                </div>
            </div>
    </div>
  )
  }

export default CancelBooking