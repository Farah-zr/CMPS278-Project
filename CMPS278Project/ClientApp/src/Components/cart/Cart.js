import React from "react";
import "../styles/foodContainer.css";
import {
  Box,
  Button,
  Container,
  IconButton,
  styled,
  Typography,
} from "@mui/material";
import DeleteIcon from "@mui/icons-material/Delete";
import ArrowBackIosIcon from "@mui/icons-material/ArrowBackIos";
import { Link } from "react-router-dom";
import axios from "axios";
import { useEffect } from "react";
import SideBar from "../SideBar";

function Cart() {
  const ColorButton = styled(Button)(({ theme }) => ({
    color: "#121629",
    backgroundColor: "#eebbc3",
    "&:hover": {
      backgroundColor: "#EF9DAA",
    },
  }));

  const [cartItems, setCartItems] = React.useState([]);
  const [items, setItems] = React.useState([]);
  const [state, setState] = React.useState(0);

  useEffect(() => {
    axios
      .get(`https://localhost:5001/api/CartItems`)
      .then((res) => {
        setCartItems(res.data);
      })
      .catch((error) => {
        console.log(error);
      });
  }, [state]);

  const handleDelete = (e) => {
    var id = e.currentTarget.getAttribute("button-key");
    cartItems
      .filter((data) => data.menuItemId == id)
      .map((deletedItem) => {
        console.log(deletedItem.id);
        fetch("https://localhost:5001/api/CartItems/" + deletedItem.id, {
          method: "DELETE",
        });
      });
    setState((n) => n + 1);
  };

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

  cartItems.forEach((item) => {
    items
      .filter((data) => data.id == item.menuItemId)
      .map((filteredItem) => {
        listOfCartItems.push(filteredItem);
        quantities.push(item.quantity);
        ids.push(item.menuItemId);
        prices += filteredItem.price * item.quantity;
      });
  });

  return (
    <>
      <SideBar />
      <div className="foodcontainer">
        <Container maxWidth="sm">
          <Box
            sx={{
              backgroundColor: "#d4d8f0",
              height: "98%",
              width: "100%",
              mx: 5,
              boxShadow: "0px 0px 20px rgba(0, 0, 0, 0.4)",
              borderRadius: "7px",
            }}
          >
            <Box
              sx={{
                display: "flex",
                alignItems: "center",
                textAlign: "center",
                boxShadow: "0px 5px 10px rgba(0, 0, 0, 0.4)",
                pt: 1,
              }}
            >
              <IconButton
                size="large"
                edge="start"
                color="inherit"
                component={Link}
                to="/menu"
                sx={{ ml: 1 }}
              >
                <ArrowBackIosIcon />
              </IconButton>
              <Typography
                variant="h5"
                sx={{ flexGrow: 1, textAlign: "center", color: "#121629" }}
              >
                My Cart
              </Typography>
            </Box>

            <div className="labels">
              <h4>Item</h4>
              <h4>Quantity</h4>
              <h4>Price</h4>
            </div>

            <Box
              sx={{
                display: "flex",
                flexDirection: "column",
                justifyContent: "space-between",
              }}
            >
              <div style={{ height: "300px" }}>
                {listOfCartItems &&
                  listOfCartItems.map((item) => {
                    i++;
                    return (
                      <Box
                        className="item"
                        sx={{
                          backgroundColor: "#fffffe",
                          boxShadow: "0px 0px 20px rgba(0, 0, 0, 0.4)",
                          borderRadius: "5px",
                          mx: 5,
                          mb: 3,
                          p: 1,
                        }}
                      >
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
                            <IconButton
                              button-key={item.id}
                              onClick={(e) => handleDelete(e)}
                              className="trash-box"
                              aria-label="delete"
                            >
                              <DeleteIcon />
                            </IconButton>
                          </div>
                        </div>
                      </Box>
                    );
                  })}
              </div>
              <Box
                sx={{
                  backgroundColor: "#fffffe",
                  boxShadow: "0px 0px 20px rgba(0, 0, 0, 0.4)",
                  borderRadius: "5px",
                  mx: 5,
                  my: 3,
                  p: 1,
                }}
              >
                <div
                  style={{
                    display: "flex",
                    justifyContent: "space-between",
                    marginTop: "15px",
                    marginBottom: "15px",
                    padding: "5px",
                  }}
                >
                  <Typography variant="h6" sx={{ fontWeight: 600, ml: 2 }}>
                    Total
                  </Typography>
                  <Typography variant="h6" sx={{ color: "#A0A0A0", mr: 2 }}>
                    LBP {prices}
                  </Typography>
                </div>
              </Box>

              <div className="checkout-btn">
                <ColorButton
                  component={Link}
                  to="../checkout"
                  variant="contained"
                  sx={{ width: "85%", mx: 5, my: 3, p: 1 }}
                >
                  Checkout
                </ColorButton>
              </div>
            </Box>
          </Box>
        </Container>
      </div>
    </>
  );
}

export default Cart;
