using Cookies.Models;

namespace CookiesRepo.Interfaces;

public interface ICookieRepo
{
    Task<List<Cookie>> GetCookiesAsync();
    Task<Cookie?> GetByIdAsync(int id); 
    Task<Cookie?> AddCookieAsync(Cookie Cookie);
    Task<bool> DeleteCookieAsync(int id);
    Task<Cookie?> UpdateCookieAsync(Cookie Cookie, int id);
}