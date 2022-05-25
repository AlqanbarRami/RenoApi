using Microsoft.AspNetCore.Identity;
using RenoMeraApi.Domain.Interfaces;

namespace RenoMeraApi.Domain.Models
{
    public class User : IdentityUser, IUser 
    {
        public int UserId { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
  
    }
}
