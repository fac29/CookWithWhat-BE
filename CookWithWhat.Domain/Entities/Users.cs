namespace CookWithWhat.Domain.Entities;
using CookWithWhat.Domain.Interfaces;

public class Users : IUser
{
    public int Id { get; set; }
    public string Username { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string Password { get; set; } = default!;

}