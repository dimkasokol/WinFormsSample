using System.Data.SqlClient;

namespace Sales.Entities
{
    [SqlProcedures(Delete = "sp_DeleteProduct", GetAll = "sp_GetProducts", InsertOrUpdate = "sp_InsertOrUpdateProduct")]
    public class Product : BaseEntity
    {
        [Column("Name", 60)]
        public string Name { get; set; }

        [Column("Cost", 20)]
        public decimal Cost { get; set; }

        public override SqlParameter[] GetParameters()
        {
            return new[]
            {
                new SqlParameter("id", Id),
                new SqlParameter("name", Name),
                new SqlParameter("cost", Cost)
            };
        }

        public override string ToString() => Name;

        public static Product GetFromReader(SqlDataReader reader)
        {
            return new Product
            {
                Id = (int)reader["Id"],
                Name = (string)reader["Name"],
                Cost = (decimal)reader["Cost"]
            };
        }
    }
}
