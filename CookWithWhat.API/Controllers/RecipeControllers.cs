using CookWithWhat.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CookWithWhat.API.Controllers;
[ApiController]
[Route("[controller]")]
public class RecipeController : ControllerBase
{

    private readonly ILogger<RecipeController> _logger;
    public RecipeController(ILogger<RecipeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Route("all")]
         public IEnumerable<Recipes> Get()
    {
      _logger.LogInformation("Hello World");
          return new List<Recipes>();
           
        }

    }

