namespace Sales.Entities
{
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
