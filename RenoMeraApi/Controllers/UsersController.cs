using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RenoMeraApi.Domain.Models;
using System;
using System.Threading.Tasks;

namespace RenoMeraApi.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : Controller
    {

        private readonly IUserRepository userRepository;
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public UsersController(SignInManager<User> signInManager,IUserRepository userRepository,  UserManager<User> userManager)
        {
            this.userRepository = userRepository;
            this.userManager = userManager;
            this.signInManager = signInManager;

        }

        [Route("register")]
        [HttpPost]
        public async Task<ActionResult<User>> Register([FromBody] UserRegister user)
        {
            try
            {
                    var newUser = new User
                    {
                        Role = user.Role,
                        UserName = user.UserName,
                        Password = user.PassWord
          
    };
                    var AddUser = await userManager.CreateAsync(newUser, newUser.Password);
                    if (AddUser.Succeeded)
                    {
                    var getUser = userRepository.GetByUserName(newUser.UserName);
                    return Ok(getUser.Id);
                    }
                    else
                    {
                        return BadRequest(AddUser);
                    }
         
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }

        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] Authenticate model)
        {
            if (ModelState.IsValid)
            {
                var user = userRepository.GetByUserName(model.Username);

                if (user != null)
                {
                    var result = await signInManager.CheckPasswordSignInAsync(user, model.Password, false);

                    if (result.Succeeded)
                    {
                        return Ok(new
                        {
                            Id = user.Id,
                            Role = user.Role
                        });
                     }
                    else
                    {
                        return BadRequest("Password Or username error");
                    }
                }
                else
                {
                    return BadRequest("User Not Found");
                }

            }
            return Ok();


        }



    }
}
