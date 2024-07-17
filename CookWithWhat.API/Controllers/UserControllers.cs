using CookWithWhat.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using CookWithWhat.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CookWithWhat.API.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{

    private readonly CookWithWhatDbContext _context;
    public UserController(CookWithWhatDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("all")]
    public async Task<ActionResult<IEnumerable<Users>>> GetAllUsers()
    {
        try
        {
            var users = await _context.Users.ToListAsync();
            if (users == null || !users.Any())
            {
                return NotFound("No users found");
            }
            return Ok(users);
        }
        catch (Exception ex)
        {
            // Log the exception
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<ActionResult<Users>> GetUserById(int id)
    {
        try
        {
            var user = await _context.Users.FirstOrDefaultAsync(r => r.Id == id);
            if (user == null)
            {
                return NotFound("User not found");
            }
            return Ok(user);
        }
        catch (Exception ex)
        {
            // Log the exception
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
}

