using CookWithWhat.Domain.Interfaces;

namespace CookWithWhat.Domain.Entities;
public class Recipes : IRecipe
{
    public int Id { get; set; }
    public string Title { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string Image { get; set; } = default!;
    public string Instructions { get; set; } = default!;
//   public void CreateRecipe(IRecipe recipe)
//     {
//         throw new NotImplementedException();
//     }

//     public void DeleteRecipe(Guid id)
//     {
//         throw new NotImplementedException();
//     }

    // public void DeleteRecipe(int id)
    // {
    //     throw new NotImplementedException();
    // }

    public IEnumerable<IRecipe> GetAllRecipes()
    {
        throw new NotImplementedException();
    }

    // public IRecipe GetRecipeById(Guid id)
    // {
    //     throw new NotImplementedException();
    // }

    // public IRecipe GetRecipeById(int id)
    // {
    //     throw new NotImplementedException();
    // }
}