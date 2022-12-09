// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Web;
// using Menu.Data;
// using CartItems.Models;

// namespace CartItems.Logic
// {
//   public class ShoppingCartActions : IDisposable
//   {
//     public string? ShoppingCartId { get; set; }

//     private AppDbContext _db;

//     public ShoppingCartActions(AppDbContext db)
//     {
//         this._db = db;
//     }

//     public const string CartSessionKey = "CartId";

//     public void AddToCart(int id)
//     {
//       // Retrieve the product from the database.           
//       var cartItem = _db.ShoppingCartItems.SingleOrDefault(c => c.MenuItemId == id);
//       if (cartItem == null)
//       {
//         // Create a new cart item if no cart item exists.                 
//         cartItem = new CartItem
//         {
//           Id = Guid.NewGuid().ToString(),
//           MenuItemId = id,
//           MenuItem = _db.MenuItems.SingleOrDefault(p => p.Id == id),
//           Quantity = 1
//         };

//         _db.ShoppingCartItems.Add(cartItem);
//       }
//       else
//       {
//         // If the item does exist in the cart,                  
//         // then add one to the quantity.                 
//         cartItem.Quantity++;
//       }
//       _db.SaveChanges();
//     }

//     public void Dispose()
//     {
//       if (_db != null)
//       {
//         _db.Dispose();
//         _db = null;
//       }
//     }

//     public List<CartItem> GetCartItems()
//     {
//       return _db.ShoppingCartItems.ToList();
//     }
//   }
// }