import { Container, Box, Typography, TextField, FormControl, InputLabel, Input, InputAdornment, Button, styled } from "@mui/material"
import "../styles/foodContainer.css";
import PermIdentity from '@mui/icons-material/PermIdentity';
import LockOutlined from '@mui/icons-material/LockOutlined';
import Link from '@mui/material/Link';
import { useState } from "react";
import { useNavigate } from "react-router-dom";
import axios from "axios";

function Login() {

    const ColorButton = styled(Button)(({ theme }) => ({
        color: "#121629",
        backgroundColor: "#eebbc3",
        '&:hover': {
          backgroundColor: "#EF9DAA",
        },
    }));

    const CustomizedLink = styled(Link)(({ theme }) => ({
        '&:hover': {
            color: "#EF9DAA"
        }
    }));

    const navigate = useNavigate();
    const [username, setUsername] = useState('');
    const [password, setPassword] = useState('');

    const handleSubmit = (e) => {
        // e.preventDefault();
        const user = {
            username,
            password
        };
        axios({
            method: 'POST',
            url: 'https://localhost:5001/api/Users/login',
            data: user,
          })
          .then(res => {
            console.log(res);
            navigate('/');
          })
          .catch((error) => {
            console.log(error);
          });  
    }

    return(
        <div className="foodcontainer" style={{ backgroundColor: '#232946' }}>
            <Container maxWidth="sm">
                <Box sx={{ backgroundColor: '#fffffe', position: 'relative', top: '10%', left: '10%', height: '80%', width: '70%', mx: 5, p:2, alignItems: 'center', boxShadow: '0px 0px 20px rgba(0, 0, 0, 0.4)', borderRadius: '7px' }}>
                    <Typography variant="h4" sx={{ textAlign: 'center', fontWeight: 600, pt:6, pb: 2, color: '#EF9DAA', height: '150px' }}>
                        Login
                    </Typography>
                    <div style={{ display: 'flex', flexDirection: 'column', justifyContent: 'center', textAlign: 'center', margin: '20px' }}>
                    {/* <TextField
                        required
                        id="name"
                        label="Name"
                        variant="standard"
                        sx={{
                            alignSelf: 'center',
                            width: '300px',
                            my: 2,
                            mx: 2
                        }}
                        /> */}
                        <FormControl variant="standard" sx={{ width: '300px', mx: 1, my: 2 }}>
                            <InputLabel htmlFor="name" sx={{ fontSize: 20 }}>
                                Name
                            </InputLabel>
                            <Input
                                required
                                id="name"
                                startAdornment={
                                    <InputAdornment position="start">
                                        <PermIdentity />
                                    </InputAdornment>
                                }
                                sx={{
                                    py: 1
                                }}
                                placeholder="Enter your name"
                                value={username}
                                onChange={(e) => setUsername(e.target.value)}
                            />
                        </FormControl>
                        <FormControl variant="standard" sx={{ width: '300px', mx: 1, my: 2 }}>
                            <InputLabel htmlFor="password" sx={{ fontSize: 20 }}>
                                Password
                            </InputLabel>
                            <Input
                                required
                                id="password"
                                startAdornment={
                                    <InputAdornment position="start">
                                        <LockOutlined />
                                    </InputAdornment>
                                }
                                sx={{
                                    py: 1
                                }}
                                type="password"
                                placeholder="Enter your password"
                                value={password}
                                onChange={(e) => setPassword(e.target.value)}
                            />
                        </FormControl>
                        <ColorButton onClick={handleSubmit} sx={{ mt: 3 }}>
                            Login
                        </ColorButton>

                        <span style={{ fontSize: 13, color: '#939699', paddingTop: '20px', paddingBottom: '2px' }}>Don't have an account?</span>
                        <CustomizedLink sx={{ fontSize: 13, color: '#4e5052' }} underline="hover" href="/register">
                            Register
                        </CustomizedLink>
                    </div>
                </Box>
            </Container>
        </div>
    )
}

export default Login