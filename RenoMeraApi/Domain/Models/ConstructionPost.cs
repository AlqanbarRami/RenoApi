using RenoMeraApi.Domain.Interfaces;

namespace RenoMeraApi.Domain.Models
{
    public class ConstructionPost : IConstructionPost
    {
        public int ConstructionPostId { get; set; }
        public string title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Phone { get; set; }
    }
}
