namespace Entities;

public record StudentAnswer
{
    public int StudentExamId { get; set; }
    public int AnswerId { get; set; }
    public DateTime? CreatedAt { get; set; }
}
