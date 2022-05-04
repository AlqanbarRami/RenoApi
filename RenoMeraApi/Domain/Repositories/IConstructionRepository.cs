using RenoMeraApi.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RenoMeraApi.Domain.Repositories
{
    public interface IConstructionRepository
    {
        Task<IEnumerable<ConstructionPost>> GetAllPost();
        void UpdateConstructionPost(ConstructionPost constructionPost);
        void Add(ConstructionPost constructionPost);
    }
}
