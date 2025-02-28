using Database;
using System.Data;
using Entities;
using Services.Mappers;
using Utilities.Exceptoins;
using Services.DTOs;
using Services.Helpers;

namespace Services.Services;

public class ExamService : BasicCRUDService<Exam>, IGetAllEntitiesService<Exam>, ICreateEntityService<Exam>, IUpdateEntityService<Exam>, IDeleteEntityService<Exam>
{
    public ExamService() : base("Exam", "ExamFullView", new ExamMapper()) { }

    public List<Exam> GetAll(GetAllDto? dto = null) => this.DefaultGetAll(dto);


    public Exam Create(Exam dto)
    {
        try
        {
            var sql = $@"
                INSERT INTO [{TableName}] (Name, StartTime, EndTime, ExamType, Instructions, SubjectId)
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

            var exam = Mapper.MapFromDataTable(Context.ExecuteDataTable(cmdParams))[0];

            return exam;
        }
        catch (Exception ex)
        {
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }

    public Exam Update(Exam dto)
    {
        try
        {
            var sql = $@"
            UPDATE [{TableName}]
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

            var exams = Mapper.MapFromDataTable(Context.ExecuteDataTable(cmdParams));

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

    public bool Delete(int id) => this.DefaultDelete(id);
}
