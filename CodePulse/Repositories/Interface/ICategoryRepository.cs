using CodePulse.Models.Domain;

namespace CodePulse.Repositories.Interface
{
    public interface ICategoryRepository
    {
        public Task<Category> CreateAsync(Category category);
    }
}
