using CinnamonRolls.Models;
using MenuItemsRepo.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CinnamonRolls.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class CinnamonRollsController : ControllerBase
{
    private readonly IMenuItemRepo<CinnamonRoll> _repo;

    public CinnamonRollsController(IMenuItemRepo<CinnamonRoll> repo)
    {
        this._repo = repo;
    }

    [HttpGet]
    public async Task<ActionResult<List<CinnamonRoll>>> GetAllCinnamonRolls()
    {
        return Ok(await _repo.GetItemsAsync());
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetCinnamonRollById(int id)
    {
        var CinnamonRoll = await _repo.GetByIdAsync(id);
        if (CinnamonRoll == null)
            return NotFound();
        return Ok(CinnamonRoll);
    }

    [HttpPost]
    public async Task<ActionResult<CinnamonRoll>> AddCinnamonRoll(CinnamonRoll CinnamonRoll)
    {
        var addedCinnamonRoll = await _repo.AddItemAsync(CinnamonRoll);
        if (addedCinnamonRoll != null) return
            Created($"api/CinnamonRolls/{addedCinnamonRoll.Id}", addedCinnamonRoll);
        return BadRequest();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteCinnamonRoll(int id)
    {
        var success = await _repo.DeleteItemAsync(id);
        if (success)
            return NoContent();
        return BadRequest();
    }
}
