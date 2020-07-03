using CarService.Common.Models.Cars;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Common.DTO
{
    public class SuccessfulRepairDTO : IIdentifiable
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string CarType { get; set; }
        public List<DetailConditionEnum> singleDetailsConditions { get; set; }
        public List<List<DetailConditionEnum>> multipleDetailsConditions { get; set; }
        public double Price { get; set; }
    }
}
