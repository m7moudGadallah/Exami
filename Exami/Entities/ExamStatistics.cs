﻿namespace Entities;

public record ExamStatistics
{
    public int ExamId { get; set; }
    public double AverageScore { get; set; }
    public int NumberOfStudents { get; set; }
}
