import "./App.css";
import Container from "./Components/Container";
import Profile from "./Components/user/Profile";
import AboutUs from "./Components/AboutUs";
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Checkout from "./Components/checkout/Checkout";
import ThankYou from "./Components/checkout/thankYou";
import Cart from "./Components/cart/Cart";
import Login from "./Components/Login/Login";
import Signup from "./Components/Signup/Signup";
import Search from "./Components/search/search";

function App() {
  return (
    <>
      <div className="App">

        <Router>
          {/* <SideBar /> */}
          {/* <Container /> */}
          <Routes>
            <Route path="/menu" element={<Container />} />\
            <Route path="/checkout" element={<Checkout />} />
            <Route path="/cart" element={<Cart />} />
            <Route path="/" element={<Login />} />
            <Route path="/register" element={<Signup />} />
            <Route path="/thanku" element={<ThankYou />} />
            <Route path="/profile" element={<Profile />} />
            <Route path="/aboutus" element={<AboutUs />} />
            <Route path="/search" element={<Search />} />
          </Routes>
        </Router>
      </div>
    </>
  );
}

export default App;