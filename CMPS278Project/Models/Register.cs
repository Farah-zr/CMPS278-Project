using System.ComponentModel.DataAnnotations;

namespace Register.Models
{
    public class RegisterUser
    {
        [Required(ErrorMessage = "Please enter a username.")]
        public string? UserName { get; set; }
        
        [Required(ErrorMessage = "Please enter a password.")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please enter an address.")]
        public string? Address { get; set; }

        [Required(ErrorMessage = "Please your phone number.")]
        public string? PhoneNumber { get; set; }
    }
}