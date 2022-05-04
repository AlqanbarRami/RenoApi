namespace RenoMeraApi.Domain.Models
{
    public interface IUserRepository
    {
        User GetByUserName(string username);

    }
}
