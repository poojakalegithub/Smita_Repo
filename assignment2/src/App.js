import './App.css';
import Counter from './components/Counter';
import Login from './components/Login';
import Registration from './components/Registration';
import Star from './components/star';

function App() {
  return (
    <div>
      <h1 className='text-center'>Assignment 2</h1>
      <Login/> 
      <Registration/>
      <Counter/>
      <Star/>
    </div>
  );
}

export default App;