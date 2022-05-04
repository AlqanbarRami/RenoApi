using System.ComponentModel.DataAnnotations;

namespace RenoMeraApi.Domain.Interfaces
{
    public interface IAuthenticate
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
     
    }
}
