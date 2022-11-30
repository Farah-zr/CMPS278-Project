import React from "react";
import food from "../../img/chine.jpg";
import { Button, Card, CardActions, CardContent, CardMedia, Grid, styled, Typography } from "@mui/material";

function Chinese() {

    const ColorButton = styled(Button)(({ theme }) => ({
        color: "white",
        backgroundColor: "#f9bc60",
        '&:hover': {
          backgroundColor: "#F9CC89",
        },
      }));

    return (
        <>
            <div className="w-full mx-auto">
                <Grid container spacing={2} sx={{ m: 1, p: 2 }}> 
                    <Grid item>
                        <Card sx={{ width: 250, height: 350, m: 2, backgroundColor: "#abd1c6" }}>
                            <CardMedia
                                component="img"
                                height="170"
                                image={food}
                                alt="food"
                            />
                            <CardContent>
                                <Typography gutterBottom variant="h5" component="div">
                                Chinese
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
                                <ColorButton sx={{ mx:1 }} size="small" variant="contained">Add to Cart</ColorButton>
                                <ColorButton size="small" variant="contained">See More</ColorButton>
                            </CardActions>
                        </Card>
                    </Grid>

                    <Grid item>
                        <Card sx={{ width: 250, height: 350, m: 2, backgroundColor: "#abd1c6" }}>
                            <CardMedia
                                component="img"
                                height="170"
                                image={food}
                                alt="food"
                            />
                            <CardContent>
                                <Typography gutterBottom variant="h5" component="div">
                                Chinese
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
                                <ColorButton sx={{ mx:1 }} size="small" variant="contained">Add to Cart</ColorButton>
                                <ColorButton size="small" variant="contained">See More</ColorButton>
                            </CardActions>
                        </Card>
                    </Grid>

                    <Grid item>
                        <Card sx={{ width: 250, height: 350, m: 2, backgroundColor: "#abd1c6" }}>
                            <CardMedia
                                component="img"
                                height="170"
                                image={food}
                                alt="food"
                            />
                            <CardContent>
                                <Typography gutterBottom variant="h5" component="div">
                                Chinese
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
                                <ColorButton sx={{ mx:1 }} size="small" variant="contained">Add to Cart</ColorButton>
                                <ColorButton size="small" variant="contained">See More</ColorButton>
                            </CardActions>
                        </Card>
                    </Grid>

                    <Grid item>
                        <Card sx={{ width: 250, height: 350, m: 2, backgroundColor: "#abd1c6" }}>
                            <CardMedia
                                component="img"
                                height="170"
                                image={food}
                                alt="food"
                            />
                            <CardContent>
                                <Typography gutterBottom variant="h5" component="div">
                                Chinese
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
                                <ColorButton sx={{ mx:1 }} size="small" variant="contained">Add to Cart</ColorButton>
                                <ColorButton size="small" variant="contained">See More</ColorButton>
                            </CardActions>
                        </Card>
                    </Grid>

                    <Grid item>
                        <Card sx={{ width: 250, height: 350, m: 2, backgroundColor: "#abd1c6" }}>
                            <CardMedia
                                component="img"
                                height="170"
                                image={food}
                                alt="food"
                            />
                            <CardContent>
                                <Typography gutterBottom variant="h5" component="div">
                                Chinese
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
                                <ColorButton sx={{ mx:1 }} size="small" variant="contained">Add to Cart</ColorButton>
                                <ColorButton size="small" variant="contained">See More</ColorButton>
                            </CardActions>
                        </Card>
                    </Grid>
                </Grid>
            </div>
        </>
    );
}

export default Chinese;
