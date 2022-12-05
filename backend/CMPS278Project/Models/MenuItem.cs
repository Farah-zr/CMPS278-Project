using CategoryEnum.Enums;

namespace MenuItems.Models;

public class MenuItem {

    public int Id { get; set; }

    public Category Category { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int Price { get; set; }
}