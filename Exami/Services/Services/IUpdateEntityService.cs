namespace Services.Services;

public interface IUpdateEntityService<T> where T : class
{
    public T Update(T dto);
}
