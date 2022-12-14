using CartItems.Models;

namespace CartItemsRepo.Interfaces;

public interface ICartItemRepo
{
    Task<List<CartItem>> GetCartItemsAsync();
    Task<CartItem?> GetByIdAsync(int id); 
    Task<CartItem?> AddCartItemAsync(CartItem CartItem);
    Task<bool> DeleteCartItemAsync(int id);
}