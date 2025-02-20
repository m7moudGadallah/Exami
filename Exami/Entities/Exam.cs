namespace Entities;

public record Exam(int Id, string Name, int? SubjectId, DateTime StartTime,
                    DateTime EndTime, ExamType ExamType, string? Instructions)
{
    public Subject Subject { get; set; }
}
