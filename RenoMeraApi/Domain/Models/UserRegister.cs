using System.ComponentModel.DataAnnotations;

namespace RenoMeraApi.Domain.Models
{
    public class UserRegister : IUserRegister
    {
        [Required]
        public string UserName { get; set; }
        [Required]

        public string PassWord { get; set; }
        [Required]
        public string Role { get; set; }
       
    }
}
