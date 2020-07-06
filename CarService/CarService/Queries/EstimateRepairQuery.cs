using CarService.Common.Models.Cars;
using MediatR;

namespace CarService.Queries
{
    public class EstimateRepairQuery : IRequest<object>
    {
        public BaseCar BaseCar { get; set; }
    }
}
