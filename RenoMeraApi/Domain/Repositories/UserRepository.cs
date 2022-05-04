using RenoMeraApi.Persistence;
using System.Linq;

namespace RenoMeraApi.Domain.Models
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext context;

        public UserRepository(AppDbContext context)
        {
            this.context = context;
        }

        public User GetByUserName(string username)
        {
            return context.users.FirstOrDefault(u => u.UserName == username);
        }
    }
}
