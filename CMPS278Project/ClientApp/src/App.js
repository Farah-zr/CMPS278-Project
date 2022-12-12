import "./App.css";
import SideBar from "./Components/bars/SideBar";
import Container from "./Components/Container";
import CakePopsMenu from "./Components/menu/CakePopsMenu";
import BrowniesMenu from "./Components/menu/BrowniesMenu";
import CinnamonRollsMenu from "./Components/menu/CinnamonRollsMenu";
import CookiesMenu from "./Components/menu/CookiesMenu";
import Help from "./Components/FAQ/Help";
import Profile from "./Components/user/Profile";
import ComingSoon from "./Components/ComingSoon";
import Chat from "./Components/Chat";
import Modal from "./Components/Modal";
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Checkout from "./Components/checkout/Checkout";
import ThankYou from "./Components/checkout/thankYou";

function App() {
  return (
    <>
      <div className="App">

        <Router>
          <SideBar />
          {/* <Container /> */}
          <Routes>
            <Route path="/" element={<Container />} />
            <Route path="/cakePops" element={<CakePopsMenu />} />
            <Route path="/brownies" element={<BrowniesMenu />} />
            <Route path="/cinnamonRolls" element={<CinnamonRollsMenu />} />
            <Route path="/cookies" element={<CookiesMenu />} />
            <Route path="/checkout" element={<Checkout />} />
            <Route path="/thanku" element={<ThankYou />} />
            <Route path="/help" element={<Help />} />
            <Route path="/profile" element={<Profile />} />
            <Route path="/comingsoon" element={<ComingSoon />} />
            <Route path="/chat" element={<Chat />} />
            <Route path="/modal" element={<Modal />} />
            <Route path="/update/:id" element={<Modal />} />
          </Routes>
        </Router>
      </div>
    </>
  );
}

export default App;