using AutoMapper;
using CarService.Common.DTO;
using CarService.Common.Models.Cars;
using CarService.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace CarService.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class BusController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public BusController(IMediator mediator, IMapper mapper)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> EstimateRepair([FromBody] BusDTO busDTO)
        {
            var mapper = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Bus, BusDTO>()));
            var result = await _mediator.Send(new EstimateRepairQuery { 
                 BaseCar = _mapper.Map<Bus>(busDTO)
            });
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> Repair([FromBody] BusDTO busDTO)
        {
            var result = await _mediator.Send(new RepairQuery());
            return Ok(result);

        }
    }
}
