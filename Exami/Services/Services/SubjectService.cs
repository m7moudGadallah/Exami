using Database;
using Entities;
using Services.DTOs;
using Services.Helpers;
using Services.Mappers;
using System.Data;
using Utilities.Exceptoins;

namespace Services.Services;

public class SubjectService : BasicCRUDService<Subject>, IGetAllEntitiesService<Subject>, ICreateEntityService<Subject>, IUpdateEntityService<Subject>, IDeleteEntityService<Subject>
{
    public SubjectService() : base("Subject", "SubjectFullView", new SubjectMapper()) { }

    public List<Subject> GetAll(GetAllDto? dto = null) => this.DefaultGetAll(dto);


    public Subject Create(Subject dto)
    {
        try
        {
            var sql = $@"
                INSERT INTO [{TableName}] (Name, TeacherId)
                OUTPUT INSERTED.*
                VALUES (@Name, @TeacherId);";

            DbCommandParams cmdParams = new(sql, CommandType.Text, new()
            {
                ["@Name"] = dto.Name,
                ["@TeacherId"] = dto.TeacherId == null ? DBNull.Value : dto.TeacherId,
            });

            var subject = Mapper.MapFromDataTable(Context.ExecuteDataTable(cmdParams))[0];

            return subject;
        }
        catch (Exception ex)
        {
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }

    public Subject Update(Subject dto)
    {
        try
        {
            var sql = $@"
            UPDATE [{TableName}]
            SET Name = @Name,
                TeacherId = @TeacherId
            OUTPUT INSERTED.*
            WHERE Id = @Id";

            DbCommandParams cmdParams = new(sql, CommandType.Text, new()
            {
                ["@Id"] = dto.Id,
                ["@Name"] = dto.Name,
                ["@TeacherId"] = dto.TeacherId == null ? DBNull.Value : dto.TeacherId,
            });

            var subjects = Mapper.MapFromDataTable(Context.ExecuteDataTable(cmdParams));

            if (subjects.Count == 0)
            {
                throw new AppException($"Cant find subject with [Id = {dto.Id}]", ExceptionStatus.Error);
            }

            return subjects[0];
        }
        catch (Exception ex)
        {
            if (ex is AppException) throw;
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }

    public bool Delete(int id) => this.DefaultDelete(id);
}
