import CarDetails from "./components/CarDetails";
import CarDetailsUsingProps from "./components/CarDetailsUsingProps";
import ShowPosts from "./components/ShowPosts";
import Posts from "./components/posts";

function App() {
  return (
    <div>
      {/* Q1-To display Car Details without using props */}
      <CarDetails/>
      {/* Q2-To Display Car Details Using props */}
      <CarDetailsUsingProps/>
      {/* Q3-To Render Post details in Table and Unordered List Format */}
      <ShowPosts/>
      {/* Q4-To Create separate componentt named post which will accept userid,id,title,body as props. */}
      <Posts/>
    </div>
  );
}

export default App;
