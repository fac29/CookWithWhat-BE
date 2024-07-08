namespace CookWithWhat.Domain.Entities;

public class Users
{
    public int Id { get; set; }
    public string Username { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string Password { get; set; } = default!;
    public string Allergy { get; set; } = default!;

}