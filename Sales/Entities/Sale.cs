using System;
using System.Data.SqlClient;

namespace Sales.Entities
{
    [SqlProcedures(Delete = "sp_DeleteSale", GetAll = "sp_GetSales", InsertOrUpdate = "sp_InsertOrUpdateSale")]
    public class Sale : BaseEntity
    {
        [Column("Employee", 40)]
        public Employee Employee { get; set; }

        [Column("Product", 30)]
        public Product Product { get; set; }

        [Column("Amount", 10)]
        public int Amount { get; set; }

        [Column("Total cost", 20)]
        public decimal TotalCost { get; set; }

        [Column("Sale date", 20)]
        public DateTime SaleDate { get; set; }

        public override SqlParameter[] GetParameters()
        {
            return new[]
            {
                new SqlParameter("id", Id),
                new SqlParameter("employeeId", Employee.Id),
                new SqlParameter("productId", Product.Id),
                new SqlParameter("amount", Amount),
                new SqlParameter("totalCost", TotalCost),
                new SqlParameter("saleDate", SaleDate)
            };
        }

        public static Sale GetFromReader(SqlDataReader reader)
        {
            return new Sale
            {
                Id = (int)reader["Id"],
                Employee = new Employee { Id = (int)reader["EmployeeId"], Name = (string)reader["EmployeeName"] },
                Product = new Product { Id = (int)reader["ProductId"], Name = (string)reader["ProductName"], Cost = (decimal)reader["Cost"] },
                Amount = (int)reader["Amount"],
                TotalCost = (decimal)reader["TotalCost"],
                SaleDate = (DateTime)reader["SaleDate"]
            };
        }
    }
}
