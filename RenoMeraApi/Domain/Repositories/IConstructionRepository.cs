using RenoMeraApi.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RenoMeraApi.Domain.Repositories
{
    public interface IConstructionRepository
    {
        Task<IEnumerable<ConstructionPost>> GetAllPost();
        Task<IEnumerable<ConstructionPost>> GetAllPostById(string Id);

        void UpdateConstructionPost(ConstructionPost constructionPost);
        void Add(ConstructionPost constructionPost);
    }
}
