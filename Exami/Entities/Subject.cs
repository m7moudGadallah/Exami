namespace Entities;

public record Subject(int Id, string Name, int? TeacherId)
{
    public User Teacher { get; set; }
}
