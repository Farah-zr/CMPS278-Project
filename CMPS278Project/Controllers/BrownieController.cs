using Brownies.Models;
using MenuItemsRepo.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Brownies.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class BrowniesController : ControllerBase
{
    private readonly IMenuItemRepo<Brownie> _repo;

    public BrowniesController(IMenuItemRepo<Brownie> repo)
    {
        this._repo = repo;
    }

    [HttpGet]
    public async Task<ActionResult<List<Brownie>>> GetAllBrownies()
    {
        return Ok(await _repo.GetItemsAsync());
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetBrownieById(int id)
    {
        var Brownie = await _repo.GetByIdAsync(id);
        if (Brownie == null)
            return NotFound();
        return Ok(Brownie);
    }

    [HttpPost]
    public async Task<ActionResult<Brownie>> AddBrownie(Brownie Brownie)
    {
        var addedBrownie = await _repo.AddItemAsync(Brownie);
        if (addedBrownie != null) return
            Created($"api/Brownies/{addedBrownie.Id}", addedBrownie);
        return BadRequest();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteBrownie(int id)
    {
        var success = await _repo.DeleteItemAsync(id);
        if (success)
            return NoContent();
        return BadRequest();
    }
}
