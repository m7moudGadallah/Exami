using Database;
using System.Data;
using Entities;
using Services.DTOs;
using Services.Mappers;
using Utilities.Exceptoins;

namespace Services.Services;

public class ExamQuestionService : CRUDService<ExamQuestion>
{
    public ExamQuestionService() : base("ExamQuestion", "ExamQuestionFullView", new ExamQuestionMapper()) { }

    public override ExamQuestion Create(ExamQuestion dto)
    {
        try
        {
            var sql = $@"
                INSERT INTO [{_tableName}] (ExamId, QuestionId)
                OUTPUT INSERTED.*
                VALUES (@ExamId, @QuestionId);";

            DbCommandParams cmdParams = new(sql, CommandType.Text, new()
            {
                ["@ExamId"] = dto.ExamId,
                ["@QuestionId"] = dto.QuestionId
            });

            var examQuestion = _mapper.MapFromDataTable(_dbContext.ExecuteDataTable(cmdParams))[0];

            return examQuestion;
        }
        catch (Exception ex)
        {
            throw new AppException(ex.Message, ExceptionStatus.Fail, ex.InnerException);
        }
    }

    public override ExamQuestion Update(ExamQuestion dto)
    {
        throw new NotImplementedException();
    }
}
