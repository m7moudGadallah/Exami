using Entities;
using Services.Mappers;

namespace Services.Services;

public class AnswerService : CRUDService<Answer>
{
    public AnswerService() : base("Answer", new AnswerMapper()) { }

    public override Answer Create(Answer dto)
    {
        throw new NotImplementedException();
    }

    public override Answer Update(Answer dto)
    {
        throw new NotImplementedException();
    }
}
