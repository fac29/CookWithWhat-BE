using CookWithWhat.Domain.Entities;
using CookWithWhat.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CookWithWhat.Infrastructure.Persistence
{
    public class CookWithWhatDbContext(DbContextOptions<CookWithWhatDbContext> options)
        : DbContext(options)
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Recipes> Recipes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // //Data source for local
            // optionsBuilder.UseSqlite(
            //     "Data Source=../CookWithWhat.Infrastructure/Persistence/cookwithwhat.db".
            // );
            //Data source for deployment
            optionsBuilder.UseSqlite(
                "Data Source=./CookWithWhat.Infrastructure/Persistence/cookwithwhat.db"
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Define additional configurations here.
        }
    }
}
