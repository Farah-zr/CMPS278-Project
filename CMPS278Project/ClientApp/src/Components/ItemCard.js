import {
  Card,
  CardActionArea,
  CardContent,
  CardMedia,
  // IconButton,
  Typography,
} from "@mui/material";
import ChevronRightIcon from "@mui/icons-material/ChevronRight";

function ItemCard(props) {
  return (
    <Card className="w-[200px] h-[226px] m-1 bg-secondary">
      <CardActionArea
        button-key={props.item.id}
        onClick={(e) => props.handleClickOpen(e)}
        className="h-full"
      >
        <CardMedia
          component="img"
          height="150"
          image={require(`../assets/images/${props.category}/${props.item.id}.jpg`)}
          alt="food"
        />
        <CardContent className="p-2 flex flex-col gap-2">
          <Typography
            gutterBottom
            variant="h6"
            className="text-[16px] mb-0 h-[26px] overflow-hidden text-ellipsis truncate text-primary font-semibold capitalize"
          >
            {props.item.name}
          </Typography>
          <div className="flex justify-between items-center">
            <Typography
              variant="body1"
              className="text-[16px] text-peach h-[20px] font-semibold"
            >
              ${props.item.price}{" "}
              <span className="text-melon text-[13px]">/ piece</span>
            </Typography>

            {/* <IconButton
              button-key={props.item.id}
              onClick={(e) => props.handleClickOpen(e)}
              size="small"
              aria-label="arrow"
              className="text-peach p-0"
            > */}
            <ChevronRightIcon className="text-peach size-6 p-0" />
            {/* </IconButton> */}
          </div>
        </CardContent>
      </CardActionArea>
    </Card>
  );
}

export default ItemCard;
