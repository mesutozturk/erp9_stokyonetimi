using System;
using System.ComponentModel.DataAnnotations.Schema;
using Sy.Core.Abstracts;
using Sy.Core.Enums;

namespace Sy.Core.Entities
{
    [Table("ProductStockActions")]
    public class ProductStockAction : BaseEntity<long>
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public StockActionType StockActionType { get; set; }

        [ForeignKey(nameof(ProductId))]
        public virtual Product Product { get; set; }
    }
}
