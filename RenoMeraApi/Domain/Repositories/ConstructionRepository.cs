using Microsoft.EntityFrameworkCore;
using RenoMeraApi.Domain.Models;
using RenoMeraApi.Persistence;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RenoMeraApi.Domain.Repositories
{
    public class ConstructionRepository : IConstructionRepository
    {
        private readonly AppDbContext context;

        public ConstructionRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void Add(ConstructionPost constructionPost)
        {
            context.Add(constructionPost);
            context.SaveChanges();
        }

        public async Task<IEnumerable<ConstructionPost>> GetAllPost()
        {
            return await context.constructionPosts.ToArrayAsync();
         }

        public async Task<IEnumerable<ConstructionPost>> GetAllPostById(string Id)
        {
            return await context.constructionPosts.Where(c => c.UserId == Id).ToArrayAsync();
        }

        public void UpdateConstructionPost(ConstructionPost constructionPost)
        {
            context.constructionPosts.Update(constructionPost);
            context.SaveChanges();
        }
    }
}
