using Microsoft.EntityFrameworkCore;
using CookWithWhat.Domain.Entities;

namespace CookWithWhat.Infrastructure.Persistence
{
    internal class CookWithWhatDbContext(DbContextOptions<CookWithWhatDbContext> options) : DbContext(options)
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Recipes> Recipes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //this should be dependency injection?
            optionsBuilder.UseSqlite("Data Source=cookwithwhat.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Define additional configurations here
        }
    }
}
