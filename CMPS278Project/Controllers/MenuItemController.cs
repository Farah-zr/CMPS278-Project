using Microsoft.AspNetCore.Mvc;
using MenuItems.Models;
using MenuItemsRepo.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace MenuItems.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class MenuItemsController : ControllerBase
{
    private readonly IMenuItemRepo _repo;

    public MenuItemsController(IMenuItemRepo repo)
    {
        this._repo = repo;
    }

    // [Authorize]
    [HttpGet]
    public async Task<ActionResult<List<MenuItem>>> GetAllMenuItems()
    {
        return Ok(await _repo.GetMenuItemsAsync());
    }

    // [Authorize]
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetMenuItemById(int id)
    {
        var menuItem = await _repo.GetByIdAsync(id);
        if (menuItem == null)
            return NotFound();
        return Ok(menuItem);
    }

    [HttpPost]
    public async Task<ActionResult<MenuItem>> AddMenuItem(MenuItem menuItem)
    {
        var addedMenuItem = await _repo.AddMenuItemAsync(menuItem);
        if (addedMenuItem != null) return
            Created($"api/MenuItems/{addedMenuItem.Id}", addedMenuItem);
        return BadRequest();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteMenuItem(int id)
    {
        var success = await _repo.DeleteMenuItemAsync(id);
        if (success)
            return NoContent();
        return BadRequest();
    }
}
