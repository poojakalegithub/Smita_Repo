import React from 'react'

function Registration() {

    const onSubmit = (e) => {

        //Getting User input value by Id
        const firstName=document.getElementById("firstname").value;
        const lastName=document.getElementById("lastname").value;
        const dob=document.getElementById("DOB").value;
        const userId = document.getElementById("userId").value;
        const pwd = document.getElementById("pwd").value;
        
        //Printing value on console
        console.log('First Name :',firstName);
        console.log('Last Name :',lastName);
        console.log('Date Of Birth :',dob)
        console.log('User Id :', userId);
        console.log('Password :', pwd);
        alert("Please,Check Data On Console!");
    }
    return (
        <div>
            {/* Registration Form */}
            <div className="bg-black col d-flex justify-content-center m-4 ">
                <div className="border border-primary p-5 rounded-top">
                    <h2>Registration </h2>
                    <label className="m-1 row">First Name : </label>
                    <input type='text' id='firstname' className="m-1 row form-control" placeholder='First Name' required></input>
                    <label className="m-1 row">Last Name : </label>
                    <input type='text' id='lastname' className="m-1 row form-control" placeholder='Last Name' required></input>
                    <label className="m-1 row">Date of Birth: </label>
                    <input type='Date' id='DOB' className="m-1 row form-control" placeholder='Date Of Birth' required></input>
                    <label className="m-1 row">Email Id : </label>
                    <input type='email' id='userId' className="m-1 row form-control" placeholder='Email-ID' required></input>
                    <label className="m-1 row">Password : </label>
                    <input type='password' id='pwd' className="m-1 row form-control" placeholder='Password' required></input>
                    <div className="text-center">
                        <button onClick={onSubmit} className="row mt-2 btn btn-success row " type='submit'>Register</button>
                    </div>
                </div>
            </div>

        </div>
    )
}

export default Registration