using System.ComponentModel.DataAnnotations;
using MenuItems.Models;

namespace CartItems.Models
{
    public class CartItem
    {
        [Key]
        public int Id { get; set; }

        // public string CartId { get; set; }

        public int Quantity { get; set; }

        // public System.DateTime DateCreated { get; set; }

        public int MenuItemId { get; set; }

        // public MenuItem MenuItem { get; set; } = null!;

    }
}