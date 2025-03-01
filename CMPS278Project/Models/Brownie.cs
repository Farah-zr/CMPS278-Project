using MenuItem.Interfaces;

namespace Brownies.Models;

public class Brownie : IMenuItem {

    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public double Price { get; set; }
}