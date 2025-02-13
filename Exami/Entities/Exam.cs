namespace Entities;

public record Exam(int Id, string? Name, int SubjectId, DateTime? StartTime, 
                    DateTime? EndTime, string ExamType, string Instructions);
