using System;

namespace Sales.Entities
{
    public class ColumnAttribute : Attribute
    {
        public ColumnAttribute(string name, float fillWeight)
        {
            Name = name;
            FillWeight = fillWeight;
        }

        public string Name { get; set; }
        public float FillWeight { get; set; }
    }

    public class SqlProceduresAttribute : Attribute
    {
        public string GetAll { get; set; }
        public string InsertOrUpdate { get; set; }
        public string Delete { get; set; }
    }
}
