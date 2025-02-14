namespace Entities;

public record StudentExam(int Id, int ExamId, int StudentId, DateTime? SubmissionTime,
                    DateTime CreatedAt, DateTime UpdatedAt);
