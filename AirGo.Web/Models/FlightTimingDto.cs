using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirGo.Web.Models
{
    public class FlightTimingDto
    {
        public FlightTimingDto()
        {
            AirTickets = new HashSet<AirTicketDto>();
        }

        public int FId { get; set; }
        public string FlightName { get; set; }
        public TimeSpan InTime { get; set; }
        public TimeSpan? OutTime { get; set; }

        public virtual ICollection<AirTicketDto> AirTickets { get; set; }
    }
}
