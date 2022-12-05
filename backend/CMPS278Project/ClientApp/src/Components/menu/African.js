import React, { useEffect } from "react";
import food from "../../img/chine.jpg";
import axios from 'axios'
import { Button, Card, CardActions, CardContent, CardMedia, Dialog, DialogActions, DialogContent, DialogContentText, Divider, Grid, styled, TextField, Typography } from "@mui/material";

function African() {

    const ColorButton = styled(Button)(({ theme }) => ({
        color: "#121629",
        backgroundColor: "#eebbc3",
        '&:hover': {
          backgroundColor: "#EF9DAA",
        //   color: '#fffffe'
        },
      }));

    const TextButton = styled(Button)(({ theme }) => ({
    color: "#EF9DAA",
    '&:hover': {
        backgroundColor: "#EF9DAA",
        color: '#fffffe'
    },
    }));

    const [open, setOpen] = React.useState(false);
    const [items, setItems] = React.useState([]);

    useEffect(() => {
        axios
          .get(`http://localhost:5119/api/MenuItems`)
          .then((res) => {
            setItems(res.data.response);
            console.log(items);
          })
          .catch((error) => {
            console.log(error);
          });
      }, []);

    const handleClickOpen = () => () => {
        setOpen(true);
    };

    const handleClose = () => {
        setOpen(false);
    };

    return (
        <>
            <div className="w-full mx-auto align">
                {items && (
                    <>
                        <Grid container spacing={1} sx={{ p: 1 }}>
                            {items.map((item) => {
                                return(
                                    <>
                                        <Grid item>
                                            <Card sx={{ width: 200, height: 270, m: 2, backgroundColor: "#fffffe" }}>
                                                <CardMedia
                                                    component="img"
                                                    height="130"
                                                    image={food}
                                                    alt="food" />
                                                <CardContent>
                                                    <Typography gutterBottom variant="h6" sx={{ fontSize: 18 }}>
                                                        {item.name}
                                                    </Typography>
                                                    <Typography variant="body1" sx={{ fontSize: 14, color: '#b8c1ec' }}>
                                                        LBP {item.price} <span style={{ color: '#9e9e9e' }}>/ piece</span>
                                                    </Typography>
                                                   {/* show availability */}
                                                </CardContent>
                                                <CardActions sx={{ display: 'flex', justifyContent: 'flex-end' }}>
                                                    <ColorButton size="small" sx={{ fontSize: 13, textTransform: 'capitalize', fontWeight: 500 }} onClick={handleClickOpen()} variant="contained">See More</ColorButton>
                                                </CardActions>
                                            </Card>
                                        </Grid> 
                                    </>
                                );
                            })}
                        </Grid> 
                        </>
                )}
                
            </div>
        </>
    );
}

{/* <Dialog
                                        open={open}
                                        onClose={handleClose}
                                    >
                                            <DialogContent dividers={true}>
                                                <div>
                                                    <img src={food} alt="food" height="350" width="100%" style={{ borderRadius: '8px' }} />
                                                </div>
                                                <DialogContentText>
                                                    <Typography variant="h4" sx={{ color: '#EF9DAA' }}>
                                                        Chocolate Caramel
                                                    </Typography>
                                                    <Typography variant="body1" sx={{ my: 1 }}>
                                                        moist and fudgy chocolate cake pop filled with caramel toffee dipped in chocolate and topped with salted crushed pretzels
                                                    </Typography>
                                                    <Typography sx={{ fontSize: 14, color: '#b8c1ec', mb: 1 }}>
                                                        LBP 50,000 <span style={{ color: '#9e9e9e' }}>/ piece</span>
                                                    </Typography>
                                                </DialogContentText>
                                                <Divider light />
                                                <TextField
                                                    margin="dense"
                                                    id="instructions"
                                                    label="Any special instructions?"
                                                    type="text"
                                                    fullWidth
                                                    variant="outlined"
                                                    sx={{ my: 2 }} />
                                            </DialogContent>
                                            <DialogActions sx={{ display: 'flex', justifyContent: 'space-between' }}>
                                                <TextButton onClick={handleClose}>Cancel</TextButton>
                                                <TextButton onClick={handleClose}>Add to Cart</TextButton>
                                            </DialogActions>
                                        </Dialog> */}

export default African;
