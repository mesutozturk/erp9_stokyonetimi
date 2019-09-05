using System;
using System.Data.Entity;
using System.Linq;
using Sy.Core.Abstracts;
using Sy.Core.ComplexTypes;
using Sy.Core.Entities;

namespace Sy.DataAccess
{
    public class StockDbContext : DbContext
    {
        public StockDbContext()
            : base("name=MyCon")
        {
        }

        public override int SaveChanges()
        {
            //Audit
            if (StockSettings.UserInfo != null)
            {
                var selectedEntityList = ChangeTracker.Entries()
                    .Where(x => x.Entity is AuditBase && x.State == EntityState.Added);
                foreach (var item in selectedEntityList)
                {
                    ((AuditBase)item.Entity).CreatedUser = StockSettings.UserInfo.Email;
                    ((AuditBase)item.Entity).CreatedDate = DateTime.Now;
                }
                selectedEntityList = ChangeTracker.Entries()
                    .Where(x => x.Entity is AuditBase && x.State == EntityState.Modified);
                foreach (var item in selectedEntityList)
                {
                    ((AuditBase)item.Entity).UpdatedUser = StockSettings.UserInfo.Email;
                    ((AuditBase)item.Entity).UpdatedDate = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<ProductStockAction> ProductStockActions { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
