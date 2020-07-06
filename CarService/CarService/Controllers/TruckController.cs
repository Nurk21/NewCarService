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
    public class TruckController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public TruckController(IMediator mediator, IMapper mapper)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> EstimateRepair([FromBody] TruckDTO truckDTO)
        {
            var result = await _mediator.Send((new EstimateRepairQuery
            {
                BaseCar = _mapper.Map<Truck>(truckDTO)
            }));
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> Repair([FromBody] TruckDTO truckDTO)
        {
            var result = await _mediator.Send(new RepairQuery());
            return Ok(result);

        }
    }
}
