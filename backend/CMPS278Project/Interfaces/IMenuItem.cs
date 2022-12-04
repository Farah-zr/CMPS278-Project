using MenuItems.Models;

namespace MenuItems.Interfaces;

public interface IMenuItems
{
    Task<List<MenuItem>> GetMenuItemsAsync();
    Task<MenuItem?> GetByIdAsync(int id); // Car? meaning we may return null
    Task<MenuItem?> GetByCategoryAsync(string category);
    Task<MenuItem?> AddMenuItemAsync(MenuItem menuItem);
    Task<bool> DeleteMenuItemAsync(int id);
    Task<MenuItem?> UpdateMenuItemAsync(MenuItem menuItem, int id);
}