using CookWithWhat.Infrastructure.Persistence;
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
        }
    }
