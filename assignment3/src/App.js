
import './App.css';

import Login from './component/Login';

import Registration from './component/Registration';
import { Routes,Route, Link } from 'react-router-dom';
import Navbar from './component/Navbar';
import AdminLogin from './component/AdminLogin';
import OwnerRegistration from './component/OwnerRegistration';
import Dashboard from './component/Dashboard';
import RestaurantAdd from './component/RestaurantAdd';
import Add from './component/Add';
import ShowUserData from './component/ShowUserData';
import UserPanel from './component/UserPanel/UserPanel';
import Rooms from './component/UserPanel/Rooms';

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
      <Route path='/Add' element={<Add/>}></Route>
      <Route path='/ShowUserData' element={<ShowUserData/>}></Route>
      <Route path='/UserPanel' element={<UserPanel/>}></Route>
      <Route path='/Rooms' element={<Rooms/>}></Route>
     
      </Routes>
      {/* <AdminLogin/> */}
     
     
    </div>
  );
}

export default App;
