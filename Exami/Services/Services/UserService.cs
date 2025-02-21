using Database;
using System.Data;
using Entities;
using Services.Mappers;
using Utilities.Exceptoins;

namespace Services.Services;

public class UserService : CRUDService<User>
{
    public UserService() : base("User", new UserMapper()) { }

    public override User Create(User dto)
    {
        try
        {
            var sql = $@"
                INSERT INTO [{_tableName}] (FirstName, LastName, Role, Email, Password)
                OUTPUT INSERTED.*
                VALUES (@FirstName, @LastName, @Role, @Email, @Password);";

            DbCommandParams cmdParams = new(sql, CommandType.Text, new()
            {
                ["@FirstName"] = dto?.FirstName == null ? DBNull.Value : dto.FirstName,
                ["@LastName"] = dto?.LastName == null ? DBNull.Value : dto.LastName,
                ["@Role"] = dto.Role.ToString(),
                ["@Email"] = dto.Email,
                ["@Password"] = dto.Password
            });

            var user = new UserMapper().MapFromDataTable(_dbContext.ExecuteDataTable(cmdParams))[0];

            return user;
        }
        catch (Exception ex)
        {
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }

    public override User Update(User dto)
    {
        try
        {
            var sql = $@"
            UPDATE [{_tableName}]
            SET FirstName = @FirstName,
                LastName = @LastName,
                Role = @Role,
                Email = @Email,
                Password = @Password
            OUTPUT INSERTED.*
            WHERE Id = @Id;";

            DbCommandParams cmdParams = new(sql, CommandType.Text, new()
            {
                ["@Id"] = dto.Id,
                ["@FirstName"] = dto?.FirstName == null ? DBNull.Value : dto.FirstName,
                ["@LastName"] = dto?.LastName == null ? DBNull.Value : dto.LastName,
                ["@Role"] = dto.Role.ToString(),
                ["@Email"] = dto.Email,
                ["@Password"] = dto.Password
            });

            var users = new UserMapper().MapFromDataTable(_dbContext.ExecuteDataTable(cmdParams));

            if (users.Count == 0)
            {
                throw new AppException($"Cant find user with [Id = {dto.Id}]", ExceptionStatus.Error);
            }

            return users[0];
        }
        catch (Exception ex)
        {
            if (ex is AppException) throw;
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }
}
