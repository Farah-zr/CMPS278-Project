using Menu.Data;
using CinnamonRollsRepo.Interfaces;
using CinnamonRolls.Models;
using Microsoft.EntityFrameworkCore;

namespace CinnamonRolls.Repos;

public class CinnamonRollRepo : ICinnamonRollRepo
{
    private readonly AppDbContext _db;

    public CinnamonRollRepo(AppDbContext db)
    {
        this._db = db;
    }
    public async Task<CinnamonRoll?> AddCinnamonRollAsync(CinnamonRoll CinnamonRoll)
    {
       _db.CinnamonRolls.Add(CinnamonRoll); 
        var success = await _db.SaveChangesAsync() > 0; 
        if (!success)
            return null;
        return CinnamonRoll;
    }

    public async Task<bool> DeleteCinnamonRollAsync(int id)
    {
        var CinnamonRoll = await _db.CinnamonRolls.FirstOrDefaultAsync(x => x.Id == id);
        
        if (CinnamonRoll == null)
            return false;
        
        _db.CinnamonRolls.Remove(CinnamonRoll);
        
        var success = await _db.SaveChangesAsync() > 0;
        if (!success)
            return false;
        return true;
    }

    public async Task<CinnamonRoll?> GetByIdAsync(int id)
    {
        var CinnamonRoll = await _db.CinnamonRolls.FirstOrDefaultAsync(x => x.Id == id);
        if (CinnamonRoll != null)
            return CinnamonRoll;
        return null;
    }

    public async Task<List<CinnamonRoll>> GetCinnamonRollsAsync()
    {
        return await _db.CinnamonRolls.ToListAsync();
    }

    public async Task<CinnamonRoll?> UpdateCinnamonRollAsync(CinnamonRoll CinnamonRoll, int id)
    {
        var CinnamonRollToBeUpdated = await GetByIdAsync(id);
        
        if (CinnamonRollToBeUpdated == null) return null;

        CinnamonRollToBeUpdated.Description = CinnamonRoll.Description;
        CinnamonRollToBeUpdated.Name = CinnamonRoll.Name;
        CinnamonRollToBeUpdated.Price = CinnamonRoll.Price;

        return CinnamonRollToBeUpdated;
    }
}