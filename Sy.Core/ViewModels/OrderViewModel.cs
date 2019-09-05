using System;

namespace Sy.Core.ViewModels
{
    public class OrderViewModel
    {
        public long Id { get; set; }
        public string ClientName { get; set; }
        public string ClientSurname { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime? DeliveredDate { get; set; }
        public string Display => $"{OrderDate:d} - {TotalPrice:c2}";
    }
}
