import React from "react";
import "../assets/styles/container.css";
import Sidebar from "../Components/Sidebar";
import Header from "../Components/Header";
import { Outlet } from "react-router-dom";

function AppLayout() {
  return (
    <>
      <div className="flex w-full">
        <Sidebar />
        <div className="w-full px-7 py-5">
          <div className="max-w-[1116px] my-0 mx-auto">
            <Header />
            <div className="h-[calc(100%-60px)]">
              <Outlet />
            </div>
          </div>
        </div>
      </div>
    </>
  );
}

export default AppLayout;
