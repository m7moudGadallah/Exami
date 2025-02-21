using Database;
using Entities;
using Microsoft.IdentityModel.Tokens;
using Services.DTOs;
using Services.Mappers;
using System.Data;
using System.Data.Common;
using System.Text;
using Utilities.Exceptoins;

namespace Services.Services;

public class StudentExamService : CRUDService<StudentExam>
{
    public StudentExamService() : base("StudentExam", "StudentExamFullView", new StudentExamMapper()) { }

    public override StudentExam Create(StudentExam dto)
    {
        try
        {
            var sql = $@"
                INSERT INTO [{_tableName}] (ExamId, StudentId, SubmissionTime, CreatedAt, UpdatedAt)
                OUTPUT INSERTED.*
                VALUES (@ExamId, @StudentId, @SubmissionTime, GETDATE(), GETDATE());";

            DbCommandParams cmdParams = new(sql, CommandType.Text, new()
            {
                ["@ExamId"] = dto.ExamId,
                ["@StudentId"] = dto.StudentId,
                ["@SubmissionTime"] = dto.SubmissionTime == null ? DBNull.Value : dto.SubmissionTime,
            });

            var exam = _mapper.MapFromDataTable(_dbContext.ExecuteDataTable(cmdParams))[0];

            return exam;
        }
        catch (Exception ex)
        {
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }

    public override StudentExam Update(StudentExam dto)
    {
        try
        {
            var sql = $@"
            UPDATE [{_tableName}]
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
