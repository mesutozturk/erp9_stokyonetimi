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
        public string Display => $"{this.ProductName} - {this.UnitPrice:c2}"; 
    }
}
