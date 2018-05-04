namespace Sales.Entities
{
    [SqlProcedures(Delete = "sp_DeleteProduct", GetAll = "sp_GetProducts", InsertOrUpdate = "sp_InsertOrUpdateProduct")]
    public class Product : BaseEntity
    {
        [Column("Name", 60)]
        public string Name { get; set; }

        [Column("Cost", 20)]
        public decimal Cost { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
