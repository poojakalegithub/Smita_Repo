import React, { useEffect } from 'react'
import { useState } from 'react'
import { Link, useNavigate } from 'react-router-dom'
import CancelBooking from './CancelBooking'
import UserPanelNavbar from './UserPanelNavbar'

const BookedHotels = () => {
    const navigate = useNavigate()
    const [bookigData, getBookingdata] = useState([])

    //called when hotelbook state will get updated
    useEffect(() => {
        const hotelbook = localStorage.getItem('hotelbook')
        getBookingdata(JSON.parse(hotelbook))
    }, [])

    //function to delete the booking data.
    const handleDelete = (val) => {
        const res = window.confirm("Are You Sure Want To Delete..?");
        if (res) {
            bookigData.forEach((bookigData) => {
                if (bookigData.bookingId == val) {
                    bookigData.status = 0
                }
            }
            );
            localStorage.setItem("hotelbook", JSON.stringify(bookigData));
        }
        navigate('/CancelBooking')
    };
    return (
        <div>
            <UserPanelNavbar />
            <h3>Booked Hotels</h3>
            <div className="container border p-3">
                <table class="table table-secondary">
                    <thead>
                        <th scope="col">BookingId</th>
                        <th scope="col">Hotel Name</th>
                        <th scope="col">Rooms to book</th>
                    </thead>
                    <tbody>
                        {bookigData.map((values) => {
                            {
                                if (values.status === 1) {
                                    return (

                                        <tr scope="row">
                                            <td>{values.bookingId}</td>
                                            <td>{values.username}</td>
                                            <td>{values.room}</td>
                                            <button onClick={() => handleDelete(values.bookingId)} className="btn btn-dark ">Cancel Booking</button>
                                        </tr>
                                    )
                                }
                            }
                        })}
                    </tbody>
                </table>
            </div>
        </div>
    )
}
export default BookedHotels
