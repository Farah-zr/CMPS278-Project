import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';
import { createTheme } from '@mui/material/styles';
import { CssBaseline, ThemeProvider } from '@mui/material';
import axios  from 'axios';

const theme = createTheme({
  palette: {
    primary: {
    // light blue
      main: '#d4d8f0',
    // white
      light: '#fffffe',
    // background
      dark: '#232946'
    },
    secondary: {
    // pink
      main: '#eebbc3',
    // dark pink
      dark: '#EF9DAA'
    },
    info: {
    // stroke
      main: '#121629',
    }
  },
});

axios.defaults.headers.common['Access-Control-Allow-Origin'] = 'https://localhost:44451';
// axios.defaults.headers.common['Access-Control-Allow-Methods'] = 'Get, Post, Delete';
// axios.defaults.headers.common['Access-Control-Allow-Headers'] = 'Origin, Content-Type, X-Auth-Token';
// axios.defaults.headers.post['Content-Type'] = 'application/x-www-form-urlencoded';

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <React.StrictMode>
    <ThemeProvider theme={theme}>
      <CssBaseline enableColorScheme />
      <App />
    </ThemeProvider>
  </React.StrictMode>
);

