namespace MenuItems.Models;

public class MenuItem {

    public int Id { get; set; }

    public string Category { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int Price { get; set; }
}