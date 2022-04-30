using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DataModel = AirGo.Services.airlines;
using DomainModel = AirGo.Web.Models;


namespace AirGo.Web.AutoMapper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<DataModel.AirTicket, DomainModel.AirTicketDto>().ReverseMap();
            CreateMap<DataModel.IfConfirmed, DomainModel.IfConfirmedDto>().ReverseMap();
            CreateMap<DataModel.FlightTiming, DomainModel.FlightTimingDto>().ReverseMap();
            CreateMap<DataModel.PassangerDetail, DomainModel.PassangerDetailDto>().ReverseMap();
        }
    }
}
