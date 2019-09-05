using Sy.Core.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sy.Core.Entities
{
    [Table("Orders")]
    public class Order : BaseEntity<long>
    {
        public DateTime RequiredDate { get; set; }
        public DateTime? DeliveredDate { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new HashSet<OrderDetail>();
    }
}
