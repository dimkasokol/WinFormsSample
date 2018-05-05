using System.Data.SqlClient;

namespace Sales.Entities
{
    [SqlProcedures(Delete = "sp_DeleteEmployee", GetAll = "sp_GetEmployees", InsertOrUpdate = "sp_InsertOrUpdateEmployee")]
    public class Employee : BaseEntity
    {
        [Column("Name", 60)]
        public string Name { get; set; }

        public override SqlParameter[] GetParameters()
        {
            return new[]
            {
                new SqlParameter("id", Id),
                new SqlParameter("name", Name)
            };
        }

        public override string ToString() => Name;

        public static Employee GetFromReader(SqlDataReader reader)
        {
            return new Employee
            {
                Id = (int)reader["Id"],
                Name = (string)reader["Name"]
            };
        }
    }
}
