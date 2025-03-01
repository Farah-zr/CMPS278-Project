using MenuItem.Interfaces;

namespace MenuItemsRepo.Interfaces;

public interface IMenuItemRepo<T> where T : class
{
    Task<List<T>> GetItemsAsync();
    Task<T?> GetByIdAsync(int id);
    Task<T> AddItemAsync(T menuItem);
    Task<bool> DeleteItemAsync(int id);
    Task<T?> UpdateItemAsync(T menuItem, int id);
}