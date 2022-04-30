using System;
using System.Collections.Generic;

#nullable disable

namespace AirGo.Services.airlines
{
    public partial class IfConfirmed
    {
        public IfConfirmed()
        {
            AirTickets = new HashSet<AirTicket>();
        }

        public int CN { get; set; }
        public string Status { get; set; }
        public string IfDeclined { get; set; }

        public virtual ICollection<AirTicket> AirTickets { get; set; }
    }
}
