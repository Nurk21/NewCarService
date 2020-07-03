using CarService.BL.Services;
using CarService.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CarService.Handlers
{
    public class EstimateRepairHandler : IRequestHandler<EstimateRepairQuery, double>
    {
        IRepairService<T> _repairService;
        public EstimateRepairHandler(IRepairService<T> repairService)
        {
            _repairService = repairService;
        }
        public async Task<double> Handle(EstimateRepairQuery request, CancellationToken cancellationToken)
        {
            return _repairService.EstimateRepair();
        }
    }
}
