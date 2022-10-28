
import './App.css';
import AddRestaurant from './component/OwnerRegistration';
import HomePage from './component/HomePage';
import Login from './component/Login';

import Registration from './component/Registration';
import { Routes,Route, Link } from 'react-router-dom';
import Navbar from './component/Navbar';
import AdminLogin from './component/AdminLogin';
import OwnerRegistration from './component/OwnerRegistration';
import Dashboard from './component/Dashboard';
import RestaurantAdd from './component/RestaurantAdd';

function App() {
  return (
    <div>
      
      <Routes>
      <Route path='/' element={<Navbar/>}></Route>
      <Route path='/login' element={<Login/>}></Route>
      <Route path='/user-registration' element={<Registration/>}></Route> 
      <Route path='/OwnerRegistration' element={<OwnerRegistration/>}></Route>
      <Route path='/adminLogin' element={<AdminLogin/>}></Route>
      <Route path='/Dashboard' element={<Dashboard/>}></Route>
      <Route path='/RestaurantAdd' element={<RestaurantAdd/>}></Route>
      </Routes>
      {/* <AdminLogin/> */}
     
     
    </div>
  );
}

export default App;
