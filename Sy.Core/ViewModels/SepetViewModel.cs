using System;

namespace Sy.Core.ViewModels
{
    public class SepetViewModel
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal SubTotal => UnitPrice * Quantity;

        public string Display => $"{ProductName} - {Quantity}x{UnitPrice} = {SubTotal}";
    }
}
