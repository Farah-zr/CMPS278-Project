using Microsoft.AspNetCore.Mvc;
using Cupcakes.Models;
using CupcakesRepo.Interfaces;

namespace Cupcakes.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class CupcakesController : ControllerBase
{
    private readonly ICupcakeRepo _repo;

    public CupcakesController(ICupcakeRepo repo)
    {
        this._repo = repo;
    }

    [HttpGet]
    public async Task<ActionResult<List<Cupcake>>> GetAllCupcakes()
    {
        return Ok(await _repo.GetCupcakesAsync());
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetCupcakeById(int id)
    {
        var Cupcake = await _repo.GetByIdAsync(id);
        if (Cupcake == null)
            return NotFound();
        return Ok(Cupcake);
    }

    [HttpPost]
    public async Task<ActionResult<Cupcake>> AddCupcake(Cupcake Cupcake)
    {
        var addedCupcake = await _repo.AddCupcakeAsync(Cupcake);
        if (addedCupcake != null) return
            Created($"api/Cupcakes/{addedCupcake.Id}", addedCupcake);
        return BadRequest();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteCar(int id)
    {
        var success = await _repo.DeleteCupcakeAsync(id);
        if (success)
            return NoContent();
        return BadRequest();
    }

    // [HttpPut("{id:int}")]
    // public async Task<IActionResult> UpdateCar(int id, Cupcake Cupcake)
    // {
    //     var updatedCupcake = await _repo.UpdateCupcakeAsync(Cupcake, id);
    //     if (updatedCupcake != null) return
    //         Ok(updatedCupcake);
    //     return BadRequest();
    // }
}
