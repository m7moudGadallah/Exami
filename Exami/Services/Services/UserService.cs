using Database;
using System.Data;
using Entities;
using Services.DTOs;
using Services.Mappers;
using Utilities.Exceptoins;

namespace Services.Services;

public static class UserService
{
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
                ["Role"] = dto.Role.ToString(),
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
