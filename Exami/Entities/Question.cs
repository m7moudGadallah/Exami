namespace Entities;

public record Question
{
    public int Id { get; set; }
    public double Marks { get; set; }
    public string Body { get; set; }
    public QuestionType QuestionType { get; set; }
    public int? SubjectId { get; set; }
    public List<Answer> Answers { get; set; }
}
