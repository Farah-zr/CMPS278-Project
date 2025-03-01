using CategoryEnum.Enums;
using MenuItem.Interfaces;

namespace MenuItems.Models;

public class MenuItem : IMenuItem {

    public int Id { get; set; }

    // public Category Category { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public double Price { get; set; }
}