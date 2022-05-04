using System.ComponentModel.DataAnnotations;

namespace RenoMeraApi.Domain.Models
{
    public interface IUserRegister
    {
        [Required]
        public string UserName { set; get; }
        [Required]
        public string PassWord { get; set; }
        [Required]
        public string Role { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string TypeOfAccount { get; set; }

    }
}
