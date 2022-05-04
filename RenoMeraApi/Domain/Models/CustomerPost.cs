using RenoMeraApi.Domain.Interfaces;

namespace RenoMeraApi.Domain.Models
{
    public class CustomerPost : ICustomerPost
    {
        public int CustomerPostId { get ; set ; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string Image { get; set; }
        public string PhoneNumber { get; set; }
    }
}
