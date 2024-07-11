using CookWithWhat.Domain.Interfaces;
using CookWithWhat.Infrastructure.Persistence;

namespace CookWithWhat.Infrastructure;

public class RecipeRepository : IRecipe
{
    private readonly CookWithWhatDbContext _context;
    public int Id => throw new NotImplementedException();

    public string Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Image { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Instructions { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    // public void CreateRecipe(IRecipe recipe)
    // {
    //     throw new NotImplementedException();
    // }

    // public void DeleteRecipe(int id)
    // {
    //     throw new NotImplementedException();
    // }

    public async IEnumerable<IRecipe> GetAllRecipes()
    {
        return await _context.Recipes.ToListAsync();
    }

    // public IRecipe GetRecipeById(int id)
    // {
    //     throw new NotImplementedException();
    // }
  
}
