namespace Sales.Entities
{
    [SqlProcedures(Delete = "sp_DeleteEmployee", GetAll = "sp_GetEmployees", InsertOrUpdate = "sp_InsertOrUpdateEmployee")]
    public class Employee : BaseEntity
    {
        [Column("Name", 60)]
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
