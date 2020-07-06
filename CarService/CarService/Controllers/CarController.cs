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
    public class CarController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public CarController(IMediator mediator, IMapper mapper)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpPost]     
        public async Task<IActionResult> EstimateRepair([FromBody]CarDTO carDTO)
        {
            var result = await _mediator.Send(new EstimateRepairQuery { 
                BaseCar = _mapper.Map<Car>(carDTO)
            });
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> Repair([FromBody]CarDTO carDTO)
        {
            var result = await _mediator.Send(new RepairQuery());
            return Ok(result);
            
        }
    }
}
