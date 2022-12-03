import React from "react";
import "../styles/foodContainer.css";
import { AppBar, Box, Divider, IconButton, Toolbar, Typography } from "@mui/material";
import ArrowBackIosIcon from '@mui/icons-material/ArrowBackIos';
import { Link } from "react-router-dom";

function Checkout() {

  return (
    <>
      <div className="foodcontainer">
        <Box sx={{ backgroundColor: '#d4d8f0', height: '98%', width: '100%', mx: 5, boxShadow: '0px 0px 20px rgba(0, 0, 0, 0.4)', borderRadius: '7px' }}>
            <Box sx={{ display: 'flex', alignItems: 'center', textAlign: 'center', boxShadow: '0px 5px 10px rgba(0, 0, 0, 0.4)', pt: 1 }}>
                <IconButton
                    size="large"
                    edge="start"
                    color="inherit"
                    component={Link} 
                    to="/" 
                    sx={{ mx: 2 }}
                >
                    <ArrowBackIosIcon />
                </IconButton>
                <Typography variant="h5" component="div" sx={{ flexGrow: 1, color: '#121629' }}>
                    Checkout
                </Typography>
            </Box>
            {/* <Divider light /> */}
            <Box sx={{ display: 'flex', flexDirection: 'column', justifyContent: 'space-between' }}>
                <div>
                <Box sx={{ backgroundColor: '#fffffe', boxShadow: '0px 0px 20px rgba(0, 0, 0, 0.4)', borderRadius: '5px', mx: 5, my: 3, p: 1 }}>
                    delivery
                </Box>
                <Box sx={{ backgroundColor: '#fffffe', boxShadow: '0px 0px 20px rgba(0, 0, 0, 0.4)', borderRadius: '5px', mx: 5, my: 3, p: 1 }}>
                    delivery
                </Box>
                <Box sx={{ backgroundColor: '#fffffe', boxShadow: '0px 0px 20px rgba(0, 0, 0, 0.4)', borderRadius: '5px', mx: 5, my: 3, p: 1 }}>
                    delivery
                </Box>
                </div>
                <Box sx={{ backgroundColor: '#fffffe', boxShadow: '0px 0px 20px rgba(0, 0, 0, 0.4)', borderRadius: '5px', mx: 5, my: 3, p: 1 }}>
                    delivery
                </Box>
            </Box>
        </Box>
      </div>
    </>
  );
}

export default Checkout;
