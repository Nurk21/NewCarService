using CarService.BL.Services;
using CarService.Common.Models.Cars;
using CarService.Queries;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CarService.Handlers
{
    public class EstimateRepairHandler : IRequestHandler<EstimateRepairQuery, object>
    {
        private readonly IRepairService<BaseCar> _repairService;
        public EstimateRepairHandler(IRepairService<BaseCar> repairService)
        {
            _repairService = repairService;
        }

        public async Task<object> Handle(EstimateRepairQuery request, CancellationToken cancellationToken)
        {
            var result = _repairService.EstimateRepair(request.BaseCar);
            return result;
        }
    }
}
