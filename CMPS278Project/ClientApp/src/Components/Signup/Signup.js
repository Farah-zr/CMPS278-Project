import {
  Container,
  Box,
  Typography,
  FormControl,
  InputLabel,
  Input,
  Button,
  styled,
} from "@mui/material";
import "../../assets/styles/foodContainer.css";
import Link from "@mui/material/Link";
import { useState } from "react";
import { useNavigate } from "react-router-dom";
import axios from "axios";

function Signup() {
  const ColorButton = styled(Button)(({ theme }) => ({
    color: "#121629",
    backgroundColor: "#eebbc3",
    "&:hover": {
      backgroundColor: "#EF9DAA",
    },
  }));

  const CustomizedLink = styled(Link)(({ theme }) => ({
    "&:hover": {
      color: "#EF9DAA",
    },
  }));

  const navigate = useNavigate();
  const [username, setUsername] = useState("");
  const [password, setPassword] = useState("");
  const [email, setEmail] = useState("");
  const [address, setAddress] = useState("");
  const [phoneNumber, setPhoneNumber] = useState("");

  const handleSubmit = (e) => {
    const user = {
      username,
      password,
      email,
      address,
      phoneNumber,
    };
    axios({
      method: "POST",
      url: "https://localhost:5001/api/Users/register",
      data: user,
    })
      .then((res) => {
        console.log(res);
        navigate("/menu");
      })
      .catch((error) => {
        console.log(error);
      });
  };

  return (
    <div className="foodcontainer" style={{ backgroundColor: "#232946" }}>
      <Container maxWidth="sm">
        <Box
          sx={{
            backgroundColor: "#fffffe",
            position: "relative",
            top: "3%",
            left: "10%",
            height: "93%",
            width: "70%",
            mx: 5,
            p: 2,
            alignItems: "center",
            boxShadow: "0px 0px 20px rgba(0, 0, 0, 0.4)",
            borderRadius: "7px",
          }}
        >
          <Typography
            variant="h4"
            sx={{
              textAlign: "center",
              fontWeight: 600,
              pt: 4,
              pb: 2,
              color: "#EF9DAA",
              height: "100px",
            }}
          >
            Sign Up
          </Typography>
          <div
            style={{
              display: "flex",
              flexDirection: "column",
              justifyContent: "center",
              textAlign: "center",
              margin: "20px",
            }}
          >
            <FormControl
              variant="standard"
              sx={{ width: "300px", mx: 1, my: 1 }}
            >
              <InputLabel htmlFor="name" sx={{ fontSize: 16 }}>
                Name
              </InputLabel>
              <Input
                required
                id="name"
                sx={{
                  py: 1,
                }}
                placeholder="Enter your name"
                value={username}
                onChange={(e) => setUsername(e.target.value)}
              />
            </FormControl>
            <FormControl
              variant="standard"
              sx={{ width: "300px", mx: 1, mb: 1 }}
            >
              <InputLabel htmlFor="email" sx={{ fontSize: 16 }}>
                Email
              </InputLabel>
              <Input
                required
                id="email"
                sx={{
                  py: 1,
                }}
                type="email"
                placeholder="Enter your email"
                value={email}
                onChange={(e) => setEmail(e.target.value)}
              />
            </FormControl>
            <FormControl
              variant="standard"
              sx={{ width: "300px", mx: 1, mb: 1 }}
            >
              <InputLabel htmlFor="password" sx={{ fontSize: 16 }}>
                Password
              </InputLabel>
              <Input
                required
                id="password"
                sx={{
                  py: 1,
                }}
                type="password"
                placeholder="Enter your password"
                value={password}
                onChange={(e) => setPassword(e.target.value)}
              />
            </FormControl>
            <FormControl
              variant="standard"
              sx={{ width: "300px", mx: 1, mb: 1 }}
            >
              <InputLabel htmlFor="address" sx={{ fontSize: 16 }}>
                Address
              </InputLabel>
              <Input
                required
                id="address"
                sx={{
                  py: 1,
                }}
                placeholder="Enter your address"
                value={address}
                onChange={(e) => setAddress(e.target.value)}
              />
            </FormControl>
            <FormControl
              variant="standard"
              sx={{ width: "300px", mx: 1, mb: 1 }}
            >
              <InputLabel htmlFor="phonenum" sx={{ fontSize: 16 }}>
                Phone Number
              </InputLabel>
              <Input
                required
                id="phonenum"
                sx={{
                  py: 1,
                }}
                placeholder="Enter your phone number"
                focused
                value={phoneNumber}
                onChange={(e) => setPhoneNumber(e.target.value)}
              />
            </FormControl>
            <ColorButton onClick={handleSubmit} sx={{ mt: 3 }}>
              Sign up
            </ColorButton>

            <span
              style={{
                fontSize: 13,
                color: "#939699",
                paddingTop: "20px",
                paddingBottom: "2px",
              }}
            >
              Already have an account?
            </span>
            <CustomizedLink
              sx={{ fontSize: 13, color: "#4e5052" }}
              underline="hover"
              href="/"
            >
              Login
            </CustomizedLink>
          </div>
        </Box>
      </Container>
    </div>
  );
}

export default Signup;
