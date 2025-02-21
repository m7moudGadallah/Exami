using Database;
using System.Data;
using Entities;
using Services.DTOs;
using Services.Mappers;
using Utilities.Exceptoins;

namespace Services.Services;

public class QuestionService : CRUDService<Question>
{
    public QuestionService() : base("Question", "QuestionFullView", new QuestionMapper()) { }

    public override Question Create(Question dto)
    {
        try
        {
            var sql = $@"
                INSERT INTO [{_tableName}] (Marks, Body, QuestionType, SubjectId)
                OUTPUT INSERTED.*
                VALUES (@Marks, @Body, @QuestionType, @SubjectId);";

            DbCommandParams cmdParams = new(sql, CommandType.Text, new()
            {
                ["@Marks"] = dto.Marks,
                ["@Body"] = dto.Body,
                ["@QuestionType"] = dto.QuestionType.ToString(),
                ["@SubjectId"] = dto?.SubjectId == null ? DBNull.Value : dto.SubjectId
            });

            var question = _mapper.MapFromDataTable(_dbContext.ExecuteDataTable(cmdParams))[0];

            return question;
        }
        catch (Exception ex)
        {
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }

    public override Question Update(Question dto)
    {
        try
        {
            var sql = $@"
            UPDATE [{_tableName}]
            SET Marks = @Marks,
                Body = @Body,
                QuestionType = @QuestionType,
                SubjectId = @SubjectId
            OUTPUT INSERTED.*
            WHERE Id = @Id;";

            DbCommandParams cmdParams = new(sql, CommandType.Text, new()
            {
                ["@Id"] = dto.Id,
                ["@Body"] = dto.Body,
                ["@Marks"] = dto.Marks,
                ["@QuestionType"] = dto.QuestionType.ToString(),
                ["@SubjectId"] = (dto.SubjectId == null) ? DBNull.Value : dto.SubjectId,
            });

            var questions = _mapper.MapFromDataTable(_dbContext.ExecuteDataTable(cmdParams));

            if (questions.Count == 0)
            {
                throw new AppException($"Cant find question with [Id = {dto.Id}]", ExceptionStatus.Error);
            }

            return questions[0];
        }
        catch (Exception ex)
        {
            if (ex is AppException) throw;
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }
}
