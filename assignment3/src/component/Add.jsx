import React, { useState } from 'react'
import ShowRestaurantInTable from './RestaurantList'

const Add = (props) => {
    //input field states
    const [RestaurantName, setRestaurantName] = useState()
    const [RestaurantLandlineNo, setRestaurantLandlineNo] = useState()
    const [RestaurantAddress, setRestaurantAddress] = useState()
    const [RestaurantInformation, setRestaurantInformation] = useState()
     //main array of posts
    const [array, setArray] = useState([])
   
    //target value of RestaurantName
    const onChangeRestaurantName = (event) => {
        setRestaurantName(event.target.value);
    };
     //target value of RestaurantLandlineNo
    const onChangeRestaurantLandlineNo = (event) => {
        setRestaurantLandlineNo(event.target.value);
    };
     //target value of RestaurantAddress
    const onChangeRestaurantAddress = (event) => {
        setRestaurantAddress(event.target.value);
    };
     //target value of RestaurantInformation
    const onChangeRestaurantInformation = (event) => {
        setRestaurantInformation(event.target.value);
    };

    //function to call after onclick event on button
    function onSubmit() {
        const object = { RestaurantName, RestaurantLandlineNo, RestaurantAddress, RestaurantInformation }
        setArray([...array, object])
    }
    return (
        <div>
            <div class="col d-flex justify-content-center m-4">
                <div class="border border-primary p-5">
                    <h3>Add Restaurant</h3>
                    <label className="m-1 row">Restaurant Name : </label>
                    <input type='text' value={RestaurantName} onChange={onChangeRestaurantName} class="m-1 row form-control" placeholder='Enter Restaurant name'></input>
                    <label className="m-1 row">Landline No : </label>
                    <input type='number' value={RestaurantLandlineNo} onChange={onChangeRestaurantLandlineNo} class="m-1 row form-control" placeholder='Enter LandlineNo'></input>
                    <label className="m-1 row">Restaurant Address :</label>
                    <input type='text' value={RestaurantAddress} onChange={onChangeRestaurantAddress} class="m-1 row form-control" placeholder='Enter Address  '></input>
                    <label className="m-1 row">Information About Restaurant :</label>
                    <textarea cols="30" value={RestaurantInformation} onChange={onChangeRestaurantInformation} rows="4 " class="m-1 row form-control" placeholder='loreum ipsum....'></textarea>
                    <div className="text-center">
                        <button class="row mt-2 btn btn-success row " onClick={onSubmit} type='submit'>Submit</button>
                    </div>
                </div>
            </div>
            {/* calling function to render table */}
            {ShowRestaurantInTable(array)}
        </div>
    )
}
export default Add