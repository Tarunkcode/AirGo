using AirGo.Services.airlines;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AirGo.Services.iRepository
{
    public interface IRepository
    {
        Task<List<AirTicket>> getTickets();
        Task<bool> SaveTickat(AirTicket airTicket);

    }
}
