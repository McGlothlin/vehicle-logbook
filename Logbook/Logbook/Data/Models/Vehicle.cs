using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logbook.Data.Models
{
    public class Vehicle
    {
        public long Id { get; set; }
        public long OwnerId { get; set; }
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string VIN { get; set; }
        public string Mileage { get; set; }
    }
}
