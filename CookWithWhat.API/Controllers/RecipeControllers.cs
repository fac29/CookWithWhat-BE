using CookWithWhat.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using CookWithWhat.Infrastructure.Persistence;

namespace CookWithWhat.API.Controllers;

[ApiController]
[Route("[controller]")]
public class RecipeController : ControllerBase
{

   private readonly CookWithWhatDbContext _context;
    public RecipeController(CookWithWhatDbContext context)
    {
        _context = context!;
    }

    [HttpGet]
    [Route("all")]
        
         public IEnumerable<Recipes> Get()
    {
          return new List<Recipes>();
           
        }

    }

