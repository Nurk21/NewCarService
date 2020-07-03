using CarService.BL.Services;
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
        private readonly IRepairService _repairService;
        public CarServiceController(IRepairService repairService)
        {
            _repairService = repairService;
        }
        [HttpPost]
        
        public async Task<ActionResult> EstimateRepair<T>([FromBody]T type)
        {
            return await Ok(_repairService.EstimateRepair(type));
        }
        [HttpPost]

        public async Task<ActionResult> Repair<T>([FromBody] T type)
        {
            return await Ok(_repairService.EstimateRepair(type));
        }
    }
}
