using Menu.Data;
using Microsoft.EntityFrameworkCore;
using MenuItemsRepo.Interfaces;
using MenuItem.Interfaces;

namespace MenuItems.Repos;

public class MenuItemRepo<T> : IMenuItemRepo<T> where T : class
{
    private readonly AppDbContext _db;
    private readonly DbSet<T> _dbSet;

    public MenuItemRepo(AppDbContext db)
    {
        _db = db;
        _dbSet = db.Set<T>();
    }

    public async Task<T?> AddItemAsync(T menuItem)
    {
        _dbSet.Add(menuItem);
        var success = await _db.SaveChangesAsync() > 0;
        return success ? menuItem : null;
    }

    public async Task<bool> DeleteItemAsync(int id)
    {
        var item = await _dbSet.FindAsync(id);
        if (item == null) return false;

        _dbSet.Remove(item);
        return await _db.SaveChangesAsync() > 0;
    }

    public async Task<T?> GetByIdAsync(int id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task<List<T>> GetItemsAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task<T?> UpdateItemAsync(T menuItem, int id)
    {
        var existingItem = await _dbSet.FindAsync(id);
        if (existingItem == null) return null;

        _db.Entry(existingItem).CurrentValues.SetValues(menuItem);
        await _db.SaveChangesAsync();
        return existingItem;
    }
}
