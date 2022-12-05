using Menu.Data;
using CookiesRepo.Interfaces;
using Cookies.Models;
using Microsoft.EntityFrameworkCore;

namespace Cookies.Repos;

public class CookieRepo : ICookieRepo
{
    private readonly AppDbContext _db;

    public CookieRepo(AppDbContext db)
    {
        this._db = db;
    }
    public async Task<Cookie?> AddCookieAsync(Cookie Cookie)
    {
       _db.Cookies.Add(Cookie); 
        var success = await _db.SaveChangesAsync() > 0; 
        if (!success)
            return null;
        return Cookie;
    }

    public async Task<bool> DeleteCookieAsync(int id)
    {
        var Cookie = await _db.Cookies.FirstOrDefaultAsync(x => x.Id == id);
        
        if (Cookie == null)
            return false;
        
        _db.Cookies.Remove(Cookie);
        
        var success = await _db.SaveChangesAsync() > 0;
        if (!success)
            return false;
        return true;
    }

    public async Task<Cookie?> GetByIdAsync(int id)
    {
        var Cookie = await _db.Cookies.FirstOrDefaultAsync(x => x.Id == id);
        if (Cookie != null)
            return Cookie;
        return null;
    }

    public async Task<List<Cookie>> GetCookiesAsync()
    {
        return await _db.Cookies.ToListAsync();
    }

    public async Task<Cookie?> UpdateCookieAsync(Cookie Cookie, int id)
    {
        var CookieToBeUpdated = await GetByIdAsync(id);
        
        if (CookieToBeUpdated == null) return null;

        CookieToBeUpdated.Description = Cookie.Description;
        CookieToBeUpdated.Name = Cookie.Name;
        CookieToBeUpdated.Price = Cookie.Price;

        return CookieToBeUpdated;
    }
}