using Entities;

namespace Services.DTOs;

public record CreateQuestionDto(
    double Marks,
   string Body,
   QuestionType QuestionType,
   int? SubjectId = null);
