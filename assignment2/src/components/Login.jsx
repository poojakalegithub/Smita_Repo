import React from 'react'

function Login() {

    const onSubmit = (e) => {
        //Getting User input value by Id
        const userId = document.getElementById("userId").value;
        const pwd = document.getElementById("pwd").value;

        //Printing value on console
        console.log('User Id :', userId);
        console.log('Password :', pwd);
        alert("Please, Check Data On Console!");
    }
    return (
        <div>
            {/* Login Form */}
            <div class="bg-black col d-flex justify-content-center m-4 ">
                <div class="border border-primary p-5 rounded-top">
                    <h2>Login</h2>
                    <label className="m-1 row">Email Id : </label>
                    <input type='email' id='userId' class="m-1 row form-control" placeholder='Enter Email-ID' required></input>
                    <label className="m-1 row">Password : </label>
                    <input type='password' id='pwd' class="m-1 row form-control" placeholder='Enter Password' required></input>
                    <div className="text-center">
                        <button onClick={onSubmit} class="row mt-2 btn btn-success row " type='submit' >Login</button>
                    </div>
                </div>
            </div>

        </div>
    )
}

export default Login