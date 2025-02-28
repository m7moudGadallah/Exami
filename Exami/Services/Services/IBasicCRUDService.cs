using Services.Mappers;

namespace Services.Services;

public interface IBasicCRUDService<T> : IBasicService where T : class
{
    public string ViewName { get; }
    public string TableName { get; }
    public BaseMapper<T> Mapper { get; }
}
