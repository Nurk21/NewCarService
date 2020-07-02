using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Common.Models.Cars
{
    public class Truck : BaseCar
    {
        public Truck()
        {

        }
        public DetailConditionEnum LargeWheels { get; set; }
        public DetailConditionEnum Trunk { get; set; }
    }
}
