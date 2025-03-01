using MenuItem.Interfaces;

namespace Cookies.Models;

public class Cookie : IMenuItem{

    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public double Price { get; set; }
}