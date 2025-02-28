using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Services.DTOs;
using Services.Helpers;
using Services.Mappers;

namespace Services.Services;

public class ExamStatisticsService : BasicCRUDService<ExamStatistics>, IGetAllEntitiesService<ExamStatistics>
{
    public ExamStatisticsService() : base("ExamStatisticsView", new ExamStatisticsMapper()) { }

    public List<ExamStatistics> GetAll(GetAllDto? dto = null)
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
