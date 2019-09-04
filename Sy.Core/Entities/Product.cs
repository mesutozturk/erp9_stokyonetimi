using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Sy.Core.Abstracts;

namespace Sy.Core.Entities
{
    [Table("Products")]
    public class Product : BaseEntity<Guid>
    {
        public Product()
        {
            this.Id = Guid.NewGuid();
        }
        [Required, StringLength(100)]
        public string ProductName { get; set; }
        [Range(0, 9999999)]
        public decimal UnitPrice { get; set; }
        public int CriticStock { get; set; } = 10;


        public virtual ICollection<ProductStockAction> ProductStockActions { get; set; } = new HashSet<ProductStockAction>();
    }
}
