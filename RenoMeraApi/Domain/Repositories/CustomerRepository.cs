using Microsoft.EntityFrameworkCore;
using RenoMeraApi.Domain.Models;
using RenoMeraApi.Persistence;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RenoMeraApi.Domain.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {


        private readonly AppDbContext context;

        public CustomerRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void Add(CustomerPost customerPost)
        {
            context.Add(customerPost);
            context.SaveChanges();
        }

        public async Task<IEnumerable<CustomerPost>> GetAllPost()
        {
            return await context.customerPosts.ToArrayAsync();
        }

        public async Task<IEnumerable<CustomerPost>> GetAllPostById(string Id)
        {
            return await context.customerPosts.Where(c => c.UserId == Id).ToArrayAsync();
        }

        public void UpdateCustomerPost(CustomerPost customerPost)
        {
            context.customerPosts.Update(customerPost);
            context.SaveChanges();
        }
    }
}
