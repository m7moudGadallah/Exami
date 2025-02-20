using Database;
using System.Data;
using Entities;
using Services.DTOs;
using Services.Mappers;
using Utilities.Exceptoins;
using System.Text;

namespace Services.Services;

/// <summary>
/// Provides methods to manage exams, including retrieving exam details by ID.
/// </summary>
public static class ExamService
{
    /// <summary>
    /// Retrieves a list of exams based on the provided filters.
    /// </summary>
    /// <param name="dto">A <see cref="GetAllExamsInputDto"/> object containing key-value pairs of filters to apply.</param>
    /// <returns>A list of <see cref="Exam"/> objects that match the specified filters.</returns>
    /// <exception cref="AppException">
    /// Thrown if an error occurs during the database operation.
    /// </exception>
    public static List<Exam> GetAllExams(GetAllExamsInputDto dto)
    {
        try
        {
            var sql = @"
                SELECT *
                FROM [ExamFullView]
                WHERE 1=1";

            SqlQueryBuilder queryBuilder = new(new(sql, CommandType.Text, new() { }));

            // Add filters dynamically
            if (dto?.Filters != null)
            {
                queryBuilder.ApplyFilters(dto.Filters);
            }

            // Add ordering
            if (dto?.OrderBy == null || dto.OrderBy.Count == 0)
            {
                dto.OrderBy = new() { ["Id"] = 1 };
            }

            queryBuilder.ApplyOrderBy(dto.OrderBy);

            // Add pagination
            if (dto?.Skip != null && dto?.Take != null && dto.Skip >= 0 && dto.Take > 0)
            {
                queryBuilder.ApplyPagination(dto.Take.Value, dto.Skip.Value);
            }

            var exams = new ExamMapper().MapFromDataTable(DatabaseManager.ExecuteDataTable(queryBuilder.CmdParams));

            return exams;
        }
        catch (Exception ex)
        {
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }

    public static Exam CreateExam(CreateExamInputDto dto)
    {
        try
        {
            var sql = @"
                INSERT INTO [Exam] (Name, StartTime, EndTime, ExamType, Instructions, SubjectId)
                OUTPUT INSERTED.*
                VALUES (@Name, @StartTime, @EndTime, @ExamType, @Instructions, @SubjectId);";

            DBCommandParams cmdParams = new(sql, CommandType.Text, new() { ["@Name"] = dto.Name, ["@StartTime"] = dto.StartTime, ["@EndTime"] = dto.EndTime, ["@ExamType"] = dto.ExamType.ToString(), ["@Instructions"] = dto?.Instructions == null ? DBNull.Value : dto.Instructions, ["@SubjectId"] = dto?.SubjectId == null ? DBNull.Value : dto.SubjectId });

            var exam = new ExamMapper().MapFromDataTable(DatabaseManager.ExecuteDataTable(cmdParams))[0];

            return exam;
        }
        catch (Exception ex)
        {
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }

    public static Exam UpdateExam(Exam exam)
    {
        try
        {
            var sql = @"
            UPDATE [Exam]
            SET Name = @Name,
                StartTime = @StartTime,
                EndTime = @EndTime,
                ExamType = @ExamType,
                SubjectId = @SubjectId,
                Instructions = @Instructions
            WHERE Id = @Id
            SELECT *
            FROM [Exam]
            WHERE Id = @Id";

            DBCommandParams cmdParams = new(sql, CommandType.Text, new()
            {
                ["@Id"] = exam.Id,
                ["@Name"] = exam.Name,
                ["@StartTime"] = exam.StartTime,
                ["@EndTime"] = exam.EndTime,
                ["@ExamType"] = exam.ExamType.ToString(),
                ["@SubjectId"] = (exam.SubjectId == null) ? DBNull.Value : exam.SubjectId,
                ["@Instructions"] = (exam?.Instructions == null) ? DBNull.Value : exam.Instructions,
            });

            var exams = new ExamMapper().MapFromDataTable(DatabaseManager.ExecuteDataTable(cmdParams));

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

    public static bool DeleteExam(DeleteExamInputDto dto)
    {
        try
        {
            var @sql = @"
                DELETE [Exam]
                WHERE Id = @Id";


            DBCommandParams cmdParams = new(sql, CommandType.Text, new() { ["@Id"] = dto.Id });

            int rowsAffected = DatabaseManager.ExecuteNonQuery(cmdParams);

            return rowsAffected > 0;
        }
        catch (Exception ex)
        {
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }
}
