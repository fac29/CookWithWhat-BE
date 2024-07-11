using System;

namespace CookWithWhat.Domain.Interfaces;

    public interface IRecipe 
    {
        int Id { get; }
        string Title { get; set; }
        string Description { get; set; }
        string Image { get; set; }
        string Instructions { get; set; }

        
        IEnumerable<IRecipe> GetAllRecipes();
        // create the method to retrieve a single recipe
        // IRecipe GetRecipeById(int id);
        // // create the method to create a new recipe
        // void CreateRecipe(IRecipe recipe);
        // // create the method to delete a recipe
        // void DeleteRecipe(int id);
    }

