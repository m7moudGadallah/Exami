namespace Entities;

public record Exam
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int? SubjectId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public ExamType ExamType { get; set; }
    public string? Instructions { get; set; }
    public Subject Subject { get; set; }
}
