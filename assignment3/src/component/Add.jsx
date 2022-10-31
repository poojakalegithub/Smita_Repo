import React, { useState } from 'react'
import {Link,useNavigate} from 'react-router-dom'


function ShowRestaurantInTable(props) {   
    
    return (
        <div >
            <div className="container border p-2">
                <table class="table table-striped table-hover">
                    <thead>
                    <th scope="col">Restaurant Id</th>
                        <th scope="col">Restaurant Name</th>
                        <th scope="col">Landline No</th>
                        <th scope="col">Restaurant Address</th>
                        <th scope="col">Restaurant Information</th>
                    </thead>

                    <tbody>
                        {props.map((values) => {
                            return (
                                <tr scope="row">
                                    <td>{values.RestaurantId}</td>
                                    <td>{values.RestaurantName}</td>
                                    <td>{values.RestaurantLandlineNo}</td>
                                    <td>{values.RestaurantAddress}</td>
                                    <td>{values.RestaurantInformation}</td>
                                    <td><button className='btn btn-info' 
                                    onClick={()=>{
                                        alert("Edit Data Of Restaurant : " +values.RestaurantId)
                                    }}  
                                    type='submit'>Edit</button></td>
                                    <td><button className='btn btn-danger' 
                                    onClick={()=>{
                                        alert("Deleting Data :" +values.RestaurantId)
                                    }}  type='submit'>Delete</button></td>
                                    
                                </tr>
                            )
                        })}

                    </tbody>
                </table>
            </div>
        </div>
    )
}

const Add = (props) => {
    //input field states
    const navigate=useNavigate();
    const [RestaurantId,setRestaurantId]=useState()
    const [RestaurantName, setRestaurantName] = useState()
    const [RestaurantLandlineNo, setRestaurantLandlineNo] = useState()
    const [RestaurantAddress, setRestaurantAddress] = useState()
    const [RestaurantInformation, setRestaurantInformation] = useState()
     //main array of posts
    const [array, setArray] = useState([])
   

    
    const onChangeRestaurantId = (event) => {
        setRestaurantId(event.target.value);
    };
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
        const object = { RestaurantId,RestaurantName, RestaurantLandlineNo, RestaurantAddress, RestaurantInformation }
        setArray([...array, object])
        console.log(array)
    }
    const onLogOut = () => {
        navigate('/')
      }

    
    return (
        <div>

<nav className="navbar navbar-expand-lg navbar-light navbar-dark bg-dark ">
        <a className="navbar-brand" href="">Add Your Restaurant {localStorage.getItem('UserName')}</a>
        <button><Link to="/Add">Admin Dashboard</Link></button>
        <button onClick={onLogOut}>Log Out</button>
      </nav>
            <div class="col d-flex justify-content-center m-4">
                <div class="border border-primary p-5">
                    <h3>Add Restaurant</h3>
                    <label className="m-1 row">Restaurant Id : </label>
                    <input type='number' value={RestaurantId} onChange={onChangeRestaurantId} class="m-1 row form-control" placeholder='Enter Restaurant Id'></input>
 
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