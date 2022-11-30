import React from "react";
import "./styles/container.css";
import TopSect from "./bars/TopSect";
import FoodContainer from "./menu/FoodContainer";


function Container() {
  return (
    <div className="container">
      <TopSect />
      <FoodContainer />
    </div>
  );
}

export default Container;
