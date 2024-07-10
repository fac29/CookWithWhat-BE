using CookWithWhat.Infrastructure.Persistence;
using CookWithWhat.Domain.Entities;
using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace CookWithWhat.Infrastructure.Seeders;

internal class RecipeSeeder( CookWithWhatDbContext DbContext) : IRecipeSeeder
{
    public async Task Seed()
    {
        if (await DbContext.Database.CanConnectAsync())
            {
                if(!DbContext.Recipes.Any())
                {
                    var recipes = GetRecipes();
                    DbContext.Recipes.AddRange(recipes);
                    await DbContext.SaveChangesAsync();
                }
            }
    }
private IEnumerable<Recipes> GetRecipes()
        {
            return new List<Recipes>
            {
                new Recipes
                {
                    Id = 1,
                    Title = "Spaghetti Carbonara",
                    Description = "A classic Italian pasta dish made with eggs, cheese, pancetta, and pepper.",
                    Image = "carbonara.jpg",
                    Instructions = "1. Cook the pasta. 2. Fry the pancetta. 3. Mix eggs and cheese. 4. Combine everything."
                },
                new Recipes
                {
                    Id = 2,
                    Title = "Chicken Curry",
                    Description = "A spicy, flavorful dish made with chicken, curry spices, and coconut milk.",
                    Image = "chicken_curry.jpg",
                    Instructions = "1. Brown the chicken. 2. Add spices and cook. 3. Add coconut milk and simmer."
                },
                new Recipes
                {
                    Id = 3,
                    Title = "Vegetable Stir Fry",
                    Description = "A quick and easy dish made with a mix of vegetables stir-fried in a savory sauce.",
                    Image = "vegetable_stir_fry.jpg",
                    Instructions = "1. Chop vegetables. 2. Stir fry vegetables. 3. Add sauce and cook until done."
                }
            };
        }
    }

