using RenoMeraApi.Domain.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace RenoMeraApi.Domain.Models
{
    public class Authenticate : IAuthenticate
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set ; }
    }
}
