using System.Data;

namespace Database;

public record DBCommandParams(string Sql, CommandType CommandType = CommandType.Text, Dictionary<string, object> Parameters = null);
