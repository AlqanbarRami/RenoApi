using Microsoft.EntityFrameworkCore;
using RenoMeraApi.Domain.Models;
using RenoMeraApi.Persistence;
using System.Collections.Generic;
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

        public void UpdateCustomerPost(CustomerPost customerPost)
        {
            context.customerPosts.Update(customerPost);
            context.SaveChanges();
        }
    }
}
