using Database;
using Entities;
using Services.DTOs;
using Services.Helpers;
using Services.Mappers;
using System.Data;
using Utilities.Exceptoins;

namespace Services.Services;

public class StudentExamService : BasicCRUDService<StudentExam>, IGetAllEntitiesService<StudentExam>, ICreateEntityService<StudentExam>, IUpdateEntityService<StudentExam>, IDeleteEntityService<StudentExam>
{
    public StudentExamService() : base("StudentExam", "StudentExamFullView", new StudentExamMapper()) { }

    public List<StudentExam> GetAll(GetAllDto? dto = null) => this.DefaultGetAll(dto);

    public StudentExam Create(StudentExam dto)
    {
        try
        {
            var sql = $@"
                INSERT INTO [{TableName}] (ExamId, StudentId, SubmissionTime, CreatedAt, UpdatedAt)
                OUTPUT INSERTED.*
                VALUES (@ExamId, @StudentId, @SubmissionTime, GETDATE(), GETDATE());";

            DbCommandParams cmdParams = new(sql, CommandType.Text, new()
            {
                ["@ExamId"] = dto.ExamId,
                ["@StudentId"] = dto.StudentId,
                ["@SubmissionTime"] = dto.SubmissionTime == null ? DBNull.Value : dto.SubmissionTime,
            });

            var exam = Mapper.MapFromDataTable(Context.ExecuteDataTable(cmdParams))[0];

            return exam;
        }
        catch (Exception ex)
        {
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }

    public StudentExam Update(StudentExam dto)
    {
        try
        {
            var sql = $@"
            UPDATE [{TableName}]
            SET ExamId = @ExamId,
                StudentId = @StudentId,
                SubmissionTime = @SubmissionTime,
                UpdatedAt = GETDATE()
            OUTPUT INSERTED.*
            WHERE Id = @Id";

            DbCommandParams cmdParams = new(sql, CommandType.Text, new()
            {
                ["@Id"] = dto.Id,
                ["@ExamId"] = dto.ExamId,
                ["@StudentId"] = dto.StudentId,
                ["@SubmissionTime"] = (dto.SubmissionTime == null) ? DBNull.Value : dto.SubmissionTime,
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
