using System;
using System.Collections.Generic;
using System.Data;
using Entities;

namespace Services.Mappers;

public class ExamStatisticsMapper : BaseMapper<ExamStatistics>
{
    private readonly static string[] Columns = ["ExamId", "AverageScore"];

    public override ExamStatistics MapFromDataRow(DataRow row, Dictionary<string, string> columnNameMapping = null)
    {
        if (row == null) return null;

        if (columnNameMapping == null) columnNameMapping = new Dictionary<string, string>();

        InitializeColumnNameMapping(Columns, columnNameMapping);

        return new()
        {
            ExamId = Convert.ToInt32(row[columnNameMapping["ExamId"]]),
            AverageScore = Convert.ToDouble(row[columnNameMapping["AverageScore"]])
        };
    }
}
