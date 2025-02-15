using Database;
using Entities;
using Services.DTOs;
using Services.Mappers;
using System.Data;
using System.Text;
using Utilities.Exceptoins;

namespace Services.Services;

/// <summary>
/// Provides methods to manage student exams, including retrieving, updating, and filtering exam records.
/// </summary>
public class StudentExamService
{
    /// <summary>
    /// Retrieves a list of student exams based on the provided filters.
    /// </summary>
    /// <param name="dto">A <see cref="GetStudentExamsDto"/> object containing key-value pairs of filters.</param>
    /// <returns>A list of <see cref="StudentExam"/> objects matching the filters.</returns>
    /// <exception cref="AppException">Thrown if an error occurs during database execution.</exception>
    public static List<StudentExam> GetAllStudentExams(GetAllStudentExamsInputDto dto)
    {
        try
        {
            var sql = new StringBuilder(@"
                SELECT *
                FROM [StudentExam]
                WHERE 1=1");


            DBCommandParams cmdParams = new(sql.ToString(), CommandType.Text, new() { });

            // Add filters dynamically
            foreach (var filter in dto.Filters)
            {
                string columnName = filter.Key;
                object value = filter.Value;

                if (value != null)
                {
                    sql.Append($" AND {columnName} = @{columnName}");
                    cmdParams.Parameters.Add($"@{columnName}", value);
                }
            }

            var exams = new StudentExamMapper().MapFromDataTable(DatabaseManager.ExecuteDataTable(cmdParams));

            return exams;
        }
        catch (Exception ex)
        {
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }

    /// <summary>
    /// Retrieves a single student exam by its ID.
    /// </summary>
    /// <param name="dto">A <see cref="GetStudentExamInputDto"/> object containing the ID of the exam to retrieve.</param>
    /// <returns>A <see cref="StudentExam"/> object if found; otherwise, <see langword="null"/>.</returns>
    /// <exception cref="AppException">Thrown if an error occurs during database execution.</exception> 
    public static StudentExam? GetStudentExam(GetStudentExamInputDto dto)
    {
        try
        {
            var sql = @"
            SELECT *
            FROM [StudentExam]
            WHERE Id = @Id";

            DBCommandParams cmdParams = new(sql, CommandType.Text, new() { ["@Id"] = dto.Id });

            var exams = new StudentExamMapper().MapFromDataTable(DatabaseManager.ExecuteDataTable(cmdParams));

            if (exams.Count == 0) return null;

            return exams[0];
        }
        catch (Exception ex)
        {
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }

    /// <summary>
    /// Updates an existing student exam record in the database.
    /// </summary>
    /// <param name="exam">A <see cref="StudentExam"/> object containing the updated exam details.</param>
    /// <returns>The updated <see cref="StudentExam"/> object.</returns>
    /// <exception cref="AppException">
    /// Thrown if the exam with the specified ID is not found or if an error occurs during database execution.
    /// </exception>
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
