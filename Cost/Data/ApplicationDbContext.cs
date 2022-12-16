using Cost_DataAccess;
using Microsoft.EntityFrameworkCore;


namespace Cost.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Component> Components { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}