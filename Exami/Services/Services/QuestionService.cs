﻿using Database;
using System.Data;
using Entities;
using Services.DTOs;
using Services.Mappers;
using Utilities.Exceptoins;

namespace Services.Services;

/// <summary>
/// Provides methods to manage questions, including retrieving, creating, updating, and deleting questions.
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

    /// <summary>
    /// Creates a new question in the database.
    /// </summary>
    /// <param name="dto">A <see cref="CreateQuestionDto"/> object containing the details of the question to create.</param>
    /// <returns>A <see cref="Question"/> object representing the newly created question.</returns>
    /// <exception cref="AppException">
    /// Thrown if an error occurs during the database operation.
    /// The exception includes a descriptive message and an inner exception for debugging purposes.
    /// </exception>
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

    /// <summary>
    /// Updates an existing question in the database.
    /// </summary>
    /// <param name="question">A <see cref="Question"/> object containing the updated details of the question.</param>
    /// <returns>A <see cref="Question"/> object representing the updated question.</returns>
    /// <exception cref="AppException">
    /// Thrown if:
    /// <list type="bullet">
    ///     <item>The question with the specified ID does not exist.</item>
    ///     <item>An error occurs during the database operation.</item>
    /// </list>
    /// The exception includes a descriptive message and an inner exception for debugging purposes.
    /// </exception>
    public static Question UpdateQuestion(Question question)
    {
        try
        {
            var sql = @"
            UPDATE [Question]
            SET Marks = @Marks,
                Body = @Body,
                QuestionType = @QuestionType,
                SubjectId = @SubjectId
            WHERE Id = @Id
            SELECT *
            FROM [Question]
            WHERE Id = @Id";

            DBCommandParams cmdParams = new(sql, CommandType.Text, new()
            {
                ["@Id"] = question.Id,
                ["@Body"] = question.Body,
                ["@Marks"] = question.Marks,
                ["@QuestionType"] = question.QuestionType.ToString(),
                ["@SubjectId"] = (question.SubjectId == null) ? DBNull.Value : question.SubjectId,
            });

            var questions = new QuestionMapper().MapFromDataTable(DatabaseManager.ExecuteDataTable(cmdParams));

            if (questions.Count == 0)
            {
                throw new AppException($"Cant find question with [Id = {question.Id}]", ExceptionStatus.Error);
            }

            return questions[0];
        }
        catch (Exception ex)
        {
            if (ex is AppException) throw;
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }

    /// <summary>
    /// Deletes a question from the database.
    /// </summary>
    /// <param name="dto">A <see cref="DeleteQuestionDto"/> object containing the ID of the question to delete.</param>
    /// <returns><c>true</c> if the question was successfully deleted; otherwise, <c>false</c>.</returns>
    /// <exception cref="AppException">
    /// Thrown if an error occurs during the database operation.
    /// The exception includes a descriptive message and an inner exception for debugging purposes.
    /// </exception>
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
