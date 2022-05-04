using RenoMeraApi.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RenoMeraApi.Domain.Repositories
{
    public interface ICustomerRepository
    {

        Task<IEnumerable<CustomerPost>> GetAllPost();
        void UpdateCustomerPost(CustomerPost customerPost);
        void Add(CustomerPost customerPost);
    }
}
