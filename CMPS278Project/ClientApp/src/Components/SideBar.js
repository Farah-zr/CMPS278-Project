import React from "react";
import { FaSignOutAlt, FaShoppingCart, FaCookieBite } from "react-icons/fa";
import { MdPerson } from "react-icons/md";
import { IoRestaurant, IoStorefront } from "react-icons/io5";
import { Link, useLocation } from "react-router-dom";

const Icon = ({ icon, styles, isActive }) => (
  <p
    className={
      isActive
        ? "text-[25px] text-center text-peach"
        : "text-[20px] text-center hover:text-[25px] text-melon"
    }
  >
    {icon}
  </p>
);

function Sidebar() {
  const location = useLocation();

  return (
    <div className="w-[60px] h-full flex flex-col bg-background items-center py-4 gap-4 justify-between shadow-[0_0_7px_rgba(0,0,0,0.3)]">
      <div className="flex flex-col gap-6 items-center text-white">
        <div className="font-bold-italic flex text-primary h-[50px]">
          <Link to="/" className="text-[28px] text-center text-primary">
            <FaCookieBite />
          </Link>
        </div>

        <Link to="/">
          <Icon
            icon={<IoRestaurant title="Menu" />}
            isActive={location.pathname === "/"}
          />
        </Link>
        <Link to="/cart">
          <Icon
            icon={<FaShoppingCart title="Cart" />}
            isActive={location.pathname === "/cart"}
          />
        </Link>
        {/* <Link to="/search">
          <Icon
            icon={<FaSearch title="Search" />}
            isActive={location.pathname === "/search"}
          />
        </Link> */}
        <Link to="/about-us">
          <Icon
            icon={<IoStorefront title="About us" />}
            isActive={location.pathname === "/about-us"}
          />
        </Link>

        <Link to="/profile">
          <Icon
            icon={<MdPerson title="profile" />}
            isActive={location.pathname === "/profile"}
          />
        </Link>
      </div>

      <div>
        <Link to="/login" className="text-white">
          <Icon icon={<FaSignOutAlt />} />
        </Link>
      </div>
    </div>
  );
}

export default Sidebar;
