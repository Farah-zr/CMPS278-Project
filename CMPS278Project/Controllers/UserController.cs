using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Users.Models;
using Register.Models;
using JwtServices.Services;
using Authentication.Models;

namespace Users.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly JwtService _jwtService;

        public UsersController(UserManager<User> userManager, JwtService jwtService) {
            _userManager = userManager;
            _jwtService = jwtService;
        }

        [HttpPost]
        public async Task<ActionResult<RegisterUser>> PostUser(RegisterUser registerUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _userManager.CreateAsync(
                new User() { UserName = registerUser.UserName, Email = registerUser.Email, PhoneNumber = registerUser.PhoneNumber, Address = registerUser.Address },
                registerUser.Password
            );

            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            // registerUser.Password = null;
            // return Created("", registerUser);
            return CreatedAtAction("GetUser", new { username = registerUser.UserName }, registerUser);
        }

        [HttpGet("{username}")]
        public async Task<ActionResult<RegisterUser>> GetUser(string username)
        {
            User user = await _userManager.FindByNameAsync(username);

            if (user == null)
            {
                return NotFound();
            }

            return new RegisterUser
            {
                UserName = user.UserName,
                Email = user.Email,
                Address = user.Address,
                PhoneNumber = user.PhoneNumber
            };
        }

        [HttpPost("BearerToken")]
        public async Task<ActionResult<AuthenticationResponse>> CreateBearerToken(AuthenticationRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Bad credentials");
            }

            var user = await _userManager.FindByNameAsync(request.UserName);

            if (user == null)
            {
                return BadRequest("Bad credentials");
            }

            var isPasswordValid = await _userManager.CheckPasswordAsync(user, request.Password);

            if (!isPasswordValid)
            {
                return BadRequest("Bad credentials");
            }

            var token = _jwtService.CreateToken(user);

            return Ok(token);
        }
    }
}