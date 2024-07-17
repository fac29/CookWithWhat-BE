using CookWithWhat.Infrastructure.Persistence;
using CookWithWhat.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CookWithWhat.Infrastructure.Seeders;

public class UserSeeder : IUserSeeder
{
    private readonly CookWithWhatDbContext _context;

    public UserSeeder(CookWithWhatDbContext context)
    {
        _context = context;
    }

    public async Task Seed()
    {
        if (await _context.Database.CanConnectAsync())
        {
            if (!_context.Users.Any())
            {
                var users = GetUsers();
                _context.Users.AddRange(users);
                await _context.SaveChangesAsync();
            }
        }
    }

    private IEnumerable<Users> GetUsers()
    {
        return new List<Users>
        {
              new Users
                {
                    Id = 1,
                    Username = "john_doe",
                    Email = "john.doe@example.com",
                    Password = "hashed_password_1"
                },
                new Users
                {
                    Id = 2,
                    Username = "jane_smith",
                    Email = "jane.smith@example.com",
                    Password = "hashed_password_2"
                },
                new Users
                {
                    Id = 3,
                    Username = "sam_green",
                    Email = "sam.green@example.com",
                    Password = "hashed_password_3"
                }
        };
    }
}