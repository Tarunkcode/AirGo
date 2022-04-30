using System;
using System.Collections.Generic;

#nullable disable

namespace AirGo.Services.airlines
{
    public partial class PassangerDetail
    {
        public PassangerDetail()
        {
            AirTickets = new HashSet<AirTicket>();
        }

        public int PId { get; set; }
        public string PassangerName { get; set; }
        public string PAddress { get; set; }

        public virtual ICollection<AirTicket> AirTickets { get; set; }
    }
}
