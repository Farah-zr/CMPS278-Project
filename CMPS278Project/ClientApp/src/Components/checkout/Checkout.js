import React, { useEffect } from "react";
import "../../assets/styles/foodContainer.css";
import {
  Box,
  Button,
  Container,
  Divider,
  IconButton,
  styled,
  Typography,
} from "@mui/material";
import ArrowBackIosIcon from "@mui/icons-material/ArrowBackIos";
import DeliveryDiningIcon from "@mui/icons-material/DeliveryDining";
import PlaceIcon from "@mui/icons-material/Place";
import AttachMoneyIcon from "@mui/icons-material/AttachMoney";
import { Link } from "react-router-dom";
import axios from "axios";
import Sidebar from "../Sidebar";

function Checkout() {
  const ColorButton = styled(Button)(({ theme }) => ({
    color: "#121629",
    backgroundColor: "#eebbc3",
    "&:hover": {
      backgroundColor: "#EF9DAA",
    },
  }));

  const [cartItems, setCartItems] = React.useState([]);
  const [items, setItems] = React.useState([]);

  // useEffect(() => {
  //   axios
  //     .get(`https://localhost:5001/api/CartItems`)
  //     .then((res) => {
  //       setCartItems(res.data);
  //       console.log(res.data);
  //       console.log(cartItems);
  //     })
  //     .catch((error) => {
  //       console.log(error);
  //     });
  // }, []);

  // useEffect(() => {
  //   axios
  //     .get(`https://localhost:5001/api/MenuItems`)
  //     .then((res) => {
  //       setItems(res.data);
  //       console.log(res.data);
  //       console.log(items);
  //     })
  //     .catch((error) => {
  //       console.log(error);
  //     });
  // }, []);

  var subtotal = 0;
  var total;

  cartItems.forEach((item) => {
    items
      .filter((data) => data.id == item.menuItemId)
      .map((filteredItem) => {
        subtotal += filteredItem.price * item.quantity;
      });
  });

  total = subtotal + 30000;

  return (
    <>
      <Sidebar />
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
                to="/cart"
                sx={{ ml: 1 }}
              >
                <ArrowBackIosIcon />
              </IconButton>
              <Typography
                variant="h5"
                component="div"
                sx={{ flexGrow: 1, color: "#121629" }}
              >
                Checkout
              </Typography>
            </Box>
            {/* <Divider light /> */}
            <Box
              sx={{
                display: "flex",
                flexDirection: "column",
                justifyContent: "space-between",
              }}
            >
              <div>
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
                  <Typography
                    variant="h6"
                    sx={{ fontSize: 16, fontWeight: 600, mb: 1, ml: 1 }}
                  >
                    Delivery Time
                  </Typography>
                  <div style={{ display: "flex" }}>
                    &emsp;
                    <DeliveryDiningIcon
                      sx={{ color: "#EF9DAA", fontSize: "x-large", pb: 0.5 }}
                    />
                    <Typography variant="body2" sx={{ ml: 0.5, fontSize: 14 }}>
                      25 - 40 minutes
                    </Typography>
                  </div>
                </Box>

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
                  <Typography
                    variant="h6"
                    sx={{ fontSize: 16, fontWeight: 600, mb: 1, ml: 1 }}
                  >
                    Delivery Address
                  </Typography>
                  <div style={{ display: "flex" }}>
                    &emsp;
                    <PlaceIcon
                      sx={{ color: "#EF9DAA", fontSize: "x-large", pb: 0.5 }}
                    />
                    <Typography variant="body2" sx={{ ml: 0.5, fontSize: 14 }}>
                      Beirut - Bliss Street - Bliss Building
                    </Typography>
                  </div>
                </Box>

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
                  <Typography
                    variant="h6"
                    sx={{ fontSize: 16, fontWeight: 600, mb: 1, ml: 1 }}
                  >
                    Payment Method
                  </Typography>
                  <div style={{ display: "flex" }}>
                    &emsp;
                    <AttachMoneyIcon
                      sx={{ color: "#EF9DAA", fontSize: "x-large", pb: 0.5 }}
                    />
                    <Typography variant="body2" sx={{ ml: 0.5, fontSize: 14 }}>
                      Cash
                    </Typography>
                  </div>
                </Box>
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
                    marginBottom: "15px",
                  }}
                >
                  <Typography variant="body2" sx={{ fontSize: 16, ml: 1 }}>
                    Subtotal
                  </Typography>
                  <Typography
                    variant="body2"
                    sx={{ fontSize: 14, color: "#A0A0A0" }}
                  >
                    LBP {subtotal}
                  </Typography>
                </div>

                <div
                  style={{
                    display: "flex",
                    justifyContent: "space-between",
                    marginBottom: "15px",
                  }}
                >
                  <Typography variant="body2" sx={{ fontSize: 16, ml: 1 }}>
                    Delivery Charge
                  </Typography>
                  <Typography
                    variant="body2"
                    sx={{ fontSize: 14, color: "#A0A0A0" }}
                  >
                    LBP 30000
                  </Typography>
                </div>

                <Divider light />

                <div
                  style={{
                    display: "flex",
                    justifyContent: "space-between",
                    marginTop: "15px",
                  }}
                >
                  <Typography variant="h6" sx={{ fontWeight: 600, ml: 2 }}>
                    Total
                  </Typography>
                  <Typography variant="h6" sx={{ color: "#A0A0A0", ml: 2 }}>
                    LBP {total}
                  </Typography>
                </div>
              </Box>

              <div className="place-order-btn">
                <ColorButton
                  variant="contained"
                  component={Link}
                  to="/thanku"
                  sx={{ mx: 5, my: 3, p: 1, width: "85%" }}
                >
                  Place Order
                </ColorButton>
              </div>
            </Box>
          </Box>
        </Container>
      </div>
    </>
  );
}

export default Checkout;
