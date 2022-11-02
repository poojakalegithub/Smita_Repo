import React from 'react'
import { useState } from 'react'
import { useNavigate } from 'react-router-dom'

function OwnerRegistration() {
    //Declaring state variables
    const [RestaurantId, setRestaurantId] = useState('')
    const [ownerName, setownerName] = useState('')
    const [emailId, setemailId] = useState('')
    const [mobileNo, setmobileNo] = useState('')
    const [address, setaddress] = useState('')
    const [password, setPassword] = useState('')

    const navigate = useNavigate();

    //setting current state value to state variables
    const onChangeRestaurantId = (e) => {
        setRestaurantId(e.target.value);
    };
    const onChangeOwnerName = (e) => {
        setownerName(e.target.value)
    };
    const onChangeeMailId = (e) => {
        setemailId(e.target.value)
    };
    const onChangeMobileNo = (e) => {
        setmobileNo(e.target.value)
    };
    const onChangeAddress = (e) => {
        setaddress(e.target.value)
    };
    const onChangePassword = (e) => {
        setPassword(e.target.value)
    };

    //Function to call on click of register button then it will switch to Admin login page
    function onSubmit() {
        localStorage.setItem('UserId', RestaurantId)
        localStorage.setItem('UserName', ownerName)
        localStorage.setItem('UserEmail', emailId)
        localStorage.setItem('Usermobile', mobileNo)
        localStorage.setItem('Useraddress', address)
        localStorage.setItem('Userpassword', password)
        window.alert("Registration Successful! Please Login")
        navigate('/AdminLogin')
    }

    return (
        <div>
            <div className=" col d-flex justify-content-center m-2">
                <div className="border border-success p-5">
                    <h3>Admin Registration </h3>
                    <label className="m-1 row">Restaurant Id : </label>
                    <input type='number' value={RestaurantId} onChange={onChangeRestaurantId} className="m-1 row form-control" placeholder='Enter Restaurant-ID' required></input>
                    <label className="m-1 row">Owner Name : </label>
                    <input type='text' value={ownerName} onChange={onChangeOwnerName} className="m-1 row form-control" placeholder='Enter Owner name' required></input>
                    <label className="m-1 row">Mail Id :</label>
                    <input type='mail' value={emailId} onChange={onChangeeMailId} className="m-1 row form-control" placeholder='Enter Mail Id  ' required></input>
                    <label className="m-1 row">Mobile No : </label>
                    <input type='number' value={mobileNo} onChange={onChangeMobileNo} className="m-1 row form-control" placeholder='Enter Mobile No' required></input>
                    <label className="m-1 row">Address : </label>
                    <input type='text' value={address} onChange={onChangeAddress} className="m-1 row form-control" placeholder='Enter Address' required></input>
                    <label className="m-1 row">Password :</label>
                    <input type='password' value={password} onChange={onChangePassword} className="m-1 row form-control" placeholder='Enter Password  ' required></input>
                    <div className="text-center">
                        <button className="row mt-2 btn btn-success row " onClick={onSubmit} type='submit'>Register</button>
                    </div>
                </div>
            </div>
        </div>
    )
}
export default OwnerRegistration