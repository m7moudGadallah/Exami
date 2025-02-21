namespace Entities;

public record Answer
{
    public int Id { get; set; }
    public int? QuestionId { get; set; }
    public string AnswerText { get; set; }
    public bool IsCorrect { get; set; }
}
