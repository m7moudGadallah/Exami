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
    /// Retrieves a list of questions based on the provided filters.
    /// </summary>
    /// <param name="dto">A <see cref="GetAllQuestionInputDto"/> object containing key-value pairs of filters to apply.</param>
    /// <returns>A list of <see cref="Question"/> objects that match the specified filters.</returns>
    /// <exception cref="AppException">
    /// Thrown if an error occurs during the database operation or if invalid filters are provided.
    /// </exception>
    public static List<Question> GetAllQuestions(GetAllQuestionInputDto dto)
    {
        try
        {
            var sql = new StringBuilder(@"
                SELECT *
                FROM [Question]
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

            var quesetions = new QuestionMapper().MapFromDataTable(DatabaseManager.ExecuteDataTable(cmdParams with { Sql = sql.ToString() }));

            return quesetions;
        }
        catch (Exception ex)
        {
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }
}
