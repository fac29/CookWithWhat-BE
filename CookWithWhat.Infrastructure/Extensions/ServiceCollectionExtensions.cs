using CookWithWhat.Infrastructure.Persistence;
using CookWithWhat.Infrastructure.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CookWithWhat.Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("CookWithWhatDb");
        services.AddDbContext<CookWithWhatDbContext>(options => options.UseSqlite(connectionString));

        services.AddScoped<IRecipeSeeder, RecipeSeeder>();
        services.AddScoped<IUserSeeder, UserSeeder>();
    }
}
