import React from "react";
import "../assets/styles/container.css";
import Header from "./bars/Header";
import FoodContainer from "./menu/FoodContainer";
import SideBar from "./SideBar";

function Container() {
  return (
    <>
      <div className="flex">
        <SideBar />
        <div className="w-full px-7 py-5">
          <div className="max-w-[1200px] my-0 mx-auto">
            <Header />
            <FoodContainer />
          </div>
        </div>
      </div>
    </>
  );
}

export default Container;
