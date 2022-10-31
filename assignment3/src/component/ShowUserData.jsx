import React from 'react'
import UsersData from './UsersData.json';

function ShowUserData() {
  return (
    <div>

<div><br/>
          <h4><i>Available Users on Our Website</i></h4>
          <hr/>
          <br/>
          <table class="container table table-striped table-hover ">
            <thead>
              <th>ID</th>
              <th>Name</th>
              <th>Email</th>
              <th>Mobile</th>
              <th>Address</th>
            </thead>
            
            <tbody>
              {UsersData.map((values) => {
                return (
                  <tr>
                    <td>{values.UserId}</td>
                    <td>{values.UserName}</td>
                    <td>{values.UserEmail}</td>
                    <td>{values.Usermobile}</td>
                    <td>{values.Useraddress}</td>
                  </tr>
                )
                
              })}
              <td>{localStorage.getItem('UserId')}</td>
            <td>{localStorage.getItem('UserName')}</td>
            <td>{localStorage.getItem('UserEmail')}</td>
            <td>{localStorage.getItem('Usermobile')}</td>
            <td>{localStorage.getItem('Useraddress')}</td>
            </tbody>
            
          </table>

        </div>
    </div>
  )
}

export default ShowUserData