using Microsoft.EntityFrameworkCore;

namespace Cost_DataAccess
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
