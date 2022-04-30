using System;
using System.Collections.Generic;

#nullable disable

namespace AirGo.Services.airlines
{
    public partial class AirTicket
    {
        public int RefId { get; set; }
        public int PassangerId { get; set; }
        public int FlightId { get; set; }
        public string PilotName { get; set; }
        public int ModelNo { get; set; }
        public int RequestNo { get; set; }

        public virtual FlightTiming Flight { get; set; }
        public virtual PassangerDetail Passanger { get; set; }
        public virtual IfConfirmed RequestNoNavigation { get; set; }
    }
}
