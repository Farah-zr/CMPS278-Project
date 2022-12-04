import React from "react";
import "../styles/foodContainer.css";
import { AppBar, Box, Button, Dialog, IconButton, Slide, styled, Toolbar, Typography } from "@mui/material";
import DeleteIcon from '@mui/icons-material/Delete';
import CloseIcon from '@mui/icons-material/Close';
import { Link } from "react-router-dom";

function Cart() {

const Transition = React.forwardRef(function Transition(props, ref) {
  return <Slide direction="up" ref={ref} {...props} />;
});

  const [open, setOpen] = React.useState(false);

  const handleClickOpen = () => {
    setOpen(true);
  };

  const handleClose = () => {
    setOpen(false);
  };

  const ColorButton = styled(Button)(({ theme }) => ({
    color: "black",
    backgroundColor: "#eebbc3",
    '&:hover': {
      backgroundColor: "#EF9DAA",
    },
  }));

  return (
    <>
        <div>
          <Box className="cart">
            <div className="labels">
              <h5>Item</h5>
              <h5>Quantity</h5>
              <h5>Price</h5>
            </div>

            <Box className="item">
              <div className="item-details">
                <div>
                  <b>African</b>
                  <p>$1.50</p>
                </div>
                <p className="qty-box">1</p>
                <div>
                  <p>$1.50</p>
                  <IconButton className="trash-box" aria-label="delete">
                    <DeleteIcon />
                  </IconButton>
                </div>
              </div>
            </Box>

            <Box className="item">
              <div className="item-details">
                <div>
                  <b>African</b>
                  <p>$1.50</p>
                </div>
                <p className="qty-box">1</p>
                <div>
                  <p>$1.50</p>
                  <IconButton className="trash-box" aria-label="delete">
                    <DeleteIcon />
                  </IconButton>
                </div>
              </div>
            </Box>

            <Box className="item">
              <div className="item-details">
                <div>
                  <b>Italian</b>
                  <p>$1.50</p>
                </div>
                <p className="qty-box">2</p>
                <div>
                  <p>$3.00</p>
                  <IconButton className="trash-box" aria-label="delete">
                    <DeleteIcon />
                  </IconButton>
                </div>
              </div>
            </Box>

            <Box className="total">
              <h3>Total:</h3>
              <p>$6.00</p>
            </Box>

            <ColorButton 
              component={Link} 
              to="../checkout" 
              className="checkout-btn" 
              variant="contained"
            >
              Checkout
            </ColorButton>

          </Box>
        </div>

        <div id="checkout">
          <Dialog
          fullScreen
          open={open}
          onClose={handleClose}
          TransitionComponent={Transition}
        >
            <AppBar sx={{ position: 'relative' }}>
              <Toolbar>
                <IconButton
                  edge="start"
                  color="inherit"
                  onClick={handleClose}
                  aria-label="close"
                >
                  <CloseIcon />
                </IconButton>
                <Typography sx={{ ml: 2, flex: 1, justifyContent: 'space-between' }} variant="h6" component="div">
                  Sound
                </Typography>
                <Button autoFocus color="inherit" onClick={handleClose}>
                  save
                </Button>
              </Toolbar>
            </AppBar>
          </Dialog>
        </div>
      
    </>
  );
}

export default Cart;
