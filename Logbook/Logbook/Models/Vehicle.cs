using System.Collections.Generic;

namespace Logbook.Models
{
    public class Vehicle
    {
        public long Id { get; set; }
        //public long OwnerId { get; set; }
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        //public string VIN { get; set; }
        public long Mileage { get; set; }

        public ICollection<ServiceItem> ServiceItems { get; set; }
    }
}
