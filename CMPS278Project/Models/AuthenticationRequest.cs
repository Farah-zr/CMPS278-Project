using System.ComponentModel.DataAnnotations;

namespace Authentication.Models
{
    public class AuthenticationRequest
    {
        [Required]
        public string UserName { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;
    }
}