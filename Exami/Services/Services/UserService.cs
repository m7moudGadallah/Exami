using Database;
using System.Data;
using Entities;
using Services.Mappers;
using Utilities.Exceptoins;
using Services.DTOs;
using Services.Helpers;

namespace Services.Services;

public class UserService : BasicCRUDService<User>, IGetAllEntitiesService<User>, ICreateEntityService<User>, IUpdateEntityService<User>, IDeleteEntityService<User>
{
    public UserService() : base("User", new UserMapper()) { }

    public List<User> GetAll(GetAllDto? dto = null) => this.DefaultGetAll(dto);


    public User Create(User dto)
    {
        try
        {
            var sql = $@"
                INSERT INTO [{TableName}] (FirstName, LastName, Role, Email, Password)
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

            var user = Mapper.MapFromDataTable(Context.ExecuteDataTable(cmdParams))[0];

            return user;
        }
        catch (Exception ex)
        {
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }

    public User Update(User dto)
    {
        try
        {
            var sql = $@"
            UPDATE [{TableName}]
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

            var users = Mapper.MapFromDataTable(Context.ExecuteDataTable(cmdParams));

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

    public bool Delete(int id) => this.DefaultDelete(id);
}
