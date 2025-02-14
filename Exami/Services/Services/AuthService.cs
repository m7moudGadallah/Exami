using Database;
using Entities;
using Services.DTOs;
using Services.Mappers;
using System.Data;
using Utilities.Exceptoins;

namespace Services.Services;

public static class AuthService
{
    public static User Login(LoginInputDto data)
    {
        var sql = @"
            SELECT *
            FROM [User]
            WHERE Email =  @Email";

        DBCommandParams cmdParams = new(sql, CommandType.Text, new Dictionary<string, object>() { ["@Email"] = data.Email });
        var users = new UserMapper().MapFromDataTable(DatabaseManager.ExecuteDataTable(cmdParams));

        if (users.Count == 0 || users[0]?.Password != data.Password)
        {
            throw new AppException("Invalid Email or Passowrd!", ExceptionStatus.Error);
        }

        return users[0];
    }
}
