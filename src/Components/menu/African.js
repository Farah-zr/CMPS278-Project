import React from "react";
import food from "../../img/chine.jpg";
import { Button, Card, CardActions, CardContent, CardMedia, Dialog, DialogActions, DialogContent, DialogContentText, DialogTitle, Grid, styled, Typography } from "@mui/material";

function African() {

    const ColorButton = styled(Button)(({ theme }) => ({
        color: "#EF9DAA",
        // backgroundColor: "#eebbc3",
        '&:hover': {
          backgroundColor: "#EF9DAA",
          color: '#fffffe'
        },
      }));

    const [open, setOpen] = React.useState(false);
    const [scroll, setScroll] = React.useState('paper');

    const handleClickOpen = (scrollType) => () => {
        setOpen(true);
        setScroll(scrollType);
    };

    const handleClose = () => {
        setOpen(false);
    };

    const descriptionElementRef = React.useRef(null);
        React.useEffect(() => {
            if (open) {
            const { current: descriptionElement } = descriptionElementRef;
            if (descriptionElement !== null) {
                descriptionElement.focus();
            }
            }
        }, [open]);

    return (
        <>
            <div className="w-full mx-auto align">
                <Grid container spacing={1} sx={{ p: 1 }}> 
                    <Grid item>
                        <Card sx={{ width: 200, height: 270, m: 2, backgroundColor: "#fffffe" }}>
                            <CardMedia
                                component="img"
                                height="130"
                                image={food}
                                alt="food"
                            />
                            <CardContent sx={{ textOverflow: 'ellipsis' }}>
                                <Typography gutterBottom variant="h6" sx={{ fontSize: 18 }}>
                                Chocolate Caramel
                                </Typography>
                                <Typography variant="body1" sx={{ fontSize: 14, color: '#b8c1ec' }}>
                                {/* moist and fudgy chocolate cake pop filled with caramel toffee dipped in chocolate and topped with salted crushed pretzels */}
                                LBP 50,000 <span style={{color: '#9e9e9e'}}>/ piece</span>
                                </Typography>
                                {/*  make green when Available */}
                                {/* <Typography variant="body2" color="text.secondary">  
                                Available
                                </Typography> */}
                            </CardContent>
                            <CardActions sx={{ display: 'flex', justifyContent: 'flex-end' }}>
                                {/* <ColorButton sx={{ mx:1 }} size="small" variant="contained">Add to Cart</ColorButton> */}
                                <ColorButton size="small" onClick={handleClickOpen('paper')} variant="text">See More..</ColorButton>
                            </CardActions>
                            <Dialog
                                open={open}
                                onClose={handleClose}
                                scroll={scroll}
                                aria-labelledby="scroll-dialog-title"
                                aria-describedby="scroll-dialog-description"
                            >
                                <DialogTitle id="scroll-dialog-title">Subscribe</DialogTitle>
                                <DialogContent dividers={scroll === 'paper'}>
                                <DialogContentText
                                    id="scroll-dialog-description"
                                    ref={descriptionElementRef}
                                    tabIndex={-1}
                                >
                                    {[...new Array(50)]
                                    .map(
                                        () => `Cras mattis consectetur purus sit amet fermentum.
                        Cras justo odio, dapibus ac facilisis in, egestas eget quam.
                        Morbi leo risus, porta ac consectetur ac, vestibulum at eros.
                        Praesent commodo cursus magna, vel scelerisque nisl consectetur et.`,
                                    )
                                    .join('\n')}
                                </DialogContentText>
                            </DialogContent>
                            <DialogActions>
                                <Button onClick={handleClose}>Cancel</Button>
                                <Button onClick={handleClose}>Subscribe</Button>
                            </DialogActions>
                        </Dialog>
                        </Card>
                    </Grid>

                    

                    <Grid item>
                        <Card sx={{ width: 200, height: 300, m: 2, backgroundColor: "#fffffe" }}>
                            <CardMedia
                                component="img"
                                height="130"
                                image={food}
                                alt="food"
                            />
                            <CardContent>
                                <Typography gutterBottom variant="h5" component="div">
                                African
                                </Typography>
                                <Typography variant="body1" color="text.secondary">
                                Price: $10
                                </Typography>
                                {/*  make green when Available */}
                                <Typography variant="body2" color="textSuccess">  
                                Available
                                </Typography>
                            </CardContent>
                            <CardActions>
                                {/* <ColorButton sx={{ mx:1 }} size="small" variant="contained">Add to Cart</ColorButton> */}
                                <ColorButton size="small" variant="contained">See More</ColorButton>
                            </CardActions>
                        </Card>
                    </Grid>

                    <Grid item>
                        <Card sx={{ width: 200, height: 300, m: 2, backgroundColor: "#fffffe" }}>
                            <CardMedia
                                component="img"
                                height="130"
                                image={food}
                                alt="food"
                            />
                            <CardContent>
                                <Typography gutterBottom variant="h5" component="div">
                                African
                                </Typography>
                                <Typography variant="body1" color="text.secondary">
                                Price: $10
                                </Typography>
                                {/*  make green when Available */}
                                <Typography variant="body2" color="textSuccess">  
                                Available
                                </Typography>
                            </CardContent>
                            <CardActions>
                                {/* <ColorButton sx={{ mx:1 }} size="small" variant="contained">Add to Cart</ColorButton> */}
                                <ColorButton size="small" variant="contained">See More</ColorButton>
                            </CardActions>
                        </Card>
                    </Grid>

                    <Grid item>
                        <Card sx={{ width: 200, height: 300, m: 2, backgroundColor: "#fffffe" }}>
                            <CardMedia
                                component="img"
                                height="130"
                                image={food}
                                alt="food"
                            />
                            <CardContent>
                                <Typography gutterBottom variant="h5" component="div">
                                African
                                </Typography>
                                <Typography variant="body1" color="text.secondary">
                                Price: $10
                                </Typography>
                                {/*  make green when Available */}
                                <Typography variant="body2" color="textSuccess">  
                                Available
                                </Typography>
                            </CardContent>
                            <CardActions>
                                {/* <ColorButton sx={{ mx:1 }} size="small" variant="contained">Add to Cart</ColorButton> */}
                                <ColorButton size="small" variant="contained">See More</ColorButton>
                            </CardActions>
                        </Card>
                    </Grid>

                    <Grid item>
                        <Card sx={{ width: 200, height: 300, m: 2, backgroundColor: "#fffffe" }}>
                            <CardMedia
                                component="img"
                                height="130"
                                image={food}
                                alt="food"
                            />
                            <CardContent>
                                <Typography gutterBottom variant="h5" component="div">
                                African
                                </Typography>
                                <Typography variant="body1" color="text.secondary">
                                Price: $10
                                </Typography>
                                {/*  make green when Available */}
                                <Typography variant="body2" color="textSuccess">  
                                Available
                                </Typography>
                            </CardContent>
                            <CardActions>
                                {/* <ColorButton sx={{ mx:1 }} size="small" variant="contained">Add to Cart</ColorButton> */}
                                <ColorButton size="small" variant="contained">See More</ColorButton>
                            </CardActions>
                        </Card>
                    </Grid>

                    <Grid item>
                        <Card sx={{ width: 200, height: 300, m: 2, backgroundColor: "#fffffe" }}>
                            <CardMedia
                                component="img"
                                height="130"
                                image={food}
                                alt="food"
                            />
                            <CardContent>
                                <Typography gutterBottom variant="h5" component="div">
                                African
                                </Typography>
                                <Typography variant="body1" color="text.secondary">
                                Price: $10
                                </Typography>
                                {/*  make green when Available */}
                                <Typography variant="body2" color="textSuccess">  
                                Available
                                </Typography>
                            </CardContent>
                            <CardActions>
                                {/* <ColorButton sx={{ mx:1 }} size="small" variant="contained">Add to Cart</ColorButton> */}
                                <ColorButton size="small" variant="contained">See More</ColorButton>
                            </CardActions>
                        </Card>
                    </Grid>

                    <Grid item>
                        <Card sx={{ width: 200, height: 300, m: 2, backgroundColor: "#fffffe" }}>
                            <CardMedia
                                component="img"
                                height="130"
                                image={food}
                                alt="food"
                            />
                            <CardContent>
                                <Typography gutterBottom variant="h5" component="div">
                                African
                                </Typography>
                                <Typography variant="body1" color="text.secondary">
                                Price: $10
                                </Typography>
                                {/*  make green when Available */}
                                <Typography variant="body2" color="textSuccess">  
                                Available
                                </Typography>
                            </CardContent>
                            <CardActions>
                                {/* <ColorButton sx={{ mx:1 }} size="small" variant="contained">Add to Cart</ColorButton> */}
                                <ColorButton size="small" variant="contained">See More</ColorButton>
                            </CardActions>
                        </Card>
                    </Grid>

                    <Grid item>
                        <Card sx={{ width: 200, height: 300, m: 2, backgroundColor: "#fffffe" }}>
                            <CardMedia
                                component="img"
                                height="130"
                                image={food}
                                alt="food"
                            />
                            <CardContent>
                                <Typography gutterBottom variant="h5" component="div">
                                African
                                </Typography>
                                <Typography variant="body1" color="text.secondary">
                                Price: $10
                                </Typography>
                                {/*  make green when Available */}
                                <Typography variant="body2" color="textSuccess">  
                                Available
                                </Typography>
                            </CardContent>
                            <CardActions>
                                {/* <ColorButton sx={{ mx:1 }} size="small" variant="contained">Add to Cart</ColorButton> */}
                                <ColorButton size="small" variant="contained">See More</ColorButton>
                            </CardActions>
                        </Card>
                    </Grid>
                </Grid>
            </div>
        </>
    );
}

export default African;
