﻿namespace Entities;

public record ExamQuestion
{
    public int ExamId { get; set; }
    public int QuestionId { get; set; }
    public Question Question { get; set; }
}
