namespace Entities;

public record Answer
(
   int Id,
   int? QuestionId,
   string AnswerText,
   bool IsCorrect

);
