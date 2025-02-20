using Entities;

namespace Services.DTOs;

public record CreateExamInputDto(string Name, int? SubjectId, DateTime StartTime,
                    DateTime EndTime, ExamType ExamType, string? Instructions);
