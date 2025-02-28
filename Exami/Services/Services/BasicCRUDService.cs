using Services.Mappers;

namespace Services.Services;

public abstract class BasicCRUDService<T> : BasicService, IBasicCRUDService<T> where T : class
{
    protected BasicCRUDService(string tableName, string viewName, BaseMapper<T> mapper) : base()
    {
        TableName = tableName;
        ViewName = viewName;
        Mapper = mapper;
    }

    protected BasicCRUDService(string tableName, BaseMapper<T> mapper) : this(tableName, tableName, mapper) { }

    public string ViewName { get; }

    public string TableName { get; }

    public BaseMapper<T> Mapper { get; }
}
