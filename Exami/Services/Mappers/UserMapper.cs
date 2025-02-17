using System.Data;
using Entities;

namespace Services.Mappers;

public class UserMapper : BaseMapper<User>
{
    private readonly static string[] Columns = ["Id", "FirstName", "LastName", "Role", "Email", "Password"];
    public override User MapFromDataRow(DataRow row, Dictionary<string, string> columnNameMapping = null)
    {
        if (row == null) return null;

        if (columnNameMapping == null) columnNameMapping = new Dictionary<string, string>();

        InitializeColumnNameMapping(Columns, columnNameMapping);

        // Convert the DataRow into a User object
        return new User(
            Id: Convert.ToInt32(row[columnNameMapping["Id"]]),
            FirstName: row[columnNameMapping["FirstName"]] as string,
            LastName: row[columnNameMapping["LastName"]] as string,
            Role: ParseUserRole(row[columnNameMapping["Role"]].ToString()),
            Email: row[columnNameMapping["Email"]].ToString(),
            Password: row[columnNameMapping["Password"]].ToString()
        );
    }

    private UserRole ParseUserRole(string roleString)
    {
        return roleString switch
        {
            "Admin" => UserRole.Admin,
            "Teacher" => UserRole.Teacher,
            "Student" => UserRole.Student,
            _ => throw new ArgumentException($"Invalid user role: {roleString}")
        };
    }
}
