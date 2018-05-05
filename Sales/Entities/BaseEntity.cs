using System.Data.SqlClient;

namespace Sales.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public abstract SqlParameter[] GetParameters();
    }
}
