using MenuItem.Interfaces;

namespace CinnamonRolls.Models;

public class CinnamonRoll : IMenuItem {

    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public double Price { get; set; }
}