
import './App.css';
import AddRestaurant from './component/AddRestaurant';
import HomePage from './component/HomePage';
import Login from './component/Login';

import Registration from './component/Registration';
import { Routes,Route, Link } from 'react-router-dom';
import Navbar from './component/Navbar';
import AdminLogin from './component/AdminLogin';

function App() {
  return (
    <div>
      <Routes>
      <Route path='/' element={<Navbar/>}></Route>
      <Route path='/login' element={<Login/>}></Route>
      <Route path='/user-registration' element={<Registration/>}></Route> 
      <Route path='/addrestaurent' element={<AddRestaurant/>}></Route>
      <Route path='/adminLogin' element={<AdminLogin/>}></Route>
      </Routes>
      {/* <AdminLogin/> */}
     
     
    </div>
  );
}

export default App;
