using AirGo.Services.airlines;
using AirGo.Services.iRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirGo.Services.Repository
{
    public class Repository : IRepository
    {
        private readonly AirlinesContext _db;
        public Repository(AirlinesContext db)
        {
            this._db = db;
        }

        public async Task<List<AirTicket>> getTickets()
        {
            List<AirTicket> result = new List<AirTicket>();
            try
            {
                result = await _db.AirTickets
                                              .Include(nameof(IfConfirmed))
                                              .Include(nameof(FlightTiming))
                                              .Include(nameof(PassangerDetail))
                                              .ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return result;
        }

        public async Task<bool> SaveTickat(AirTicket airTicket)
        {
            try
            {
                var entity = _db.AirTickets.FirstOrDefault(k => k.RefId == airTicket.RefId);
                if (entity != null)
                {
                    entity.PilotName = airTicket.PilotName.Trim();
                    entity.ModelNo = airTicket.ModelNo;

                    _db.Entry(entity).State = EntityState.Modified;
                    await _db.SaveChangesAsync();
                    return true;

                }
                else
                {
                    _db.AirTickets.Add(airTicket);
                    await _db.SaveChangesAsync();
                }

            }
            catch(Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
