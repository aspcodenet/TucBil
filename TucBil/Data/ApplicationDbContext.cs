using Microsoft.EntityFrameworkCore;

namespace TucBil.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Bil> Bilar { get; set; }
    }
}