using CarService.Common.Models.Cars;
using System.Collections.Generic;

namespace CarService.Common.DTO
{
    public class CarDTO
    {
        public List<DetailConditionEnum> Wheels { get; set; }
        public DetailConditionEnum Body { get; set; }
        public DetailConditionEnum Undecarriage { get; set; }
        public DetailConditionEnum Engine { get; set; }
        public List<DetailConditionEnum> Doors { get; set; }

    }

    public class BusDTO 
    {
        public List<DetailConditionEnum> Wheels { get; set; }
        public DetailConditionEnum Body { get; set; }
        public DetailConditionEnum Undecarriage { get; set; }
        public DetailConditionEnum Engine { get; set; }
        public List<DetailConditionEnum> Doors { get; set; }
        public DetailConditionEnum Handrails { get; set; }
        public List<DetailConditionEnum> Seats { get; set; }

    }

    public class TruckDTO
    {
        public List<DetailConditionEnum> Wheels { get; set; }
        public DetailConditionEnum Body { get; set; }
        public DetailConditionEnum Undecarriage { get; set; }
        public DetailConditionEnum Engine { get; set; }
        public List<DetailConditionEnum> Doors { get; set; }
        public DetailConditionEnum LargeWheels { get; set; }
        public DetailConditionEnum Trunk { get; set; }

    }
}
