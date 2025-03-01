using MenuItem.Interfaces;

namespace CakePops.Models;

public class CakePop : IMenuItem {

    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public double Price { get; set; }
}