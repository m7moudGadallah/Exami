namespace Services.Services;

public interface IDeleteEntityService<T> where T : class
{
    public bool Delete(int id);
}
