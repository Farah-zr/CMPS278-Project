import React from "react";
import "../../assets/styles/foodContainer.css";
import { Box, Grid, styled, Tabs } from "@mui/material";
import Tab from "@mui/material/Tab";
import CakePops from "./CakePops";
import Brownies from "./Brownies";
import CinnamonRolls from "./CinnamonRolls";
import Cookies from "./Cookies";
import Cupcakes from "./Cupcakes";
import { useSelector } from "react-redux";
import ItemCard from "../ItemCard";

function FoodContainer() {
  const CustomizedTabs = styled(Tabs)({
    "& .MuiTabs-indicator": {
      backgroundColor: "#EF9DAA",
    },
  });

  const CustomizedTab = styled((props) => <Tab disableRipple {...props} />)(
    ({ theme }) => ({
      textTransform: "none",
      minWidth: 0,
      [theme.breakpoints.up("sm")]: {
        minWidth: 0,
      },
      fontWeight: theme.typography.fontWeightRegular,
      marginRight: theme.spacing(1),
      color: "#121629",
      "&:hover": {
        color: "#EF9DAA",
        opacity: 1,
      },
      "&.Mui-selected": {
        color: "#EF9DAA",
        fontWeight: theme.typography.fontWeightMedium,
      },
      "&.Mui-focusVisible": {
        backgroundColor: "#abd1c6",
      },
    })
  );

  const [category, setCategory] = React.useState(0);
  const { items, status, error } = useSelector((state) => state.menu);

  const handleChange = (event, newValue) => {
    setCategory(newValue);
  };

  return (
    <>
      <div className="foodcontainer">
        <Box className="left-side">
          <Box sx={{ borderBottom: 1, borderColor: "divider" }}>
            <CustomizedTabs value={category} onChange={handleChange} centered>
              <CustomizedTab label="Brownies" />
              <CustomizedTab label="Cake Pops" />
              <CustomizedTab label="Cinnamon Rolls" />
              <CustomizedTab label="Cookies" />
              <CustomizedTab label="Cupcakes" />
            </CustomizedTabs>
          </Box>

          {(status === "loading" || status === "idle") && (
            <p className="text-lg">loading..</p>
          )}

          {status === "success" && (
            <div>
              {category === 0 && (
                <div className="flex gap-2">
                  {items.brownies.status === 200 && (
                    <Grid container spacing={1} sx={{ px: 2, py: 1 }}>
                      {items.brownies.data.map((item) => {
                        return (
                          <Grid item>
                            <ItemCard item={item} category="brownies" />
                            {/* handleClickOpen={handleClickOpen} */}
                          </Grid>
                        );
                      })}
                    </Grid>
                  )}
                </div>
              )}
              {category === 1 && (
                <div className="flex gap-2">
                  {items.cakepops.status === 200 && (
                    <Grid container spacing={1} sx={{ px: 2, py: 1 }}>
                      {items.cakepops.data.map((item) => {
                        return (
                          <Grid item>
                            <ItemCard item={item} category="cakepops" />
                            {/* handleClickOpen={handleClickOpen} */}
                          </Grid>
                        );
                      })}
                    </Grid>
                  )}
                </div>
              )}
              {category === 2 && (
                <div className="flex gap-2">
                  {items.cinnamonrolls.status === 200 && (
                    <Grid container spacing={1} sx={{ px: 2, py: 1 }}>
                      {items.cinnamonrolls.data.map((item) => {
                        return (
                          <Grid item>
                            <ItemCard item={item} category="cinnamonrolls" />
                            {/* handleClickOpen={handleClickOpen} */}
                          </Grid>
                        );
                      })}
                    </Grid>
                  )}
                </div>
              )}
              {category === 3 && (
                <div className="flex gap-2">
                  {items.cookies.status === 200 && (
                    <Grid container spacing={1} sx={{ px: 2, py: 1 }}>
                      {items.cookies.data.map((item) => {
                        return (
                          <Grid item>
                            <ItemCard item={item} category="cookies" />
                            {/* handleClickOpen={handleClickOpen} */}
                          </Grid>
                        );
                      })}
                    </Grid>
                  )}
                </div>
              )}
              {category === 4 && (
                <div className="flex gap-2">
                  {items.cupcakes.status === 200 && (
                    <Grid container spacing={1} sx={{ px: 2, py: 1 }}>
                      {items.cupcakes.data.map((item) => {
                        return (
                          <Grid item>
                            <ItemCard item={item} category="cupcakes" />
                            {/* handleClickOpen={handleClickOpen} */}
                          </Grid>
                        );
                      })}
                    </Grid>
                  )}
                </div>
              )}
            </div>
          )}
        </Box>
      </div>
    </>
  );
}

export default FoodContainer;
