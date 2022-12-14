using Microsoft.AspNetCore.Mvc;
using Brownies.Models;
using BrowniesRepo.Interfaces;

namespace Brownies.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class BrowniesController : ControllerBase
{
    private readonly IBrownieRepo _repo;

    public BrowniesController(IBrownieRepo repo)
    {
        this._repo = repo;
    }

    [HttpGet]
    public async Task<ActionResult<List<Brownie>>> GetAllBrownies()
    {
        return Ok(await _repo.GetBrowniesAsync());
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
        var addedBrownie = await _repo.AddBrownieAsync(Brownie);
        if (addedBrownie != null) return
            Created($"api/Brownies/{addedBrownie.Id}", addedBrownie);
        return BadRequest();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteBrownie(int id)
    {
        var success = await _repo.DeleteBrownieAsync(id);
        if (success)
            return NoContent();
        return BadRequest();
    }

    // [HttpPut("{id:int}")]
    // public async Task<IActionResult> UpdateCar(int id, Brownie Brownie)
    // {
    //     var updatedBrownie = await _repo.UpdateBrownieAsync(Brownie, id);
    //     if (updatedBrownie != null) return
    //         Ok(updatedBrownie);
    //     return BadRequest();
    // }
}
