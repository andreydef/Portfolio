using Microsoft.EntityFrameworkCore;

namespace PortfolioApp.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<About> About { get; set; }
    }
}