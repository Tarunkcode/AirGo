using System;
using System.Collections.Generic;

#nullable disable

namespace AirGo.Services.airlines
{
    public partial class FlightTiming
    {
        public FlightTiming()
        {
            AirTickets = new HashSet<AirTicket>();
        }

        public int FId { get; set; }
        public string FlightName { get; set; }
        public TimeSpan InTime { get; set; }
        public TimeSpan? OutTime { get; set; }

        public virtual ICollection<AirTicket> AirTickets { get; set; }
    }
}
