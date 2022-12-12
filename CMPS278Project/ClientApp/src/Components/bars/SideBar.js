import React from "react";
import "../styles/sidebar.css";
import logo from "../../img/prime-logo.png";
import { FaUser, FaSignOutAlt,} from "react-icons/fa";
import { IoRestaurant } from "react-icons/io5";
import { MdDashboard } from "react-icons/md";
import { Link } from 'react-router-dom';



const Icon = ({ icon }) => (
  <li>
    <p href="">{icon}</p>
  </li>
);


function SideBar() {
  return (
    <header>
      <img src={logo} alt="logo" />
      
      <ul className="top-menu">
        <Link to="/"><Icon icon={<MdDashboard title="Menu"/>} /></Link>
        <Link to="/profile"><Icon icon={<FaUser title="Your Profile"/>} /></Link>
        {/* <Link to="/chat"><Icon icon={<IoChatbubbleEllipsesSharp title="Chat with sales rep"/>} /></Link> */}
        <Link to="/comingsoon"><Icon icon={<IoRestaurant title="About us"/>} /></Link>
        {/* <Link to="/help"><Icon icon={<IoIosHelpCircle title="FAQs"/>} /></Link> */}
        {/* <Icon icon={<FaCog title="Settings"/>} /> */}
      </ul>

      <ul className="bottom-menu">
        <Icon icon={<FaSignOutAlt />} />
      </ul>
      
    </header>
  );
}


export default SideBar;
