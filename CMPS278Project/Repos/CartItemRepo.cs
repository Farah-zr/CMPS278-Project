using Menu.Data;
using CartItemsRepo.Interfaces;
using CartItems.Models;
using Microsoft.EntityFrameworkCore;

namespace CartItems.Repos;

public class CartItemRepo : ICartItemRepo
{
    private readonly AppDbContext _db;

    public CartItemRepo(AppDbContext db)
    {
        this._db = db;
    }
    public async Task<CartItem?> AddCartItemAsync(CartItem CartItem)
    {
        var cartItem = await _db.CartItems.FirstOrDefaultAsync(c => c.MenuItemId == CartItem.MenuItemId);
        if (cartItem == null)
        {
            _db.CartItems.Add(CartItem);
        }
        else
        {                
            cartItem.Quantity++;
        }

        var success = await _db.SaveChangesAsync() > 0; 
        if (!success)
            return null;
        return CartItem;
    }

    public async Task<bool> DeleteCartItemAsync(int id)
    {
        var CartItem = await _db.CartItems.FirstOrDefaultAsync(x => x.Id == id);
        
        if (CartItem == null)
            return false;
        
        _db.CartItems.Remove(CartItem);
        
        var success = await _db.SaveChangesAsync() > 0;
        if (!success)
            return false;
        return true;
    }

    public async Task<CartItem?> GetByIdAsync(int id)
    {
        var CartItem = await _db.CartItems.FirstOrDefaultAsync(x => x.Id == id);
        if (CartItem != null)
            return CartItem;
        return null;
    }

    public async Task<List<CartItem>> GetCartItemsAsync()
    {
        return await _db.CartItems.ToListAsync();
    }
}