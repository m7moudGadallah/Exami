namespace Entities;

public record StudentExam
{
    public int Id { get; set; }
    public int ExamId { get; set; }
    public int StudentId { get; set; }
    public DateTime? SubmissionTime { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public User Student { get; set; }
    public Exam Exam { get; set; }
}
