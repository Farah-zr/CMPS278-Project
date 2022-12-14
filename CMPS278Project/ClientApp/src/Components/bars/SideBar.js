import React from "react";
import "../styles/sidebar.css";
import logo from "../../img/logo-removebg-preview.png";
import { FaUser, FaSignOutAlt, FaShoppingCart } from "react-icons/fa";
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
      <img src={logo} alt="logo" width="70px" height="100px" />
      
      <ul className="top-menu">
        <Link to="/menu"><Icon icon={<MdDashboard title="Menu"/>} /></Link>
        <Link to="/cart"><Icon icon={<FaShoppingCart title="Cart"/>} /></Link>
        <Link to="/aboutus"><Icon icon={<IoRestaurant title="About us"/>} /></Link>
        {/* <Link to="/profile"><Icon icon={<FaUser title="Profile"/>} /></Link> */}
      </ul>

      <ul className="bottom-menu">
      <Link to="/"><Icon icon={<FaSignOutAlt />} /></Link>
      </ul>
      
    </header>
  );
}

export default SideBar;
