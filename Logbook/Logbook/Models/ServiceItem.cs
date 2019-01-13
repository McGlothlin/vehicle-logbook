using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logbook.Data.Models
{
    public class ServiceItem
    {
        public long ServiceItemId { get; set; }
        public long VehicleId { get; set; }
        public string Task { get; set; }
        public string Interval { get; set; }

        public Vehicle Vehicle { get; set; }
    }
}
