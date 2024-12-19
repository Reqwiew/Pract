using Microsoft.EntityFrameworkCore;
using Microsoft.Graph;
using Microsoft.Graph.Models;
using HotChocolate.Authorization;
using pract.Models;

namespace pract.Data
{
    public class Mutation
    {
        [Serial]
        public async Task<Service?> UpdatePost([Service]
        PractDbContext context, Service model)
        {
            var post = await context.services.Where(p => p.Id == model.Id).FirstOrDefaultAsync();
            if (post != null)
            {
                if (!string.IsNullOrEmpty(model.NameService))
                    post.NameService = model.NameService;
                if (!string.IsNullOrEmpty(model.Price.ToString()))
                    post.Price = model.Price;
                
                context.services.Update(post);
                await context.SaveChangesAsync();
            }
            return post;
        }
        [Serial]
        public async Task DeletePost(
            [Service]
        PractDbContext context, Service model)
        {
            var post = await context.services.Where(p => p.Id == model.Id).FirstOrDefaultAsync();
            if (post != null)
            {
                context.services.Remove(post);
                await context.SaveChangesAsync();
            }
        }
        [Serial]
        public async Task<Service?> InsertPost(
           [Service]
        PractDbContext context, Service model)
        {
            context.services.Add(model);
            await context.SaveChangesAsync();
            return model;
        }
    }
}
