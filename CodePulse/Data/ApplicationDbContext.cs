using CodePulse.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CodePulse.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<BlogPost> BlogPost { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
