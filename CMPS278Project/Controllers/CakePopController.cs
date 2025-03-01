using CakePops.Models;
using MenuItemsRepo.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CakePops.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class CakePopsController : ControllerBase
{
    private readonly IMenuItemRepo<CakePop> _repo;

    public CakePopsController(IMenuItemRepo<CakePop> repo)
    {
        this._repo = repo;
    }

    [HttpGet]
    public async Task<ActionResult<List<CakePop>>> GetAllCakePops()
    {
        return Ok(await _repo.GetItemsAsync());
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetCakePopById(int id)
    {
        var cakePop = await _repo.GetByIdAsync(id);
        if (cakePop == null)
            return NotFound();
        return Ok(cakePop);
    }

    [HttpPost]
    public async Task<ActionResult<CakePop>> AddCakePop(CakePop cakePop)
    {
        var addedCakePop = await _repo.AddItemAsync(cakePop);
        if (addedCakePop != null) return
            Created($"api/CakePops/{addedCakePop.Id}", addedCakePop);
        return BadRequest();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteCakePop(int id)
    {
        var success = await _repo.DeleteItemAsync(id);
        if (success)
            return NoContent();
        return BadRequest();
    }
}
