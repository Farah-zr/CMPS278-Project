
namespace Authentication.Models
{
    public class AuthenticationResponse
    {
        public string Token { get; set; } = null!;
        public DateTime Expiration { get; set; }
    }
}