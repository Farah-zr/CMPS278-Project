using MenuItem.Interfaces;

namespace Cupcakes.Models;

public class Cupcake : IMenuItem {

    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public double Price { get; set; }
}