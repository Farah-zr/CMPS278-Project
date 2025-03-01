import {
  Button,
  Card,
  CardActionArea,
  CardActions,
  CardContent,
  CardMedia,
  IconButton,
  Typography,
} from "@mui/material";
import ChevronRightIcon from "@mui/icons-material/ChevronRight";

function ItemCard(props) {
  return (
    <Card className="w-[200px] h-[240px] m-1 bg-secondary">
      <CardActionArea
        button-key={props.item.id}
        onClick={(e) => props.handleClickOpen(e)}
        className="h-full"
      >
        <CardMedia
          component="img"
          height="130"
          image={require("../img/allMenuItems/" + props.item.id + ".jpg")}
          alt="food"
        />
        <CardContent className="p-2">
          <Typography
            gutterBottom
            variant="h6"
            className="text-[16px] overflow-ellipsis text-primary font-semibold capitalize"
          >
            {props.item.name}
          </Typography>
          <Typography
            variant="body1"
            className="text-[14px] text-peach font-semibold"
          >
            $ {props.item.price} <span className="text-melon">/ piece</span>
          </Typography>
        </CardContent>
        <CardActions
          sx={{
            display: "flex",
            justifyContent: "flex-end",
          }}
        >
          <IconButton
            button-key={props.item.id}
            onClick={(e) => props.handleClickOpen(e)}
            size="small"
            aria-label="arrow"
            className="text-peach"
          >
            <ChevronRightIcon />
          </IconButton>
        </CardActions>
      </CardActionArea>
    </Card>
  );
}

export default ItemCard;
