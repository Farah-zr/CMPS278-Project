import "./App.css";
import Profile from "./Components/user/Profile";
import AboutUs from "./Components/AboutUs";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import { useDispatch, useSelector } from "react-redux";
import { useEffect } from "react";
import { fetchMenuItemsThunk } from "./Store/MenuSlice";
import AppLayout from "./Layouts/AppLayout";
import Cart from "./Components/cart/Cart";
import FoodContainer from "./Components/FoodContainer";

function App() {
  const dispatch = useDispatch();
  const { items, status, error } = useSelector((state) => state.menu);

  useEffect(() => {
    if (status === "idle") {
      dispatch(fetchMenuItemsThunk());
    }
  }, [status, dispatch]);

  if (status === "loading") console.log("Loading...");
  if (status === "fail") console.log("error:", error);
  else if (status === "success") console.log("items:", items);

  return (
    <>
      <div className="App">
        <Router>
          <Routes>
            <Route path="/" element={<AppLayout />}>
              <Route index element={<FoodContainer />} />
              <Route path="/about-us" element={<AboutUs />} />
              <Route path="/profile" element={<Profile />} />
              <Route path="/cart" element={<Cart />} />
            </Route>
          </Routes>
        </Router>

        {/* <Route path="/checkout" element={<Checkout />} /> */}
        {/* <Route path="/" element={<Login />} /> */}
        {/* <Route path="/login" element={<Login />} /> */}
        {/* <Route path="/register" element={<Signup />} />
            <Route path="/thanku" element={<ThankYou />} /> */}
        {/* <Route path="/search" element={<Search />} /> */}
      </div>
    </>
  );
}

export default App;
