using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarService.Controllers
{
    public class CarServiceController : Controller
    {
        private readonly IRepairService _repairService;
        public CarServiceController(IRepairService repairService)
        {
            _repairService = repairService;
        }
        public ActionResult EstimateRepair<T>(T type)
        {
            _repairService.EstimateRepair(type);
            return View();
        }
    }
}
