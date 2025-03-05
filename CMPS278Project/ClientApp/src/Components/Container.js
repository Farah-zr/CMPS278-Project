import React from "react";
import "../assets/styles/container.css";
import Header from "./Header";
import FoodContainer from "./menu/FoodContainer";
import Sidebar from "./Sidebar";

function Container() {
  return (
    <>
      <div className="flex w-full">
        <Sidebar />
        <div className="w-full px-7 py-5">
          <div className="max-w-[1116px] my-0 mx-auto">
            <Header />
            <div className="h-[calc(100%-60px)]">
              <FoodContainer />
            </div>
          </div>
        </div>
      </div>
    </>
  );
}

export default Container;
