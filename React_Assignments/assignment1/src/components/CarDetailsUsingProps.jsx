import React, { Component } from 'react'

//Class Component
class CarDetailsUsingProps extends Component {
  render(){
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
  return(
    <div>
      <ShowCarDetails Car={car}/>
    </div>
  )
  }
}

class ShowCarDetails extends Component{
  render()
  {
    return(
      <div>
    
    <h2>Car Details</h2>
            <ul>
                <li>Model = {this.props.Car.model}</li>
                <li>Company = {this.props.Car.company}</li>
                <li>Price = {this.props.Car.price}</li>
            </ul>
            <h4>Configuration</h4>
            <ul>
                <li>Color = {this.props.Car.configuration.color}</li>
                <li>Fuel = {this.props.Car.configuration.fuel}</li>
                <li>Cylinder = {this.props.Car.configuration.cylinder}</li>
                <li>FuelTankCapacity = {this.props.Car.configuration.fuelTankCapacity}</li>
            </ul>
            <h4>Mileage</h4>
            <ul>
                <li>City ={this.props.Car.configuration.mileage.city}</li>
                <li>Highway ={this.props.Car.configuration.mileage.highway}</li>
            </ul>
            <h4>Features</h4>
            <ul>
                {/* Accessing Array Elements Using Index */}
                {/* <li>{this.props.Car.features[0]}</li>
                <li>{this.props.Car.features[1]}</li>
                <li>{this.props.Car.features[2]}</li>
                <li>{this.props.Car.features[3]}</li> */}

                {/* Accessing Array Elements Using map Method */}
                {this.props.Car.features.map((carFeatures) => {
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
}

export default CarDetailsUsingProps