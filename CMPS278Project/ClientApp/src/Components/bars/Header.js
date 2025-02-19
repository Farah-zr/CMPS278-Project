import { Typography } from "@mui/material";
import React from "react";
import { IoMdSearch } from "react-icons/io";
import { FaCookieBite } from "react-icons/fa";

function Header() {
  return (
    <div className="flex justify-between items-center ">
      <div>
        <div className="flex items-center gap-1 text-primary">
          <span className="text-primary text-[24px] font-bold-italic">
            Sweet Bites
          </span>
          <FaCookieBite />
        </div>
        <div>
          <span className="text-white text-[18px] font-bold-italic">
            we deliver joy and happiness in a box to your doorstep
          </span>
        </div>
      </div>

      <div className="flex items-center align-middle relative w-[300px] h-[38px]">
        <input
          type="text"
          placeholder="Search..."
          className="rounded-[8px] py-[6px] pl-[10px] pr-[22px] w-full h-full bg-white text-[14px] border-2 border-secondary focus:border-peach focus:ring-[1px] focus:ring-peach focus-within:outline-none focus-visible:outline-none placeholder:text-placeholder"
        />
        <span className="absolute end-0 inset-y-0 flex items-center justify-center px-2 z-10 text-placeholder">
          <IoMdSearch />
        </span>
      </div>
    </div>
  );
}

export default Header;
