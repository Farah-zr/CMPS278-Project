using Menu.Data;
using CupcakesRepo.Interfaces;
using Cupcakes.Models;
using Microsoft.EntityFrameworkCore;

namespace Cupcakes.Repos;

public class CupcakeRepo : ICupcakeRepo
{
    private readonly AppDbContext _db;

    public CupcakeRepo(AppDbContext db)
    {
        this._db = db;
    }
    public async Task<Cupcake?> AddCupcakeAsync(Cupcake Cupcake)
    {
       _db.Cupcakes.Add(Cupcake); 
        var success = await _db.SaveChangesAsync() > 0; 
        if (!success)
            return null;
        return Cupcake;
    }

    public async Task<bool> DeleteCupcakeAsync(int id)
    {
        var Cupcake = await _db.Cupcakes.FirstOrDefaultAsync(x => x.Id == id);
        
        if (Cupcake == null)
            return false;
        
        _db.Cupcakes.Remove(Cupcake);
        
        var success = await _db.SaveChangesAsync() > 0;
        if (!success)
            return false;
        return true;
    }

    public async Task<Cupcake?> GetByIdAsync(int id)
    {
        var Cupcake = await _db.Cupcakes.FirstOrDefaultAsync(x => x.Id == id);
        if (Cupcake != null)
            return Cupcake;
        return null;
    }

    public async Task<List<Cupcake>> GetCupcakesAsync()
    {
        return await _db.Cupcakes.ToListAsync();
    }

    public async Task<Cupcake?> UpdateCupcakeAsync(Cupcake Cupcake, int id)
    {
        var CupcakeToBeUpdated = await GetByIdAsync(id);
        
        if (CupcakeToBeUpdated == null) return null;

        CupcakeToBeUpdated.Description = Cupcake.Description;
        CupcakeToBeUpdated.Name = Cupcake.Name;
        CupcakeToBeUpdated.Price = Cupcake.Price;

        return CupcakeToBeUpdated;
    }
}