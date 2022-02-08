namespace ReposAndServ.Utils.Models
{
    public class ResourceAvailability
    {
        public bool AvailableInDates { get => AvailableQtyInDates > 0; }
        public int AvailableQtyInDates { get; set; }
        public bool Availability { get => AvailableInDates && AvailableQtyInDates > 0; }
    }
}
