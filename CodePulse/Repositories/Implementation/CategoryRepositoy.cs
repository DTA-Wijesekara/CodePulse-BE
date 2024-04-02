using CodePulse.Data;
using CodePulse.Models.Domain;
using CodePulse.Repositories.Interface;

namespace CodePulse.Repositories.Implementation
{
    public class CategoryRepositoy : ICategoryRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public CategoryRepositoy(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public async Task<Category> CreateAsync(Category category)
        {
            await applicationDbContext.Category.AddAsync(category);
            await applicationDbContext.SaveChangesAsync();
            return (category);
        }
    }
}
