using Menu.Data;
using MenuItemsRepo.Interfaces;
using MenuItems.Models;
using Microsoft.EntityFrameworkCore;
using CategoryEnum.Enums;

namespace MenuItems.Repos;

public class MenuItemRepo : IMenuItemRepo
{
    private readonly AppDbContext _db;

    public MenuItemRepo(AppDbContext db)
    {
        this._db = db;
    }
    public async Task<MenuItem?> AddMenuItemAsync(MenuItem menuItem)
    {
       _db.MenuItems.Add(menuItem); 
        var success = await _db.SaveChangesAsync() > 0; 
        if (!success)
            return null;
        return menuItem;
    }

    public async Task<bool> DeleteMenuItemAsync(int id)
    {
        var menuItem = await _db.MenuItems.FirstOrDefaultAsync(x => x.Id == id);
        
        if (menuItem == null)
            return false;
        
        _db.MenuItems.Remove(menuItem);
        
        var success = await _db.SaveChangesAsync() > 0;
        if (!success)
            return false;
        return true;
    }

    public async Task<MenuItem?> GetByIdAsync(int id)
    {
        var menuItem = await _db.MenuItems.FirstOrDefaultAsync(x => x.Id == id);
        if (menuItem != null)
            return menuItem;
        return null;
    }

    public async Task<List<MenuItem>> GetMenuItemsAsync()
    {
        return await _db.MenuItems.ToListAsync();
    }

    public async Task<MenuItem?> UpdateMenuItemAsync(MenuItem menuItem, int id)
    {
        var menuItemToBeUpdated = await GetByIdAsync(id);
        
        if (menuItemToBeUpdated == null) return null;

        menuItemToBeUpdated.Category = menuItem.Category;
        menuItemToBeUpdated.Description = menuItem.Description;
        menuItemToBeUpdated.Name = menuItem.Name;
        menuItemToBeUpdated.Price = menuItem.Price;

        return menuItemToBeUpdated;
    }
}