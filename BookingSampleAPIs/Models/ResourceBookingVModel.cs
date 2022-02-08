using System;

namespace BookingSampleAPIs.Models
{
    public class ResourceBookingVModel : ResourceBookingVModelBase
    {
        public int? ID { get; set; }
        public int BookedQuantity { get; set; }
    }
}
