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
}
