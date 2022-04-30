using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirGo.Web.Models
{
    public class PassangerDetailDto
    {
        public PassangerDetailDto()
        {
            AirTickets = new HashSet<AirTicketDto>();
        }

        public int PId { get; set; }
        public string PassangerName { get; set; }
        public string PAddress { get; set; }

        public virtual ICollection<AirTicketDto> AirTickets { get; set; }
    }
}
