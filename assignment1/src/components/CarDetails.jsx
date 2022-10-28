import React from 'react'

//Functional component
function CarDetails() {

    //Given data
    const car = {
        model: 'i20',
        company: 'Hyundai',
        price: 20,
        configuration: {
            color: 'gray',
            fuel: 'petrol',
            cylinder: 4,
            fuelTankCapacity: 37,
            mileage: {
                city: 14,
                highway: 20,
            },
        },
        features: ['touch screen', 'bluetooth', 'alloy wheels', 'powersteering']
    }
    return (
        //Rendering car details using list
        <div>
            <h2>Car Details</h2>
            <ul>
                <li>Model = {car.model}</li>
                <li>Company = {car.company}</li>
                <li>Price = {car.price}</li>
            </ul>
            <h4>Configuration</h4>
            <ul>
                <li>Color = {car.configuration.color}</li>
                <li>Fuel = {car.configuration.fuel}</li>
                <li>Cylinder = {car.configuration.cylinder}</li>
                <li>FuelTankCapacity = {car.configuration.fuelTankCapacity}</li>
            </ul>
            <h4>Mileage</h4>
            <ul>
                <li>City ={car.configuration.mileage.city}</li>
                <li>Highway ={car.configuration.mileage.highway}</li>
            </ul>
            <h4>Features</h4>
            <ul>
                {/* Accessing Array Elements Using Index */}
                {/* <li>{car.features[0]}</li>
                <li>{car.features[1]}</li>
                <li>{car.features[2]}</li>
                <li>{car.features[3]}</li> */}

                {/* Accessing Array Elements Using map Method */}
                {car.features.map((carFeatures) => {
                    return (
                        <li>
                            {carFeatures}
                        </li>
                    )
                })}
            </ul>
        </div>
    )
}

export default CarDetails