using System.Data;
using Entities;

namespace Services.Mappers;

public class UserMapper : BaseMapper<User>
{
    public override User MapFromDataRow(DataRow row)
    {
        if (row == null) return null;

        // Convert the DataRow into a User object
        return new User(
            Id: Convert.ToInt32(row["Id"]),
            FirstName: row["FirstName"] as string,
            LastName: row["LastName"] as string,
            Role: ParseUserRole(row["Role"].ToString()),
            Email: row["Email"].ToString(),
            Password: row["Password"].ToString()
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
