using Services.DTOs;

namespace Services.Services;

public interface IGetAllEntitiesService<T> where T : class
{
    public List<T> GetAll(GetAllDto? dto = null);
}
