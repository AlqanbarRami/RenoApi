using RenoMeraApi.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RenoMeraApi.Domain.Repositories
{
    public interface ISupplierRepository
    {
        Task<IEnumerable<SupplierPost>> GetAllPost();
        void UpdateSupplierPost(SupplierPost supplierPost);
        void Add(SupplierPost supplierPost);

    }
}
