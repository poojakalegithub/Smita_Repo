import React, { useState } from 'react'

function ShowPostsInTable(props) {
    return (
        <div >
            <div className="container border p-2">
                <table class="table table-striped table-hover">
                    <thead>
                        <th scope="col">USER ID</th>
                        <th scope="col">ID</th>
                        <th scope="col">TITLE</th>
                        <th scope="col">BODY</th>
                    </thead>

                    <tbody>
                        {props.map((values) => {
                            return (
                                <tr scope="row">
                                    <td>{values.userId}</td>
                                    <td>{values.id}</td>
                                    <td>{values.title}</td>
                                    <td>{values.body}</td>
                                </tr>
                            )
                        })}

                    </tbody>
                </table>
            </div>
        </div>
    )
}


const Posts = (props) => {
    //input field states
    const [userId, setUserId] = useState()
    const [id, setId] = useState()
    const [title, setTitle] = useState()
    const [body, setBody] = useState()

     //main array of posts
    const [array, setArray] = useState([''])

    //target value of userId
    const onChangeUserId = (event) => {
        setUserId(event.target.value);
    };
     //target value of Id
    const onChangeId = (event) => {
        setId(event.target.value);
    };
     //target value of Title
    const onChangeTitle = (event) => {
        setTitle(event.target.value);
    };
     //target value of Body
    const onChangeBody = (event) => {
        setBody(event.target.value);
    };

    //function to call after onclick event on button
    function onSubmit() {
        const object = { userId, id, title, body }
        setArray([...array, object])
        setUserId("")

    }
    return (
        <div>
            <div class="bg-black col d-flex justify-content-center m-2">
                <div class="border border-primary p-5">
                    <h3>Create New Post</h3>
                    <label className="m-1 row">User Id : </label>
                    <input type='number' value={userId} onChange={onChangeUserId} class="m-1 row form-control" placeholder='Enter User-ID'></input>
                    <label className="m-1 row">Id : </label>
                    <input type='number' value={id} onChange={onChangeId} class="m-1 row form-control" placeholder='Enter ID'></input>
                    <label className="m-1 row">Title :</label>
                    <input type='text' value={title} onChange={onChangeTitle} class="m-1 row form-control" placeholder='Enter Title  '></input>
                    <label className="m-1 row">Description :</label>
                    <textarea cols="30" value={body} onChange={onChangeBody} rows="4 " class="m-1 row form-control" placeholder='loreum ipsum....'></textarea>
                    <div className="text-center">
                        <button class="row mt-2 btn btn-success row " onClick={onSubmit} type='submit'>Submit</button>
                    </div>
                </div>
            </div>
            {/* calling function to render table */}
            {ShowPostsInTable(array)}
        </div>
    )
}
export default Posts