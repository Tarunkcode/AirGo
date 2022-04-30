using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirGo.Web.Models
{
    public class AirTicketDto
    {
        public int RefId { get; set; }
        public int PassangerId { get; set; }
        public int FlightId { get; set; }
        public string PilotName { get; set; }
        public int ModelNo { get; set; }
        public int RequestNo { get; set; }

        public virtual FlightTimingDto Flight { get; set; }
        public virtual PassangerDetailDto Passanger { get; set; }
        public virtual IfConfirmedDto RequestNoNavigation { get; set; }
    }
}
