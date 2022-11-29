import React from "react";
import "./styles/container.css";
import TopSect from "./bars/TopSect";
import FoodCont from "./menu/FoodCont";


function Container() {
  return (
    <div className="container">
      <TopSect />
      <FoodCont />
    </div>
  );
}

export default Container;
