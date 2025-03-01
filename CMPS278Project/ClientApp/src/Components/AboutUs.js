import { Box, Typography } from "@mui/material";
import SideBar from "./SideBar";
import "./styles/aboutus.css";

const AboutUs = () => {
  return (
    <>
      {" "}
      <SideBar />
      <div className="bgimg">
        <div className="coming-soon-container">
          <Box className="bg-white opacity-70 w-[500px] h-[250px] p-[16px]">
            <Typography variant="h5" sx={{ color: "#121629", mb: 1 }}>
              Sweet Treats is a fun & vibrant bake shop that offers a wide range
              of baked goods that fit any occasion!
            </Typography>
            <Typography variant="body1" sx={{ color: "#121629", fontSize: 15 }}>
              Tel: +961 1 366 666
            </Typography>
            <Typography variant="body1" sx={{ color: "#121629", fontSize: 15 }}>
              Mobile: +961 76 767676
            </Typography>
            <Typography variant="body1" sx={{ color: "#121629", fontSize: 15 }}>
              Address: Clemenceau, Beirut - Lebanon
            </Typography>
            <Typography variant="body1" sx={{ color: "#121629", fontSize: 15 }}>
              Email: contact@sweet-treats.com
            </Typography>
          </Box>
        </div>
      </div>
    </>
  );
};

export default AboutUs;
