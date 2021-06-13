using Lemondo.Infrastructure.Store.Models;
using Microsoft.EntityFrameworkCore;

namespace Lemondo.Infrastructure.Store
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }

        public DbSet<StatementEntity> Statements { get; set; }
    }
}
