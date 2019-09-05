using Sy.Core.Abstracts;
using System;

namespace Sy.Core.Entities
{
    public class Order : BaseEntity<long>
    {
        public DateTime RequiredDate { get; set; }
        public DateTime? DeliveredDate { get; set; }
    }
}
