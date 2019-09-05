using System;

namespace Sy.Core.ViewModels
{
    public class OrderDetailViewModel
    {
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal SubTotal => this.UnitPrice * this.Quantity;
        public string ProductName { get; set; }
    }
}
