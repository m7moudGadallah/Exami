using Entities;

namespace Services.DTOs;

public record CreateUserInputDto(string? FirstName, string? LastName, UserRole Role, string Email, string Password);
