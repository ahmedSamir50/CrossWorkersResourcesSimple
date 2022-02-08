using System;

namespace BookingSampleAPIs.Models
{
    public class ResourceBookingVModelBase
    {
        public int ResIdNum { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }
}