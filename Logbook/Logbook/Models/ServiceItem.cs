namespace Logbook.Models
{
    public class ServiceItem
    {
        public long ServiceItemId { get; set; }
        public long VehicleId { get; set; }
        public string Task { get; set; }
        public long? Interval { get; set; }

        public Vehicle Vehicle { get; set; }
    }
}
