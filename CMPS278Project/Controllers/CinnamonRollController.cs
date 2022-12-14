using Microsoft.AspNetCore.Mvc;
using CinnamonRolls.Models;
using CinnamonRollsRepo.Interfaces;

namespace CinnamonRolls.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class CinnamonRollsController : ControllerBase
{
    private readonly ICinnamonRollRepo _repo;

    public CinnamonRollsController(ICinnamonRollRepo repo)
    {
        this._repo = repo;
    }

    [HttpGet]
    public async Task<ActionResult<List<CinnamonRoll>>> GetAllCinnamonRolls()
    {
        return Ok(await _repo.GetCinnamonRollsAsync());
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
        var addedCinnamonRoll = await _repo.AddCinnamonRollAsync(CinnamonRoll);
        if (addedCinnamonRoll != null) return
            Created($"api/CinnamonRolls/{addedCinnamonRoll.Id}", addedCinnamonRoll);
        return BadRequest();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteCinnamonRoll(int id)
    {
        var success = await _repo.DeleteCinnamonRollAsync(id);
        if (success)
            return NoContent();
        return BadRequest();
    }

    // [HttpPut("{id:int}")]
    // public async Task<IActionResult> UpdateCar(int id, CinnamonRoll CinnamonRoll)
    // {
    //     var updatedCinnamonRoll = await _repo.UpdateCinnamonRollAsync(CinnamonRoll, id);
    //     if (updatedCinnamonRoll != null) return
    //         Ok(updatedCinnamonRoll);
    //     return BadRequest();
    // }
}
