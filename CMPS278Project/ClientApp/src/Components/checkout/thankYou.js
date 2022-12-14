import React from "react";
import "../styles/foodContainer.css";
import { Button, Typography } from "@mui/material";
import { Link } from "react-router-dom";
import FavoriteIcon from '@mui/icons-material/Favorite';

function ThankYou() {

  return (
    <>
      <div className="foodcontainer">
        <div className="thank-u-block">
            <div style={{ display: 'flex', justifyContent: 'center' }}>
                <Typography variant="h4" sx={{ mr:0.5 }}>
                    Thank You!
                </Typography>
                <FavoriteIcon sx={{ color: '#EF9DAA', fontSize: 'xx-large', pt:0.5 }} />
            </div> 
            <Typography variant="h4">
                Your order will arrive soon!
            </Typography>
            <Button variant="text" component={Link} to="/menu" sx={{ mt:1, color: '#d4d8f0' }}>Go Back to Menu</Button>
        </div>
      </div>
    </>
  );
}

export default ThankYou;
