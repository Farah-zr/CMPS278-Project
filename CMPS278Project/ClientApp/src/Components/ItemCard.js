import {
  Box,
  Button,
  Card,
  CardActionArea,
  CardContent,
  CardMedia,
  Divider,
  Drawer,
  styled,
  TextField,
} from "@mui/material";
import React from "react";

function ItemCard(props) {
  const InstructionsTextarea = styled(TextField)(() => ({
    size: "small",
    margin: "8px 0",
    "& label": {
      fontSize: "15px",
      // color: "var(--peach)",
    },
    "& label.Mui-focused": {
      color: "var(--peach)",
    },
    "& .MuiOutlinedInput-root": {
      "& fieldset": {
        // borderColor: "var(--peach)",
        borderSize: "2px",
      },
      "&:hover fieldset": {
        borderColor: "var(--peach)",
      },
      "&.Mui-focused fieldset": {
        borderColor: "var(--peach)",
      },
    },
  }));

  const ColoredButton = styled(Button)(() => ({
    textTransform: "none",
    color: "white",
    backgroundColor: "var(--melon)",
    "&:hover": {
      backgroundColor: "var(--primary)",
    },
  }));

  const [open, setOpen] = React.useState(false);
  const [quantity, setQuantity] = React.useState(1);
  const [id, setId] = React.useState(0);

  const handleClickOpen = (id) => {
    setOpen(true);
    setId(id);
  };

  const handleClose = () => {
    setOpen(false);
    setQuantity(1);
  };

  // Increase Quantity
  const AddQuantity = (e) => {
    e.preventDefault();
    setQuantity((quantity) => quantity + 1);
  };

  // Decrease Quantity
  const DecreaseQuantity = () => {
    if (quantity > 0) {
      setQuantity((quantity) => quantity - 1);
    }
  };

  const ItemDetials = (
    <Box
      sx={{ width: 380 }}
      className="flex flex-col justify-between h-full overflow-y-auto scroll"
    >
      <div>
        <div className="w-full bg-background">
          <img
            src={require(`../assets/images/${props.category}/${props.item.id}.jpg`)}
            alt={props.category}
            className="w-full p-4 rounded-md"
          />
        </div>
        <div className="p-4 grid gap-2">
          <div className="flex justify-between text-[18px]">
            <p className="text-primary w-[calc(100%-100px)]">
              {props.item.name}
            </p>
            <p className="text-peach">
              ${props.item.price}{" "}
              <span className="text-pale-dogwood text-[14px]">/ piece</span>
            </p>
          </div>
          <p className="text-[15px] text-melon mb-4">
            {props.item.description}
          </p>
          <Divider light />
          <InstructionsTextarea
            id="instructions"
            label="Any special instructions?"
            type="text"
            fullWidth
            variant="outlined"
            size="small"
          />
          <Divider light />
          <div className="flex justify-center items-center">
            <div className="flex items-center">
              <button
                className="outline-none p-1 w-fit h-[40px] text-[18px] text-melon bg-transparent border-0 cursor-pointer hover:text-primary"
                onClick={DecreaseQuantity}
              >
                &ndash;
              </button>
              <input
                className="p-3 text-[16px] border-0 w-[100px] text-center disabled:bg-transparent disabled:opacity-100"
                type="text"
                value={quantity}
                readOnly
                disabled
              />
              <button
                className="outline-none p-1 w-fit h-[40px] text-[18px] text-melon bg-transparent border-0 cursor-pointer hover:text-primary"
                onClick={AddQuantity}
              >
                &#xff0b;
              </button>
            </div>
          </div>
          {/* <Divider light /> */}
        </div>
      </div>

      <div className="flex justify-between p-4 ">
        <ColoredButton onClick={handleClose}>Close</ColoredButton>
        <ColoredButton>Add to Cart</ColoredButton>
      </div>
    </Box>
  );

  return (
    <>
      <Card className="w-full h-[150px] bg-white">
        <CardActionArea
          button-key={props.item.id}
          onClick={() => handleClickOpen(props.item.id)}
          className="h-full flex"
        >
          <CardContent className="w-[calc(100%-200px)] h-full p-4 flex flex-col justify-start gap-2">
            <div className="h-[calc(100%-30px)]">
              <p className="text-[20px] truncate text-primary capitalize mb-3">
                {props.item.name}
              </p>
              <p className="text-[15px] text-wrap line-clamp-2 text-pale-dogwood font-light">
                {props.item.description ?? ""}
              </p>
            </div>

            <div className="flex justify-between items-center">
              <p className="text-[18px] text-peach h-[20px] font-semibold">
                ${props.item.price}{" "}
                <span className="text-pale-dogwood text-[14px] font-normal">
                  / piece
                </span>
              </p>
            </div>
          </CardContent>
          <CardMedia
            component="img"
            height="180"
            image={require(`../assets/images/${props.category}/${props.item.id}.jpg`)}
            alt={props.category}
            className="w-[200px] h-full"
          />
        </CardActionArea>
      </Card>

      <Drawer open={open} onClose={handleClose} anchor="right">
        {ItemDetials}
      </Drawer>
    </>
  );
}

export default ItemCard;
