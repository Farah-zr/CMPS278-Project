import React from "react";
import "./styles/container.css";
import TopSect from "./bars/TopSect";
import FoodContainer from "./menu/FoodContainer";
import SideBar from "./bars/SideBar";


function Container() {
  return (
    
    <><SideBar /><div className="container">
      <TopSect />
      <FoodContainer />
    </div></>
  );
}

export default Container;
