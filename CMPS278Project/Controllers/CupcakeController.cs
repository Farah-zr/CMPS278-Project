using Cupcakes.Models;
using MenuItemsRepo.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Cupcakes.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class CupcakesController : ControllerBase
{
    private readonly IMenuItemRepo<Cupcake> _repo;

    public CupcakesController(IMenuItemRepo<Cupcake> repo)
    {
        this._repo = repo;
    }

    [HttpGet]
    public async Task<ActionResult<List<Cupcake>>> GetAllCupcakes()
    {
        return Ok(await _repo.GetItemsAsync());
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
        var addedCupcake = await _repo.AddItemAsync(Cupcake);
        if (addedCupcake != null) return
            Created($"api/Cupcakes/{addedCupcake.Id}", addedCupcake);
        return BadRequest();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteCupcake(int id)
    {
        var success = await _repo.DeleteItemAsync(id);
        if (success)
            return NoContent();
        return BadRequest();
    }
}
