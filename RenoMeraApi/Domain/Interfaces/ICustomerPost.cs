namespace RenoMeraApi.Domain.Interfaces
{
    public interface ICustomerPost
    {
        public int CustomerPostId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string Image { get; set; }
        public string PhoneNumber { get; set; }

    }
}
