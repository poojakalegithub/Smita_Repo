import React, { useState } from 'react'
import { useNavigate } from 'react-router-dom';

function RestaurantAdd() {
    const [restaurantName, setrestaurantName] = useState('')
    const [mobileNo, setmobileNo] = useState('')
    const [address, setaddress] = useState('')
    const [file,setFile]=useState()
    const navigate = useNavigate();

    const onChangerestaurantName = (e) => {
        setrestaurantName(e.target.value)
    };

    const onChangeMobileNo = (e) => {
        setmobileNo(e.target.value)
    };
    const onChangeAddress = (e) => {
        setaddress(e.target.value)
    };
    const onChangeFile=(e)=>{
        console.log(e)
        setFile(e.target.files[0])
        // setFile(URL.createObjectURL(e.target.files[0]))
    }

    function onSubmit() {
        localStorage.setItem('restaurantName', restaurantName)
        localStorage.setItem('mobileNo', mobileNo)
        localStorage.setItem('address', address)
        localStorage.setItem('file',file)

    }
  return (
    <div>
        <div>Add Restaurant

<div className=" col d-flex justify-content-center m-2">
    <div className="border border-success p-5">
        <h3>Restaurant Information </h3>
        <label className="m-1 row">Restaurant Name : </label>
        <input type='text' value={restaurantName} onChange={onChangerestaurantName} className="m-1 row form-control" placeholder='Enter Owner name' required></input>
        <label className="m-1 row">Landline No : </label>
        <input type='number' value={mobileNo} onChange={onChangeMobileNo} className="m-1 row form-control" placeholder='Enter Landline No' required></input>
        <label className="m-1 row">Address : </label>
        <input type='text' value={address} onChange={onChangeAddress} className="m-1 row form-control" placeholder='Enter Address' required></input>
        <label className="m-1 row">Add Images : </label>
        <input type='file' value={file} onChange={onChangeFile} className="m-1 row form-control" placeholder='Enter Address' required></input>
        <img src={file}/>
        <div className="text-center">
            <button className="row mt-2 btn btn-success row " onClick={onSubmit} type='submit'>Register</button>
        </div>

    </div>
</div>

</div>
    </div>
  )
}

export default RestaurantAdd