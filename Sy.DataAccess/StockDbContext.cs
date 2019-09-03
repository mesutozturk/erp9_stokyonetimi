using System.Data.Entity;
using Sy.Core.Entities;

namespace Sy.DataAccess
{
    public class StockDbContext : DbContext
    {
        public StockDbContext()
            : base("name=MyCon")
        {
        }

        public virtual DbSet<Product> Products { get; set; }
    }
}
