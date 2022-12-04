import React from "react";
import food from "../../img/chine.jpg";
import { Button, Card, CardActions, CardContent, CardMedia, Grid, styled, Typography } from "@mui/material";

function Italian() {

    const ColorButton = styled(Button)(({ theme }) => ({
        color: "black",
        backgroundColor: "#eebbc3",
        '&:hover': {
          backgroundColor: "#EF9DAA",
        },
      }));

    return (
        <>
            <div className="w-full mx-auto">
                <Grid container spacing={1} sx={{ p: 1 }}> 
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
                                Italian
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
                                Italian
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
                                Italian
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
                                Italian
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
                                Italian
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

export default Italian;