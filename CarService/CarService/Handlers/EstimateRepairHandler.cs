using CarService.BL.Services;
using CarService.Common.Models.Cars;
using CarService.Queries;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CarService.Handlers
{
    public class EstimateRepairHandler : IRequestHandler<EstimateRepairQuery, object>
    {
        private readonly IRepairService<BaseCar> _repairService;
        public EstimateRepairHandler(/*IRepairService<BaseCar> repairService*/ IServiceProvider serviceProvider)
        {
            _repairService = serviceProvider.GetRequiredService<IRepairService<BaseCar>>();
        }

        public async Task<object> Handle(EstimateRepairQuery request, CancellationToken cancellationToken)
        {
            var result = _repairService.EstimateRepair(request.BaseCar);
            return result;
        }
    }
}
