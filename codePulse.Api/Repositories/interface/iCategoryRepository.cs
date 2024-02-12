using codePulse.Api.Models.Domain;

namespace codePulse.Api.Repositories.Interface
{
    public interface ICategoryRepository
     {
        Task<Category> CreateAsync(Category category);
     }
}
