import React from "react";
import "../styles/foodContainer.css";
import Cart from "../cart/Cart";
import { Box, styled, Tabs } from "@mui/material";
import Tab from '@mui/material/Tab';
import African from "./African";
import Chinese from "./Chinese";
import Italian from "./Italian";


function FoodContainer() {

  const CustomizedTabs = styled(Tabs)({
    '& .MuiTabs-indicator': {
      backgroundColor: "#EF9DAA",
    },
  });

  const CustomizedTab = styled((props) => <Tab disableRipple {...props} />)(({ theme }) => ({
    textTransform: 'none',
    minWidth: 0,
    [theme.breakpoints.up('sm')]: {
      minWidth: 0,
    },
    fontWeight: theme.typography.fontWeightRegular,
    marginRight: theme.spacing(1),
    color: '#121629',
    '&:hover': {
      color: '#EF9DAA',
      opacity: 1,
    },
    '&.Mui-selected': {
      color: '#EF9DAA',
      fontWeight: theme.typography.fontWeightMedium,
    },
    '&.Mui-focusVisible': {
      backgroundColor: '#abd1c6',
    },
  }));

  const [category, setCategory] = React.useState(0);

  const handleChange = (event, newValue) => {
    setCategory(newValue);
  };

  return (
    <>
      <div className="foodcontainer">
        <Box className="left-side">
            <Box sx={{ borderBottom: 1, borderColor: 'divider' }}>
              <CustomizedTabs value={category} onChange={handleChange} centered>
                <CustomizedTab label="Cake Pops" />
                <CustomizedTab label="Brownies" />
                <CustomizedTab label="Macarons" />
                <CustomizedTab label="Cinnamon Rolls" />
                <CustomizedTab label="Cinnamon Bites" />
                <CustomizedTab label="Cookies" />
                <CustomizedTab label="Cupcakes" />
                <CustomizedTab label="Pretzels" />
              </CustomizedTabs>
            </Box>

            <div>
              {
                category === 0 && <African />
              }
              {
                category === 1 && <Chinese />
              }
              {
                category === 2 && <Italian />
              }
            </div>
        </Box>

        <div className="right-side">
          <Cart />
        </div>
      </div>
    </>
  );
}

export default FoodContainer;
