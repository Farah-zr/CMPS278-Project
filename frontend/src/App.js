import "./App.css";
import SideBar from "./Components/bars/SideBar";
import Container from "./Components/Container";
import AfricanFood from "./Components/menu/AfricanFood";
import ChineseFood from "./Components/menu/ChineseFood";
import ItalianFood from "./Components/menu/ItalianFood";
import DesertFood from "./Components/menu/DesertFood";
import Help from "./Components/FAQ/Help";
import Profile from "./Components/user/Profile";
import ComingSoon from "./Components/ComingSoon";
import Chat from "./Components/Chat";
import Modal from "./Components/Modal";
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Checkout from "./Components/checkout/Checkout";

function App() {
  return (
    <>
      <div className="App">

        <Router>
          <SideBar />
          {/* <Container /> */}
          <Routes>
            <Route path="/" element={<Container />} />
            <Route path="/african" element={<AfricanFood />} />
            <Route path="/chinese" element={<ChineseFood />} />
            <Route path="/italian" element={<ItalianFood />} />
            <Route path="/desert" element={<DesertFood />} />
            <Route path="/checkout" element={<Checkout />} />
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
