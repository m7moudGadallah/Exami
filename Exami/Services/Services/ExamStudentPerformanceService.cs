using Entities;
using Services.DTOs;
using Services.Helpers;
using Services.Mappers;

namespace Services.Services;

public class ExamStudentPerformanceService : BasicCRUDService<ExamStudentPerformance>, IGetAllEntitiesService<ExamStudentPerformance>
{
    public ExamStudentPerformanceService() : base("ExamStudentPerformanceView", new ExamStudentPerformanceMapper()) { }

    public List<ExamStudentPerformance> GetAll(GetAllDto? dto = null)
    {
        if (dto == null)
            dto = new();

        if (dto?.OrderBy == null)
        {
            dto.OrderBy = new()
            {
                ["ExamId"] = 1
            };
        }

        return this.DefaultGetAll(dto);
    }
}
