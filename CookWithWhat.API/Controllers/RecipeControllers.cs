using CookWithWhat.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using CookWithWhat.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CookWithWhat.API.Controllers;

[ApiController]
[Route("[controller]")]
public class RecipeController : ControllerBase
{

    private readonly CookWithWhatDbContext _context;
    public RecipeController(CookWithWhatDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("all")]
    public async Task<ActionResult<IEnumerable<Recipes>>> GetAllRecipes()
    {
        try
        {
            var recipes = await _context.Recipes.ToListAsync();
            if (recipes == null || !recipes.Any())
            {
                return NotFound("No recipes found");
            }
            return Ok(recipes);
        }
        catch (Exception ex)
        {
            // Log the exception
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<ActionResult<Recipes>> GetRecipe(int id)
    {
        try
        {
            var recipe = await _context.Recipes.FirstOrDefaultAsync(r => r.Id == id);
            if (recipe == null)
            {
                return NotFound("Recipe not found");
            }
            return Ok(recipe);
        }
        catch (Exception ex)
        {
            // Log the exception
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
}