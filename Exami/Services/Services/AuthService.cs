using Database;
using Entities;
using Services.DTOs;
using Services.Mappers;
using System.Data;
using Utilities.Exceptoins;

namespace Services.Services;

/// <summary>
/// Provides authentication-related services, such as user login functionality.
/// </summary>
public static class AuthService
{
    /// <summary>
    /// Authenticates a user by verifying their email and password.
    /// </summary>
    /// <param name="dto">A <see cref="LoginInputDto"/> object containing the user's email and password.</param>
    /// <returns>A <see cref="User"/> object representing the authenticated user if the credentials are valid.</returns>
    /// <exception cref="AppException">
    /// Thrown if the provided email or password is invalid.
    /// </exception>
    public static User Login(LoginInputDto dto)
    {
        var sql = @"
            SELECT *
            FROM [User]
            WHERE Email =  @Email";

        DBCommandParams cmdParams = new(sql, CommandType.Text, new Dictionary<string, object>() { ["@Email"] = dto.Email });
        var users = new UserMapper().MapFromDataTable(DatabaseManager.ExecuteDataTable(cmdParams));

        if (users.Count == 0 || users[0]?.Password != dto.Password)
        {
            throw new AppException("Invalid Email or Passowrd!", ExceptionStatus.Error);
        }

        return users[0];
    }
}
