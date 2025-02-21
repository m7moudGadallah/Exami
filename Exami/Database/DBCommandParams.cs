using System.Data;

namespace Database;

public record DbCommandParams(string Sql, CommandType CommandType = CommandType.Text, Dictionary<string, object> Parameters = null);
