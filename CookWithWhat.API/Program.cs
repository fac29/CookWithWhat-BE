using CookWithWhat.API.Controllers;
using CookWithWhat.Infrastructure.Extensions;
using CookWithWhat.Infrastructure.Persistence;
using CookWithWhat.Infrastructure.Seeders;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddDbContext<CookWithWhatDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"))
);

var app = builder.Build();

var scope = app.Services.CreateScope();
var RecipeSeeder = scope.ServiceProvider.GetRequiredService<IRecipeSeeder>();
await RecipeSeeder.Seed();
var UserSeeder = scope.ServiceProvider.GetRequiredService<IUserSeeder>();
await UserSeeder.Seed();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Conditionally use HTTPS redirection based on the presence of ASPNETCORE_HTTPS_PORT
// var httpsPort = Environment.GetEnvironmentVariable("ASPNETCORE_HTTPS_PORT");
// if (!string.IsNullOrEmpty(httpsPort))
// {
//     app.UseHttpsRedirection();
// }

app.UseAuthorization();

app.MapControllers();

app.Run();
