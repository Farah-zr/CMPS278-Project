using Cookies.Models;
using MenuItemsRepo.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Cookies.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class CookiesController : ControllerBase
{
    private readonly IMenuItemRepo<Cookie> _repo;

    public CookiesController(IMenuItemRepo<Cookie> repo)
    {
        this._repo = repo;
    }

    [HttpGet]
    public async Task<ActionResult<List<Cookie>>> GetAllCookies()
    {
        return Ok(await _repo.GetItemsAsync());
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetCookieById(int id)
    {
        var Cookie = await _repo.GetByIdAsync(id);
        if (Cookie == null)
            return NotFound();
        return Ok(Cookie);
    }

    [HttpPost]
    public async Task<ActionResult<Cookie>> AddCookie(Cookie Cookie)
    {
        var addedCookie = await _repo.AddItemAsync(Cookie);
        if (addedCookie != null) return
            Created($"api/Cookies/{addedCookie.Id}", addedCookie);
        return BadRequest();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteCookie(int id)
    {
        var success = await _repo.DeleteItemAsync(id);
        if (success)
            return NoContent();
        return BadRequest();
    }
}
