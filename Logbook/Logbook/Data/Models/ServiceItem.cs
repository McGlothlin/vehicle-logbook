using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logbook.Data.Models
{
    public class ServiceItem
    {
        public long Id { get; set; }
        public string Task { get; set; }
        public string Interval { get; set; }
    }
}
