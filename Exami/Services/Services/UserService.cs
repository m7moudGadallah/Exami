using Database;
using System.Data;
using Entities;
using Services.DTOs;
using Services.Mappers;
using Utilities.Exceptoins;

namespace Services.Services;

/// <summary>
/// Provides methods to manage user records, including retrieving, creating, updating, and deleting users.
/// </summary>
public static class UserService
{
    /// <summary>
    /// Retrieves a list of users based on the provided filters, ordering, and pagination parameters.
    /// </summary>
    /// <param name="dto">An optional <see cref="GetAllUsersInputDto"/> object containing filtering, ordering, and pagination parameters.</param>
    /// <returns>A list of <see cref="User"/> objects that match the specified filters and ordering criteria.</returns>
    /// <exception cref="AppException">
    /// Thrown if an error occurs during the database operation.
    /// The exception includes a descriptive message and an inner exception for debugging purposes.
    /// </exception>
    /// <remarks>
    /// This method dynamically constructs a SQL query using the provided filters, ordering, and pagination parameters.
    /// It queries the <c>User</c> table to fetch the data.
    /// </remarks>
    public static List<User> GetAllUsers(GetAllUsersInputDto? dto)
    {
        try
        {
            var sql = @"
                SELECT *
                FROM [User]
                WHERE 1=1";

            SqlQueryBuilder queryBuilder = new(new(sql, CommandType.Text, new() { }));

            // Add filters dynamically
            if (dto?.Filters != null)
            {
                queryBuilder.ApplyFilters(dto.Filters);
            }

            // Add ordering
            if (dto?.OrderBy == null || dto.OrderBy.Count == 0)
            {
                dto.OrderBy = new() { ["Id"] = 1 };
            }

            queryBuilder.ApplyOrderBy(dto.OrderBy);

            // Add pagination
            if (dto?.Skip != null && dto?.Take != null && dto.Skip >= 0 && dto.Take > 0)
            {
                queryBuilder.ApplyPagination(dto.Take.Value, dto.Skip.Value);
            }

            var users = new UserMapper().MapFromDataTable(DatabaseManager.ExecuteDataTable(queryBuilder.CmdParams));

            return users;
        }
        catch (Exception ex)
        {
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }

    /// <summary>
    /// Creates a new user record in the database.
    /// </summary>
    /// <param name="dto">A <see cref="CreateUserInputDto"/> object containing the details of the user to create.</param>
    /// <returns>A <see cref="User"/> object representing the newly created user.</returns>
    /// <exception cref="AppException">
    /// Thrown if an error occurs during the database operation.
    /// The exception includes a descriptive message and an inner exception for debugging purposes.
    /// </exception>
    public static User CreateUser(CreateUserInputDto dto)
    {
        try
        {
            var sql = @"
                INSERT INTO [User] (FirstName, LastName, Role, Email, Password)
                OUTPUT INSERTED.*
                VALUES (@FirstName, @LastName, @Role, @Email, @Password);";

            DBCommandParams cmdParams = new(sql, CommandType.Text, new()
            {
                ["@FirstName"] = dto?.FirstName == null ? DBNull.Value : dto.FirstName,
                ["@LastName"] = dto?.LastName == null ? DBNull.Value : dto.LastName,
                ["@Role"] = dto.Role.ToString(),
                ["@Email"] = dto.Email,
                ["@Password"] = dto.Password
            });

            var user = new UserMapper().MapFromDataTable(DatabaseManager.ExecuteDataTable(cmdParams))[0];

            return user;
        }
        catch (Exception ex)
        {
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }

    /// <summary>
    /// Updates an existing user record in the database.
    /// </summary>
    /// <param name="user">A <see cref="User"/> object containing the updated details of the user.</param>
    /// <returns>A <see cref="User"/> object representing the updated user.</returns>
    /// <exception cref="AppException">
    /// Thrown if:
    /// <list type="bullet">
    ///     <item>The user with the specified ID does not exist.</item>
    ///     <item>An error occurs during the database operation.</item>
    /// </list>
    /// The exception includes a descriptive message and an inner exception for debugging purposes.
    /// </exception>
    public static User UpdateUser(User user)
    {
        try
        {
            var sql = @"
            UPDATE [User]
            SET FirstName = @FirstName,
                LastName = @LastName,
                Role = @Role,
                Email = @Email,
                Password = @Password
            WHERE Id = @Id
            SELECT *
            FROM [User]
            WHERE Id = @Id";

            DBCommandParams cmdParams = new(sql, CommandType.Text, new()
            {
                ["@Id"] = user.Id,
                ["@FirstName"] = user?.FirstName == null ? DBNull.Value : user.FirstName,
                ["@LastName"] = user?.LastName == null ? DBNull.Value : user.LastName,
                ["@Role"] = user.Role.ToString(),
                ["@Email"] = user.Email,
                ["@Password"] = user.Password
            });

            var users = new UserMapper().MapFromDataTable(DatabaseManager.ExecuteDataTable(cmdParams));

            if (users.Count == 0)
            {
                throw new AppException($"Cant find user with [Id = {user.Id}]", ExceptionStatus.Error);
            }

            return users[0];
        }
        catch (Exception ex)
        {
            if (ex is AppException) throw;
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }

    /// <summary>
    /// Deletes a user record from the database.
    /// </summary>
    /// <param name="dto">A <see cref="DeleteUserInputDto"/> object containing the ID of the user to delete.</param>
    /// <returns><c>true</c> if the user was successfully deleted; otherwise, <c>false</c>.</returns>
    /// <exception cref="AppException">
    /// Thrown if an error occurs during the database operation.
    /// The exception includes a descriptive message and an inner exception for debugging purposes.
    /// </exception>
    public static bool DeleteUser(DeleteUserInputDto dto)
    {
        try
        {
            var @sql = @"
                DELETE [User]
                WHERE Id = @Id";


            DBCommandParams cmdParams = new(sql, CommandType.Text, new() { ["@Id"] = dto.Id });

            int rowsAffected = DatabaseManager.ExecuteNonQuery(cmdParams);

            return rowsAffected > 0;
        }
        catch (Exception ex)
        {
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }
}
