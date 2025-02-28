namespace Entities;

public record ExamStudentPerformance
{
    public int ExamId { get; set; }
    public int StudentExamId { get; set; }
    public string ExamName { get; set; } = string.Empty;
    public string StudentName { get; set; } = string.Empty;
    public DateTime ExamStartTime { get; set; }
    public DateTime? ExamSubmissionTime { get; set; }
    public double StudentScore { get; set; }
}
