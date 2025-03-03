import { createSlice, createAsyncThunk } from "@reduxjs/toolkit";
import axios from "axios";

export const fetchMenuItemsThunk = createAsyncThunk(
  "menu/fetchAll",
  async () => {
    const categories = [
      "brownies",
      "cakepops",
      "cinnamonrolls",
      "cookies",
      "cupcakes",
    ];
    const requests = categories.map((category) =>
      axios.get(`${process.env.REACT_APP_API_BASE_URL}/${category}`)
    );

    const responses = await Promise.all(requests);
    const menu = {};

    categories.forEach((category, index) => {
      const res = responses[index];
      menu[category] = {
        data: res.data ?? {},
        status: res.status,
      };
    });

    console.log(menu);

    return menu;
  }
);

const menuSlice = createSlice({
  name: "menu",
  initialState: {
    items: {},
    status: "idle",
    error: null,
  },
  reducers: {},
  extraReducers: (builder) => {
    builder
      .addCase(fetchMenuItemsThunk.pending, (state) => {
        state.status = "loading";
      })
      .addCase(fetchMenuItemsThunk.fulfilled, (state, action) => {
        state.status = "success";
        state.items = action.payload;
      })
      .addCase(fetchMenuItemsThunk.rejected, (state, action) => {
        state.status = "fail";
        state.error = action.error.message;
        console.log(action);
      });
  },
});

export default menuSlice.reducer;
