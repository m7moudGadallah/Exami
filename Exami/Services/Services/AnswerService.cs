using Entities;
using Services.DTOs;
using Services.Helpers;
using Services.Mappers;

namespace Services.Services;

public class AnswerService : BasicCRUDService<Answer>, IGetAllEntitiesService<Answer>, IDeleteEntityService<Answer>
{
    public AnswerService() : base("Answer", new AnswerMapper()) { }

    public List<Answer> GetAll(GetAllDto? dto = null) => this.DefaultGetAll(dto);

    public bool Delete(int id) => this.DefaultDelete(id);
}
