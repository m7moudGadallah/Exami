﻿namespace Entities;

public record Question(
   int Id,
   double Marks,
   string Body,
   QuestionType QuestionType,
   int? SubjectId
   )
{
    public List<Answer> Answers { get; set; }
}
