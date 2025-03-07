import React from "react";
import "../assets/styles/foodContainer.css";
import { Box, Skeleton, styled, Tabs } from "@mui/material";
import Tab from "@mui/material/Tab";
import { useSelector } from "react-redux";
import ItemCard from "./ItemCard";

function FoodContainer() {
  const CustomizedTabs = styled((props) => <Tabs {...props} />)({
    "& .MuiTabs-indicator": {
      backgroundColor: "var(--peach)",
      bottom: "10px",
    },
  });

  const CustomizedTab = styled((props) => <Tab disableRipple {...props} />)(
    () => ({
      textTransform: "none",
      padding: "12px 0",
      margin: "0 8px",
      fontSize: "17px",
      minWidth: 0,
      fontWeight: "600",
      color: "var(--melon)",
      "&:hover": {
        color: "var(--primary)",
      },
      "&.Mui-selected": {
        color: "var(--peach)",
      },
    })
  );

  const [category, setCategory] = React.useState(0);
  const { items, status } = useSelector((state) => state.menu);

  const handleChange = (event, newValue) => {
    setCategory(newValue);
  };

  return (
    <>
      <div className="menu-container mt-8 w-full h-full">
        <Box className="w-full h-full">
          <Box>
            <CustomizedTabs value={category} onChange={handleChange} centered>
              <CustomizedTab label="Brownies" />
              <CustomizedTab label="Cake Pops" />
              <CustomizedTab label="Cinnamon Rolls" />
              <CustomizedTab label="Cookies" />
              <CustomizedTab label="Cupcakes" />
            </CustomizedTabs>
          </Box>

          <div className="py-4 flex justify-center max-h-[calc(100%-48px)]">
            {status !== "success" && ( //
              // (status === "loading" || status === "idle")
              <div className="grid md:grid-cols-2 grid-cols-1 gap-4 w-full">
                {Array.from({ length: 6 }).map((_, index) => (
                  <Skeleton
                    key={index}
                    variant="rectangular"
                    width="100%"
                    height={150}
                  />
                ))}
              </div>
            )}

            {status === "success" && (
              <div className="overflow-y-auto overflow-x-hidden scroll w-full px-2 mb-5 min-h-0 max-h-full h-[calc(100vh-180px)]">
                {category === 0 && (
                  <>
                    {items.brownies.status === 200 && (
                      <div className="grid md:grid-cols-2 grid-cols-1 gap-4 w-full">
                        {items.brownies.data.map((item) => {
                          return (
                            <div className="w-[calc(100%)]">
                              <ItemCard item={item} category="brownies" />
                            </div>
                          );
                        })}
                      </div>
                    )}
                  </>
                )}
                {category === 1 && (
                  <>
                    {items.cakepops.status === 200 && (
                      <div className="grid md:grid-cols-2 grid-cols-1 gap-4">
                        {items.cakepops.data.map((item) => {
                          return (
                            <div className="w-[calc(100%)]">
                              <ItemCard item={item} category="cakepops" />
                            </div>
                          );
                        })}
                      </div>
                    )}
                  </>
                )}
                {category === 2 && (
                  <>
                    {items.cinnamonrolls.status === 200 && (
                      <div className="grid md:grid-cols-2 grid-cols-1 gap-4">
                        {items.cinnamonrolls.data.map((item) => {
                          return (
                            <div className="w-[calc(100%)]">
                              <ItemCard item={item} category="cinnamonrolls" />
                              {/* handleClickOpen={handleClickOpen} */}
                            </div>
                          );
                        })}
                      </div>
                    )}
                  </>
                )}
                {category === 3 && (
                  <>
                    {items.cookies.status === 200 && (
                      <div className="grid md:grid-cols-2 grid-cols-1 gap-4">
                        {items.cookies.data.map((item) => {
                          return (
                            <div className="w-[calc(100%)]">
                              <ItemCard item={item} category="cookies" />
                              {/* handleClickOpen={handleClickOpen} */}
                            </div>
                          );
                        })}
                      </div>
                    )}
                  </>
                )}
                {category === 4 && (
                  <>
                    {items.cupcakes.status === 200 && (
                      <div className="grid md:grid-cols-2 grid-cols-1 gap-4">
                        {items.cupcakes.data.map((item) => {
                          return (
                            <div className="w-[calc(100%)]">
                              <ItemCard item={item} category="cupcakes" />
                            </div>
                          );
                        })}
                      </div>
                    )}
                  </>
                )}
              </div>
            )}
          </div>
        </Box>
      </div>
    </>
  );
}

export default FoodContainer;
