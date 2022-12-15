using System.ComponentModel.DataAnnotations;

namespace Login.Models
{
    public class LoginUser
    {
        [Required(ErrorMessage = "Please enter your name.")]
        public string? UserName { get; set; }
        
        [Required(ErrorMessage = "Please enter a password.")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}