using AirGo.Services.airlines;
using AirGo.Services.iRepository;
using AirGo.Services.Repository;
using AirGo.Web.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirGo.Web.Controllers
{
    [ApiController]
    [Route("api/[action]")]
    public class AirlineController : ControllerBase
    {
        private readonly ILogger<AirlineController> _logger;
        private readonly IRepository _Repository;
   
        private readonly IMapper _mapper;

        public AirlineController(ILogger<AirlineController>logger, IRepository Repository, IMapper mapper)
        {
            _logger = logger;
            _Repository = Repository;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllTicket()
        {
            var entityResult = await _Repository.getTickets();
           // var domainModel = new List<AirTicketDto>();

            // Automapper

            var response = _mapper.Map<List<AirTicketDto>>(entityResult);
           
            return Ok(response);
        }
        [HttpPost]
        public async  Task<ActionResult> SaveTicket([FromBody] AirTicketDto airTicketdto)
        {
            bool result = false;
            if (ModelState.IsValid)
            {
                var response = _mapper.Map<AirGo.Services.airlines.AirTicket>(airTicketdto);
                result = await _Repository.SaveTickat(response);
            }
            return Ok(result);

        }
    }
}
