using RenoMeraApi.Domain.Interfaces;

namespace RenoMeraApi.Domain.Models
{
    public class SupplierPost : ISupplierPost
    {
        public int SupplierPostId { get; set; }
        public string title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string City { get; set; }
        public double Price { get; set; }
        public string Phone { get; set; }
    }
}
