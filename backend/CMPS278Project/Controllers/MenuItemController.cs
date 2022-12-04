using Microsoft.AspNetCore.Mvc;
using MenuItems.Models;
using MenuItems.Repos;
using MenuItems.Interfaces;

namespace MenuItems.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class MenuItemsController : ControllerBase
{
    private readonly IMenuItems _repo;

    public MenuItemsController(IMenuItems repo)
    {
        this._repo = repo;
    }

    [HttpGet]
    public async Task<ActionResult<List<MenuItem>>> GetAllMenuItems()
    {
        return Ok(await _repo.GetMenuItemsAsync());
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetMenuItemById(int id)
    {
        var menuItem = await _repo.GetByIdAsync(id);
        if (menuItem == null)
            return NotFound();
        return Ok(menuItem);
    }

    [HttpGet("{category:string}")]
    public async Task<IActionResult> GetMenuItemByCategory(string category)
    {
        var menuItem = await _repo.GetByCategoryAsync(category);
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
    public async Task<IActionResult> DeleteCar(int id)
    {
        var success = await _repo.DeleteMenuItemAsync(id);
        if (success)
            return NoContent();
        return BadRequest();
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateCar(int id, MenuItem menuItem)
    {
        var updatedMenuItem = await _repo.UpdateMenuItemAsync(menuItem, id);
        if (updatedMenuItem != null) return
            Ok(updatedMenuItem);
        return BadRequest();
    }
}
