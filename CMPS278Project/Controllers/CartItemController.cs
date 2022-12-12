using Microsoft.AspNetCore.Mvc;
using CartItems.Models;
using CartItemsRepo.Interfaces;
using Microsoft.AspNetCore.Cors;

namespace CartItems.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class CartItemsController : ControllerBase
{
    private readonly ICartItemRepo _repo;

    public CartItemsController(ICartItemRepo repo)
    {
        this._repo = repo;
    }

    [HttpGet]
    public async Task<ActionResult<List<CartItem>>> GetAllCartItems()
    {
        return Ok(await _repo.GetCartItemsAsync());
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetCartItemById(int id)
    {
        var CartItem = await _repo.GetByIdAsync(id);
        if (CartItem == null)
            return NotFound();
        return Ok(CartItem);
    }

    [HttpPost]
    public async Task<ActionResult<CartItem>> AddCartItem(CartItem CartItem)
    {
        var addedCartItem = await _repo.AddCartItemAsync(CartItem);
        if (addedCartItem != null) 
            return Created($"api/CartItems/{addedCartItem.Id}", addedCartItem);
        return BadRequest();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteCartItem(int id)
    {
        var success = await _repo.DeleteCartItemAsync(id);
        if (success)
            return NoContent();
        return BadRequest();
    }

    // [HttpPut("{id:int}")]
    // public async Task<IActionResult> UpdateCar(int id, CartItem CartItem)
    // {
    //     var updatedCartItem = await _repo.UpdateCartItemAsync(CartItem, id);
    //     if (updatedCartItem != null) return
    //         Ok(updatedCartItem);
    //     return BadRequest();
    // }
}
