namespace Entities;

public record User(int Id, string? FirstName, string? LastName, UserRole Role, string Email, string Password);
