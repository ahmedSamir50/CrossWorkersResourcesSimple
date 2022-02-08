using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingSampleAPIs.Models
{
    public class ResourceVModel
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public ICollection<ResourceBookingVModel> Bookings { get; set; }
    }
}
