using Microsoft.EntityFrameworkCore;

namespace Demo1.Data
{
    public class SQLDbContext : DbContext
    {
        public SQLDbContext(DbContextOptions<SQLDbContext> options)
          : base(options)
        {
        }

        public DbSet<Models.Post> Posts { get; set; } = default!;
    }
}
