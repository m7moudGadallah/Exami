using Database;
using Entities;
using Services.DTOs;
using Services.Mappers;
using System.Data;
using Utilities.Exceptoins;

namespace Services.Services;

public class StudentExamService
{
    public static StudentExam? GetStudentExam(GetStudentExamInputDto data)
    {
        try
        {
            var sql = @"
            SELECT *
            FROM [StudentExam]
            WHERE Id = @Id";

            DBCommandParams cmdParams = new(sql, CommandType.Text, new() { ["@Id"] = data.Id });

            var exams = new StudentExamMapper().MapFromDataTable(DatabaseManager.ExecuteDataTable(cmdParams));

            if (exams.Count == 0) return null;

            return exams[0];
        }
        catch (Exception ex)
        {
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }

    public static StudentExam UpdateStudentExam(StudentExam exam)
    {
        try
        {
            var sql = @"
            UPDATE [StudentExam]
            SET ExamId = @ExamId,
                StudentId = @StudentId,
                SubmissionTime = @SubmissionTime,
                UpdatedAt = GETDATE()
            WHERE Id = @Id
            SELECT *
            FROM [StudentExam]
            WHERE Id = @Id";

            DBCommandParams cmdParams = new(sql, CommandType.Text, new()
            {
                ["@Id"] = exam.Id,
                ["@ExamId"] = exam.ExamId,
                ["@StudentId"] = exam.StudentId,
                ["@SubmissionTime"] = (exam.SubmissionTime == null) ? DBNull.Value : exam.SubmissionTime,
            });

            var exams = new StudentExamMapper().MapFromDataTable(DatabaseManager.ExecuteDataTable(cmdParams));

            if (exams.Count == 0)
            {
                throw new AppException($"Cant find exam with [Id = {exam.Id}]", ExceptionStatus.Error);
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
