using Menu.Data;
using CakePopsRepo.Interfaces;
using CakePops.Models;
using Microsoft.EntityFrameworkCore;

namespace CakePops.Repos;

public class CakePopRepo : ICakePopRepo
{
    private readonly AppDbContext _db;

    public CakePopRepo(AppDbContext db)
    {
        this._db = db;
    }
    public async Task<CakePop?> AddCakePopAsync(CakePop cakePop)
    {
       _db.CakePops.Add(cakePop); 
        var success = await _db.SaveChangesAsync() > 0; 
        if (!success)
            return null;
        return cakePop;
    }

    public async Task<bool> DeleteCakePopAsync(int id)
    {
        var cakePop = await _db.CakePops.FirstOrDefaultAsync(x => x.Id == id);
        
        if (cakePop == null)
            return false;
        
        _db.CakePops.Remove(cakePop);
        
        var success = await _db.SaveChangesAsync() > 0;
        if (!success)
            return false;
        return true;
    }

    public async Task<CakePop?> GetByIdAsync(int id)
    {
        var cakePop = await _db.CakePops.FirstOrDefaultAsync(x => x.Id == id);
        if (cakePop != null)
            return cakePop;
        return null;
    }

    public async Task<List<CakePop>> GetCakePopsAsync()
    {
        return await _db.CakePops.ToListAsync();
    }

    public async Task<CakePop?> UpdateCakePopAsync(CakePop cakePop, int id)
    {
        var cakePopToBeUpdated = await GetByIdAsync(id);
        
        if (cakePopToBeUpdated == null) return null;

        cakePopToBeUpdated.Description = cakePop.Description;
        cakePopToBeUpdated.Name = cakePop.Name;
        cakePopToBeUpdated.Price = cakePop.Price;

        return cakePopToBeUpdated;
    }
}