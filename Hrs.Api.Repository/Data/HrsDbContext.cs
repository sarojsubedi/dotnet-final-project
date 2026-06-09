using Microsoft.EntityFrameworkCore;

namespace Hrs.Api.Repository.Data;

public class HrsDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Author> Author { get; set; }

    }
    
}