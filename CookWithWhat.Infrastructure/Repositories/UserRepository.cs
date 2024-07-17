using CookWithWhat.Domain.Interfaces;
using CookWithWhat.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
namespace CookWithWhat.Infrastructure;

public class UserRepository : IUser
{
    private readonly CookWithWhatDbContext _context = default!;
    public int Id => throw new NotImplementedException();
    public string Username { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Email { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Password { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    // public void CreateRecipe(IRecipe recipe)
    // {
    //     throw new NotImplementedException();
    // }

    // public void DeleteRecipe(int id)
    // {
    //     throw new NotImplementedException();
    // }

    public async Task<IEnumerable<IUser>> GetAllUsers()
    {
        return await _context.Users.ToListAsync();
    }

    // public IRecipe GetRecipeById(int id)
    // {
    //     throw new NotImplementedException();
    // }

}
