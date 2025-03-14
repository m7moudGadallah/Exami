﻿namespace Services.DTOs;

public record GetAllDto
{
    public Dictionary<string, object>? Filters { get; set; }
    public Dictionary<string, int>? OrderBy { get; set; }
    public int? Take { get; set; }
    public int? Skip { get; set; }
}
