using Microsoft.AspNetCore.Mvc;
using Cookies.Models;
using CookiesRepo.Interfaces;

namespace Cookies.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class CookiesController : ControllerBase
{
    private readonly ICookieRepo _repo;

    public CookiesController(ICookieRepo repo)
    {
        this._repo = repo;
    }

    [HttpGet]
    public async Task<ActionResult<List<Cookie>>> GetAllCookies()
    {
        return Ok(await _repo.GetCookiesAsync());
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
        var addedCookie = await _repo.AddCookieAsync(Cookie);
        if (addedCookie != null) return
            Created($"api/Cookies/{addedCookie.Id}", addedCookie);
        return BadRequest();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteCookie(int id)
    {
        var success = await _repo.DeleteCookieAsync(id);
        if (success)
            return NoContent();
        return BadRequest();
    }

    // [HttpPut("{id:int}")]
    // public async Task<IActionResult> UpdateCar(int id, Cookie Cookie)
    // {
    //     var updatedCookie = await _repo.UpdateCookieAsync(Cookie, id);
    //     if (updatedCookie != null) return
    //         Ok(updatedCookie);
    //     return BadRequest();
    // }
}
