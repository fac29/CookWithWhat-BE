using Microsoft.EntityFrameworkCore;
using CookWithWhat.Domain.Entities;

namespace CookWithWhat.Infrastructure.Persistence
{
    public class CookWithWhatDbContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Recipes> Recipes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=cookwithwhat.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Define additional configurations here
        }
    }
}
