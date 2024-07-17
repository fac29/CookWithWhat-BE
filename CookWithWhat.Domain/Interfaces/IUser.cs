using System;

namespace CookWithWhat.Domain.Interfaces;

public interface IUser
{
    int Id { get; }
    string Username { get; set; }
    string Email { get; set; }
    string Password { get; set; }
}

