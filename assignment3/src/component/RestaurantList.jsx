import React from 'react'


export default function ShowRestaurantInTable(props) {   
    
    return (
        <div >
            <div className="container border p-2">
                <table class="table table-striped table-hover">
                    <thead>
                        <th scope="col">Restaurant Name</th>
                        <th scope="col">Landline No</th>
                        <th scope="col">Restaurant Address</th>
                        <th scope="col">Restaurant Information</th>
                    </thead>

                    <tbody>
                        {props.map((values) => {
                            return (
                                <tr scope="row">
                                    <td>{values.RestaurantName}</td>
                                    <td>{values.RestaurantLandlineNo}</td>
                                    <td>{values.RestaurantAddress}</td>
                                    <td>{values.RestaurantInformation}</td>
                                    <td><button className='btn btn-info'  type='submit'>Edit</button></td>
                                    <td><button className='btn btn-danger'  type='submit'>Delete</button></td>
                                    
                                </tr>
                            )
                        })}

                    </tbody>
                </table>
            </div>
        </div>
    )
}