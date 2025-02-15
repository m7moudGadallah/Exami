namespace Entities;

public record Question(
   int Id,
   double Mark,
   string Body,
   QuestionType QuestionType,
   int? SubjectId
   );
