using codePulse.Api.Data;
using codePulse.Api.Models.Domain;
using codePulse.Api.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace codePulse.Api.Repositories.implemantation
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext dbContext;
        public CategoryRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public ApplicationDbContext DbContext { get; }

        public async Task<Category> CreateAsync(Category category)
        {

            await dbContext.Categories.AddAsync(category);
            await dbContext.SaveChangesAsync();

            return category;
        }
    }
}
