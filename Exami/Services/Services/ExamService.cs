using Database;
using System.Data;
using Entities;
using Services.Mappers;
using Utilities.Exceptoins;

namespace Services.Services;

public class ExamService : CRUDService<Exam>
{
    public ExamService() : base("Exam", "ExamFullView", new ExamMapper()) { }

    public override Exam Create(Exam dto)
    {
        try
        {
            var sql = $@"
                INSERT INTO [{_tableName}] (Name, StartTime, EndTime, ExamType, Instructions, SubjectId)
                OUTPUT INSERTED.*
                VALUES (@Name, @StartTime, @EndTime, @ExamType, @Instructions, @SubjectId);";

            DbCommandParams cmdParams = new(sql, CommandType.Text, new()
            {
                ["@Name"] = dto.Name,
                ["@StartTime"] = dto.StartTime,
                ["@EndTime"] = dto.EndTime,
                ["@ExamType"] = dto.ExamType.ToString(),
                ["@Instructions"] = dto?.Instructions == null ? DBNull.Value : dto.Instructions,
                ["@SubjectId"] = dto?.SubjectId == null ? DBNull.Value : dto.SubjectId
            });

            var exam = _mapper.MapFromDataTable(_dbContext.ExecuteDataTable(cmdParams))[0];

            return exam;
        }
        catch (Exception ex)
        {
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }

    public override Exam Update(Exam dto)
    {
        try
        {
            var sql = $@"
            UPDATE [{_tableName}]
            SET Name = @Name,
                StartTime = @StartTime,
                EndTime = @EndTime,
                ExamType = @ExamType,
                SubjectId = @SubjectId,
                Instructions = @Instructions
            OUTPUT INSERTED.*
            WHERE Id = @Id;";

            DbCommandParams cmdParams = new(sql, CommandType.Text, new()
            {
                ["@Id"] = dto.Id,
                ["@Name"] = dto.Name,
                ["@StartTime"] = dto.StartTime,
                ["@EndTime"] = dto.EndTime,
                ["@ExamType"] = dto.ExamType.ToString(),
                ["@SubjectId"] = (dto.SubjectId == null) ? DBNull.Value : dto.SubjectId,
                ["@Instructions"] = (dto?.Instructions == null) ? DBNull.Value : dto.Instructions,
            });

            var exams = _mapper.MapFromDataTable(_dbContext.ExecuteDataTable(cmdParams));

            if (exams.Count == 0)
            {
                throw new AppException($"Cant find exam with [Id = {dto.Id}]", ExceptionStatus.Error);
            }

            return exams[0];
        }
        catch (Exception ex)
        {
            if (ex is AppException) throw;
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }
}
