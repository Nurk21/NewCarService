using CarService.BL.Services;
using CarService.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarService.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CarServiceController : ControllerBase
    {
        private readonly IMediator _mediator;
        //private readonly IRepairService _repairService;
        public CarServiceController(/*IRepairService repairService,*/ IMediator mediator)
        {
            _mediator = mediator;
            
        }
        [HttpPost]
        
        public async Task<IActionResult> EstimateRepair<T>([FromBody]T type)
        {
            var query = new EstimateRepairQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }
        [HttpPost]

        public async Task<ActionResult> Repair<T>([FromBody] T type)
        {
            var query = new RepairQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
            
        }
    }
}
