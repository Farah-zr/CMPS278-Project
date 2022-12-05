using MenuItems.Models;
using CategoryEnum.Enums;

namespace MenuItemsRepo.Interfaces;

public interface IMenuItemRepo
{
    Task<List<MenuItem>> GetMenuItemsAsync();
    Task<MenuItem?> GetByIdAsync(int id); 
    Task<MenuItem?> AddMenuItemAsync(MenuItem menuItem);
    Task<bool> DeleteMenuItemAsync(int id);
    Task<MenuItem?> UpdateMenuItemAsync(MenuItem menuItem, int id);
}