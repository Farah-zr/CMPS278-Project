using Microsoft.AspNetCore.Mvc;
using CakePops.Models;
using CakePopsRepo.Interfaces;

namespace CakePops.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class CakePopsController : ControllerBase
{
    private readonly ICakePopRepo _repo;

    public CakePopsController(ICakePopRepo repo)
    {
        this._repo = repo;
    }

    [HttpGet]
    public async Task<ActionResult<List<CakePop>>> GetAllCakePops()
    {
        return Ok(await _repo.GetCakePopsAsync());
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
        var addedCakePop = await _repo.AddCakePopAsync(cakePop);
        if (addedCakePop != null) return
            Created($"api/CakePops/{addedCakePop.Id}", addedCakePop);
        return BadRequest();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteCakePop(int id)
    {
        var success = await _repo.DeleteCakePopAsync(id);
        if (success)
            return NoContent();
        return BadRequest();
    }
}
