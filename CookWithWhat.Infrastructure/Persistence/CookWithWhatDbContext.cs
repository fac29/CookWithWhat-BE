using CookWithWhat.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CookWithWhat.Infrastructure.Persistence
{
    public class CookWithWhatDbContext : DbContext
    {
        public CookWithWhatDbContext(DbContextOptions<CookWithWhatDbContext> options) 
            : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Recipes> Recipes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=./CookWithWhat.Infrastructure/Persistence/cookwithwhat.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Define additional configurations here
        }
    }

    public class CookWithWhatDbContextFactory : IDesignTimeDbContextFactory<CookWithWhatDbContext>
    {
        public CookWithWhatDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CookWithWhatDbContext>();
            optionsBuilder.UseSqlite("Data Source=./CookWithWhat.Infrastructure/Persistence/cookwithwhat.db");

            return new CookWithWhatDbContext(optionsBuilder.Options);
        }
    }
}