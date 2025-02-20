using Database;
using System.Data;
using System.Text;
using Entities;
using Services.DTOs;
using Services.Mappers;
using Utilities.Exceptoins;

namespace Services.Services;

/// <summary>
/// Provides methods to manage questions, including retrieving a list of questions based on filters.
/// </summary>
public static class QuestionService
{
    /// <summary>
    /// Retrieves a list of questions from the database based on the provided filters, ordering, and pagination parameters.
    /// </summary>
    /// <param name="dto">An optional <see cref="GetAllQuestionInputDto"/> object containing filtering, ordering, and pagination parameters.</param>
    /// <returns>
    /// A list of <see cref="Question"/> objects that match the specified filters and ordering criteria.
    /// If no filters are provided, all questions are returned.
    /// </returns>
    /// <exception cref="AppException">
    /// Thrown if:
    /// <list type="bullet">
    ///     <item>An error occurs during the database operation.</item>
    ///     <item>Invalid or unsupported filters are provided in the <paramref name="dto"/>.</item>
    ///     <item>Pagination parameters (<see cref="GetAllQuestionInputDto.Skip"/>, <see cref="GetAllQuestionInputDto.Take"/>) are invalid (e.g., negative values).</item>
    /// </list>
    /// The exception includes a descriptive message and an inner exception for debugging purposes.
    /// </exception>
    /// <remarks>
    /// This method dynamically constructs a SQL query using the provided filters, ordering, and pagination parameters.
    /// It uses a predefined SQL view named <c>QuestionFullView</c> to fetch the data.
    /// </remarks>
    public static List<Question> GetAllQuestions(GetAllQuestionInputDto? dto)
    {
        try
        {
            var sql = @"
                SELECT *
                FROM [QuestionFullView]
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

            var quesetions = new QuestionMapper().MapFromDataTable(DatabaseManager.ExecuteDataTable(queryBuilder.CmdParams));

            return quesetions;
        }
        catch (Exception ex)
        {
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }

    public static Question CreateQuestion(CreateQuestionDto dto)
    {
        try
        {
            var sql = @"
                INSERT INTO [Question] (Marks, Body, QuestionType, SubjectId)
                OUTPUT INSERTED.*
                VALUES (@Marks, @Body, @QuestionType, @SubjectId);";

            DBCommandParams cmdParams = new(sql, CommandType.Text, new() { ["@Marks"] = dto.Marks, ["@Body"] = dto.Body, ["@QuestionType"] = dto.QuestionType.ToString(), ["@SubjectId"] = dto?.SubjectId == null ? DBNull.Value : dto.SubjectId });

            var question = new QuestionMapper().MapFromDataTable(DatabaseManager.ExecuteDataTable(cmdParams))[0];

            return question;
        }
        catch (Exception ex)
        {
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }

    public static bool DeleteQuestion(DeleteQuestionDto dto)
    {
        try
        {
            var @sql = @"
                DELETE [Question]
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
