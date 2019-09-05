using Sy.Core.Abstracts;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sy.Core.Entities
{
    /// <summary>
    /// Id Order
    /// Id2 Product
    /// </summary>
    [Table("OrderDetails")]
    public class OrderDetail : BaseEntity2<long, Guid>
    {
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }


        [ForeignKey(nameof(Id))]
        public virtual Order Order { get; set; }
        [ForeignKey(nameof(Id2))]
        public virtual Product Product { get; set; }
    }
}
