﻿namespace Entities;

public record User
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public UserRole Role { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }
}
