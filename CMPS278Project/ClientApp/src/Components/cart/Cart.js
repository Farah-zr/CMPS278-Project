import React from "react";
import "../styles/foodContainer.css";
import { Box, Button, IconButton, styled, Typography } from "@mui/material";
import DeleteIcon from '@mui/icons-material/Delete';
import { Link } from "react-router-dom";
import axios from 'axios'
import { useEffect } from "react";

function Cart() {

  const ColorButton = styled(Button)(({ theme }) => ({
    color: "#121629",
    backgroundColor: "#eebbc3",
    '&:hover': {
      backgroundColor: "#EF9DAA",
    },
  }));

  const [cartItems, setCartItems] = React.useState([]);
  const [items, setItems] = React.useState([]);

  // if using original db, this would be the code:

  useEffect(() => {
    axios
      .get(`https://localhost:5001/api/CartItems`)
      .then((res) => {
        setCartItems(res.data);
        console.log(res.data);
        console.log(cartItems);
      })
      .catch((error) => {
        console.log(error);
      });
  });


  // using json server bc of the cors bug
  // useEffect(() => {
  //   fetch('https://localhost:8000/cartItems')
  //     .then((res) => {
  //         if(!res.ok) {
  //           throw Error("could not fetch the data");
  //       }
  //       return res.json();
  //     })
  //     .then((data) => {
  //       setCartItems(data);
  //     })
  //     .catch((error) => {
  //       console.log(error);
  //     });
  // }, []);


//   const handleDelete = (e) => {
//     var id = e.currentTarget.getAttribute('button-key');
//     cartItems.filter((data) => data.menuItemId == id)
//               .map((deletedItem) => {
//                 console.log(deletedItem.id);
//                 fetch("https://localhost:8000/cartItems/" + deletedItem.id, {
//                     method: "DELETE"    
//                 })
//               })
// }
  
  useEffect(() => {
    axios
      .get(`https://localhost:5001/api/MenuItems`)
      .then((res) => {
        setItems(res.data);
        console.log(res.data);
        console.log(items);
      })
      .catch((error) => {
        console.log(error);
      });
  }, []);

  // getting list of cart items from menu items db
  var listOfCartItems = [];
  var quantities = [];
  var ids = [];
  var prices = 0;
  var i = -1;

  cartItems.forEach(item => {
    items.filter((data) => data.id == item.menuItemId)
          .map((filteredItem) => {
            listOfCartItems.push(filteredItem);
            quantities.push(item.quantity);
            ids.push(item.menuItemId);
            prices += filteredItem.price * item.quantity;
          })
  });

  // var empty = true;
  // if (listOfCartItems.length !== 0) empty = false;

  return (
    <>
        <div>
          <Box className="cart">
            <div className="labels">
              <h5>Item</h5>
              <h5>Quantity</h5>
              <h5>Price</h5>
            </div>

            {/* {empty && (
              <Box className="item">
              <div className="item-details">
                <Typography sx={{ fontWeight: 600, fontSize: 16, color: '#121629' }}>Cart is empty</Typography>
              </div>
              </Box>
            )} */}

            {
              listOfCartItems && (
                listOfCartItems.map((item) =>{
                  i++;
                  return(
                    <Box className="item">
                      <div className="item-details">
                        <div className="item-name">
                          <b>{item.name}</b>
                          <p>LBP {item.price}</p>
                        </div>
                        <div className="item-quantity">
                          <p className="qty-box">{quantities[i]}</p>
                        </div>
                        <div className="item-price">
                          <p>LBP {item.price * quantities[i]}</p>
                          <IconButton button-key={item.id} className="trash-box" aria-label="delete">
                            <DeleteIcon />
                          </IconButton>
                        </div>
                      </div>
                    </Box> 
                  );
                })
              )
            }

            <Box className="total">
              <h3>Total:</h3>
              <p>LBP {prices}</p>
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
    </>
  );
}

export default Cart;
