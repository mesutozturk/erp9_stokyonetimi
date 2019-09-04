using System;
using System.ComponentModel.DataAnnotations;

namespace Sy.Core.ViewModels
{
    public class ProductViewModel
    {
        public Guid Id { get; set; }
        [Required, StringLength(100)]
        public string ProductName { get; set; }
        [Range(0, 9999999)]
        public decimal UnitPrice { get; set; }
        public int CriticStock { get; set; } = 10;
        public int UnitsInStock { get; set; }
        public string Display => $"{this.ProductName} x{this.UnitsInStock} - {this.UnitPrice:c2}";
    }
}
