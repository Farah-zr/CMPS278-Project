import React, { useEffect } from "react";
import ChevronRightIcon from '@mui/icons-material/ChevronRight';
import axios from 'axios';
import { Button, Card, CardActionArea, CardActions, CardContent, CardMedia, Dialog, DialogActions, DialogContent, DialogContentText, Divider, Grid, IconButton, styled, TextField, Typography } from "@mui/material";

function AllMenuItems() {

    const TextButton = styled(Button)(({ theme }) => ({
    color: "#EF9DAA",
    '&:hover': {
        backgroundColor: "#EF9DAA",
        color: '#fffffe'
    },
    }));

    const ItemDialog = styled(Dialog)(({ theme }) => ({
        '& .MuiDialog-paper': {
          width: "500px"
        },
    }));

    const [open, setOpen] = React.useState(false);
    const [items, setItems] = React.useState([]);
    const [quantity, setQuantity] = React.useState(1);
    const [id, setId] = React.useState(0);

    useEffect(() => {
        axios
          .get(`https://localhost:5001/api/MenuItems`)
          .then((res) => {
            setItems(res.data);
          })
          .catch((error) => {
            console.log(error);
          });
      }, []);

    const handleClickOpen = (e) => {
        setId(e.currentTarget.getAttribute('button-key'));
        setOpen(true);
    };

    const handleClose = () => {
        setOpen(false);
        setQuantity(1);
    };

    // Increase Quantity
    const AddQuantity = (e) => {
        e.preventDefault();
        setQuantity(quantity => quantity + 1);
    };

    // Decrease Quantity
    const DecreaseQuantity = () => {
        if(quantity > 0) {
            setQuantity(quantity => quantity - 1);
        }
    };

    const handleAddCartitem = (e) => {
        const cartItem = {
            quantity: quantity,
            menuItemId: id
        };
        axios({
            method: 'POST',
            url: 'https://localhost:5001/api/CartItems',
            data: cartItem,
          })
          .then(res => {
            console.log(res);
            console.log(res.data);
          })
          .catch((error) => {
            console.log(error);
          });

        setOpen(false);
        setQuantity(1);
    }

    return (
        <>
            <div className="w-full mx-auto align">
                {items && (
                    <>
                        <Grid container spacing={1} sx={{ px: 2, py: 1 }}>
                            {items.map((item) => {
                                return(
                                    <>
                                        <Grid item>
                                            <Card sx={{ width: 200, height: 270, m: 1, backgroundColor: "#fffffe" }}>
                                                <CardActionArea component={Button} sx={{ textTransform: 'capitalize', height: 'fitContent' }} button-key={item.id} onClick={(e) => handleClickOpen(e)}>
                                                    <CardMedia
                                                        component="img"
                                                        height="130"
                                                        image={require("../../img/allMenuItems/" + item.id + ".jpg")}
                                                        alt="food" />
                                                    <CardContent sx={{ pb:0, height: 92 }}>
                                                        <Typography gutterBottom variant="h6" sx={{ fontSize: 17, height: 50, overflow: 'hidden' }}>
                                                            {item.name}
                                                        </Typography>
                                                        <Typography variant="body1" sx={{ fontSize: 14, color: '#b8c1ec' }}>
                                                            LBP {item.price} <span style={{ color: '#9e9e9e' }}>/ piece</span>
                                                        </Typography>
                                                        {/* show availability */}
                                                    </CardContent>
                                                    <CardActions sx={{ display: 'flex', justifyContent: 'flex-end', p:1 }}>
                                                        <IconButton button-key={item.id} onClick={(e) => handleClickOpen(e)} size="small" aria-label="arrow" style={{ color: '#EF9DAA' }}>
                                                            <ChevronRightIcon />
                                                        </IconButton>
                                                    </CardActions>
                                                </CardActionArea>
                                            </Card>
                                        </Grid> 
                                    </>
                                );
                            })}
                            {items.filter((Data) => Data.id == id)
                                  .map((filteredItem) => (
                                    <ItemDialog
                                        open={open}
                                        onClose={handleClose}
                                    >
                                        <DialogContent dividers={true}>
                                            <div>
                                                <img src={require("../../img/allMenuItems/" + filteredItem.id + ".jpg")} alt="food" height="350" width="100%" style={{ borderRadius: '5px' }} />
                                            </div>
                                            <DialogContentText>
                                                 <Typography variant="h5">
                                                    {filteredItem.name}
                                                </Typography>
                                                <Typography variant="body1" sx={{ my: 1 }}>
                                                    {filteredItem.description}
                                                </Typography>
                                                <Typography sx={{ fontSize: 14, color: '#b8c1ec', mb: 1 }}>
                                                    LBP {filteredItem.price} <span style={{ color: '#9e9e9e' }}>/ piece</span>
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
                                            <Divider light />
                                            <div className="quantity-div">
                                                <div className="quantity-input">
                                                    <button className="quantity-input-left" onClick={DecreaseQuantity}>
                                                        &ndash;
                                                    </button>
                                                    <input className="quantity-input-screen" type="text" value={quantity} readonly />
                                                    <button className="quantity-input-right" onClick={AddQuantity}>
                                                        &#xff0b;
                                                    </button>  
                                                </div> 
                                            </div> 
                                            <Divider light />
                                        </DialogContent>
                                        <DialogActions sx={{ display: 'flex', justifyContent: 'space-between' }}>
                                            <TextButton onClick={handleClose}>Cancel</TextButton>
                                            <TextButton onClick={handleAddCartitem}>Add to Cart</TextButton>
                                        </DialogActions>
                                    </ItemDialog>
                                  ))
                            }
                        </Grid> 
                    </>
                )}

                
            </div>
        </>
    );
}

export default AllMenuItems;
