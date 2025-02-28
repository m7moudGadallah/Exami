namespace Services.Services;

public interface ICreateEntityService<T> where T : class
{
    public T Create(T dto);
}
