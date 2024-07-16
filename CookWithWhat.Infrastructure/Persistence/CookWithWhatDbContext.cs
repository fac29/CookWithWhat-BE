using CookWithWhat.Domain.Entities;

using CookWithWhat.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CookWithWhat.Infrastructure.Persistence
{
    public class CookWithWhatDbContext(DbContextOptions<CookWithWhatDbContext> options)
        : DbContext(options)

    {
        public CookWithWhatDbContext(DbContextOptions<CookWithWhatDbContext> options) 
            : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Recipes> Recipes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //this should be dependency injection?
            optionsBuilder.UseSqlite(
                "Data Source=CookWithWhat.Infrastructure/Persistence/cookwithwhat.db"
            );

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
            optionsBuilder.UseSqlite("Data Source=../CookWithWhat.Infrastructure/Persistence/cookwithwhat.db");

            return new CookWithWhatDbContext(optionsBuilder.Options);
        }
    }
}