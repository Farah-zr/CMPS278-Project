import { Typography } from "@mui/material";
import React from "react";
import { FaSearch } from "react-icons/fa";
import CookieIcon from '@mui/icons-material/Cookie';

function TopSect() {

  return (
    <div className="top-section">
      <div>
        <div style={{ display: 'flex' }}>
          <Typography variant="h5" sx={{ color: '#eebbc3', mx:1 }}>Better From Scratch</Typography>
          <CookieIcon sx={{ color: '#eebbc3', mt:0.5 }} />
        </div>
        <div>
        <Typography variant="body2" sx={{ color: '#fffffe', fontStyle: 'italic', fontSize: 13, mx:2 }}>from our kitchen to yours</Typography>
        </div>
      </div>

      <div className="search-box">
        <input type="text" placeholder="Search food..." />
        <i>
          <FaSearch />
        </i>
      </div>
    </div>
  );
}

export default TopSect;
