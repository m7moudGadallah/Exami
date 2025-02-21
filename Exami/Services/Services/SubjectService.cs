using Database;
using Entities;
using Services.DTOs;
using Services.Mappers;
using System.Data;
using Utilities.Exceptoins;

namespace Services.Services;

public class SubjectService : CRUDService<Subject>
{
    public SubjectService() : base("Subject", "SubjectFullView", new SubjectMapper()) { }

    public override Subject Create(Subject dto)
    {
        try
        {
            var sql = $@"
                INSERT INTO [{_tableName}] (Name, TeacherId)
                OUTPUT INSERTED.*
                VALUES (@Name, @TeacherId);";

            DbCommandParams cmdParams = new(sql, CommandType.Text, new()
            {
                ["@Name"] = dto.Name,
                ["@TeacherId"] = dto.TeacherId == null ? DBNull.Value : dto.TeacherId,
            });

            var subject = _mapper.MapFromDataTable(_dbContext.ExecuteDataTable(cmdParams))[0];

            return subject;
        }
        catch (Exception ex)
        {
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }

    public override Subject Update(Subject dto)
    {
        try
        {
            var sql = $@"
            UPDATE [{_tableName}]
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

            var subjects = _mapper.MapFromDataTable(_dbContext.ExecuteDataTable(cmdParams));

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
}
