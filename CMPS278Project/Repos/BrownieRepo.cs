using Menu.Data;
using BrowniesRepo.Interfaces;
using Brownies.Models;
using Microsoft.EntityFrameworkCore;

namespace Brownies.Repos;

public class BrownieRepo : IBrownieRepo
{
    private readonly AppDbContext _db;

    public BrownieRepo(AppDbContext db)
    {
        this._db = db;
    }
    public async Task<Brownie?> AddBrownieAsync(Brownie brownie)
    {
       _db.Brownies.Add(brownie); 
        var success = await _db.SaveChangesAsync() > 0; 
        if (!success)
            return null;
        return brownie;
    }

    public async Task<bool> DeleteBrownieAsync(int id)
    {
        var brownie = await _db.Brownies.FirstOrDefaultAsync(x => x.Id == id);
        
        if (brownie == null)
            return false;
        
        _db.Brownies.Remove(brownie);
        
        var success = await _db.SaveChangesAsync() > 0;
        if (!success)
            return false;
        return true;
    }

    public async Task<Brownie?> GetByIdAsync(int id)
    {
        var brownie = await _db.Brownies.FirstOrDefaultAsync(x => x.Id == id);
        if (brownie != null)
            return brownie;
        return null;
    }

    public async Task<List<Brownie>> GetBrowniesAsync()
    {
        return await _db.Brownies.ToListAsync();
    }

    public async Task<Brownie?> UpdateBrownieAsync(Brownie brownie, int id)
    {
        var brownieToBeUpdated = await GetByIdAsync(id);
        
        if (brownieToBeUpdated == null) return null;

        brownieToBeUpdated.Description = brownie.Description;
        brownieToBeUpdated.Name = brownie.Name;
        brownieToBeUpdated.Price = brownie.Price;

        return brownieToBeUpdated;
    }
}