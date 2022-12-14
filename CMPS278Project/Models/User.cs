using Microsoft.AspNetCore.Identity;

namespace Users.Models;

public class User : IdentityUser {
// Inherits all IdentityUser properties (username, pass, email, phone #)
    public string Address { get; set; } = null!;
}
