using System;

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
    }
}
