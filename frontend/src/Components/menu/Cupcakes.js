import React, { useEffect } from "react";
import ArrowForwardIosIcon from '@mui/icons-material/ArrowForwardIos';
import axios from 'axios'
import { Button, Card, CardActionArea, CardActions, CardContent, CardMedia, Dialog, DialogActions, DialogContent, DialogContentText, Divider, Grid, IconButton, styled, TextField, Typography } from "@mui/material";

function Cupcakes() {

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
    const cors = require('cors');

    useEffect(() => {
        axios
          .get(`https://localhost:7277/api/Cupcakes`)
          .then((res) => {
            setItems(res.data);
          })
          .catch((error) => {
            console.log(error);
          });
      }, []);

    const handleClickOpen = () => () => {
        setOpen(true);
        console.log("clicked");
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
                                                <CardActionArea component={Button} sx={{ textTransform: 'capitalize', height: 'fitContent' }} onClick={handleClickOpen()}>
                                                    <CardMedia
                                                        component="img"
                                                        height="130"
                                                        image={require("../../img/cupcakes/" + item.id + ".jpg")}
                                                        alt="food" />
                                                    <CardContent sx={{ pb:0, height: 96 }}>
                                                        <Typography gutterBottom variant="h6" sx={{ fontSize: 17, height: 48 }}>
                                                            {item.name}
                                                        </Typography>
                                                        <Typography variant="body1" sx={{ fontSize: 14, color: '#b8c1ec' }}>
                                                            LBP {item.price} <span style={{ color: '#9e9e9e' }}>/ piece</span>
                                                        </Typography>
                                                        {/* show availability */}
                                                    </CardContent>
                                                    <CardActions sx={{ display: 'flex', justifyContent: 'flex-end', p:1 }}>
                                                        <IconButton size="small" aria-label="arrow" style={{ color: '#EF9DAA' }}>
                                                            <ArrowForwardIosIcon />
                                                        </IconButton>
                                                    </CardActions>
                                                </CardActionArea>
                                            </Card>
                                        </Grid> 
                                        <Dialog
                                            open={open}
                                            onClose={handleClose}
                                        >
                                            <DialogContent dividers={true}>
                                                <div>
                                                    <img src={require("../../img/cupcakes/" + item.id + ".jpg")} alt="food" height="350" width="100%" style={{ borderRadius: '8px' }} />
                                                </div>
                                                <DialogContentText>
                                                    <Typography variant="h4" sx={{ color: '#EF9DAA' }}>
                                                        {item.name}
                                                    </Typography>
                                                    <Typography variant="body1" sx={{ my: 1 }}>
                                                        {item.description}
                                                    </Typography>
                                                    <Typography sx={{ fontSize: 14, color: '#b8c1ec', mb: 1 }}>
                                                        LBP {item.price} <span style={{ color: '#9e9e9e' }}>/ piece</span>
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
                                        </Dialog>
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

export default Cupcakes;
