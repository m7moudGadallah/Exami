namespace Entities;

public record Subject
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int? TeacherId { get; set; }
    public User Teacher { get; set; }
}
