import React, { useState } from 'react';

function Counter() {

    //state of count
    const [count, setCount] = useState(0);

    return (
        <div>
            <div className='bg-black col d-flex justify-content-center'>
                <div className='border border-primary p-5 rounded-top'>
                    <button className="btn btn-success m-2" onClick={() => setCount(count + 1)}>
                        Increment
                    </button>
                    <label className="btn btn-info m-2"> {count} </label>
                    <button className="btn btn-danger m-2" onClick={() => setCount(count - 1)}>
                        Decrement
                    </button>
                </div>
            </div>
        </div>
    );
}

export default Counter