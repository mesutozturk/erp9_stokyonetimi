using Sy.Core.Abstracts;
using System;

namespace Sy.Core.Entities
{
    public class Order : BaseEntity<Guid>
    {
        public Order()
        {
            this.Id = Guid.NewGuid();
        }

        public DateTime RequiredDate { get; set; }
        public DateTime? DeliveredDate { get; set; }
    }
}
