import React from 'react'
import { useState } from 'react';

const Star = () => {

    //Importing images using require method
    const fullStarSrc = require('./Images/starimg.png');
    const emptyStarSrc = require('./Images/emptystar.png');
    
    //setting state for rating
    const [rating, setRating] = useState(0);
    const onsetRating = (e) => {
        setRating(e.target.value);
    }

    //This method will be called after onClick 
    const onSubmit = () => {
        if (rating <= 0 || rating > 5) {
            alert('Invalid rating! Please Enter Rating between 1 - 5');
            return;
        }
        
        let i;
        //to print Stars based on ratings given by user
        for (i = 1; i <= rating; i++) {
            // console.log("Given Rating: " + i);
            document.getElementById(i).setAttribute("src", fullStarSrc);
            document.getElementById(i).setAttribute('width',50);
        }

        //Decrementing rating
        for(; i<=5;i++){
            // console.log("Decrementing Rating: " + i);
            document.getElementById(i).setAttribute("src", emptyStarSrc);
            document.getElementById(i).setAttribute('width',50);

        }
    }

    return (
        <div>
            <div className="bg-black col d-flex justify-content-center m-4 ">
                {/* to take ratings from user */}
                <div className="border border-primary p-5 rounded-top">
                    <h3>How would You Rate Us? </h3>
                    <input type='number' id='rating' onChange={onsetRating} className="m-1 row form-control" placeholder='Rate us between 1-5' required></input>
                    <div className="text-center">
                        <button onClick={onSubmit} className="row mt-2 btn btn-success row " type='submit'>Submit</button>
                    </div>
                
                {/* to display stars */}
                <div id="rating0 col">
                    <img class="star" id="1" width="50" src=
                        {emptyStarSrc} alt='star'/>
                    <img class="star" id="2" width="50" src=
                        {emptyStarSrc} alt='star'/>
                    <img class="star" id="3" width="50" src=
                        {emptyStarSrc} alt='star' />
                    <img class="star" id="4" width="50" src=
                        {emptyStarSrc} alt='star'/>
                    <img class="star" id="5" width="50" src=
                        {emptyStarSrc} alt='star'/>
                </div>
                </div>
          </div>         
        </div>
    )
}

export default Star;
