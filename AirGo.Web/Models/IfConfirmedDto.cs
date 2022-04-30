using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirGo.Web.Models
{
    public class IfConfirmedDto
    {
        public IfConfirmedDto()
        {
            AirTickets = new HashSet<AirTicketDto>();
        }

        public int CN { get; set; }
        public string Status { get; set; }
        public string IfDeclined { get; set; }

        public virtual ICollection<AirTicketDto> AirTickets { get; set; }
    }
}
