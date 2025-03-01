import React from "react";
import ReactDOM from "react-dom/client";
import "./index.css";
import "./theme.scss";
import App from "./App";
import { createTheme } from "@mui/material/styles";
import {
  CssBaseline,
  StyledEngineProvider,
  ThemeProvider,
} from "@mui/material";
import axios from "axios";

// const theme = createTheme({
//   palette: {
//     primary: {
//       // light blue
//       main: "#d4d8f0",
//       // white
//       light: "#fffffe",
//       // background
//       dark: "#232946",
//     },
//     secondary: {
//       // pink
//       main: "#eebbc3",
//       // dark pink
//       dark: "#EF9DAA",
//     },
//     info: {
//       // stroke
//       main: "#121629",
//     },
//   },
// });

axios.defaults.headers.common["Access-Control-Allow-Origin"] = "*";
axios.defaults.headers.common["Access-Control-Allow-Methods"] = "*";
axios.defaults.headers.common["Access-Control-Allow-Headers"] = "*";

const rootElement = document.getElementById("root");
const root = ReactDOM.createRoot(rootElement);

const theme = createTheme({
  components: {
    MuiPopover: {
      defaultProps: {
        container: rootElement,
      },
    },
    MuiPopper: {
      defaultProps: {
        container: rootElement,
      },
    },
    MuiDialog: {
      defaultProps: {
        container: rootElement,
      },
    },
    MuiModal: {
      defaultProps: {
        container: rootElement,
      },
    },
  },
});

// root.render(
//   <React.StrictMode>
//     <ThemeProvider theme={theme}>
//       <CssBaseline enableColorScheme />
//       <App />
//     </ThemeProvider>
//   </React.StrictMode>
// );

root.render(
  <StyledEngineProvider injectFirst>
    <ThemeProvider theme={theme}>
      <App />
    </ThemeProvider>
  </StyledEngineProvider>
);
