using Entities;
using Services.DTOs;
using Services.Mappers;

namespace Services.Services;

public class ExamQuestionService : CRUDService<ExamQuestion>
{
    public ExamQuestionService() : base("ExamQuestion", "ExamQuestionFullView", new ExamQuestionMapper()) { }

    public override ExamQuestion Create(ExamQuestion dto)
    {
        throw new NotImplementedException();
    }

    public override ExamQuestion Update(ExamQuestion dto)
    {
        throw new NotImplementedException();
    }
}
