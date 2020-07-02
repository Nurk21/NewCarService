using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Common.Models.Cars
{    
    public class Bus : BaseCar
    {
        public Bus()
        {

        }
        public DetailConditionEnum HandRails { get; set; }
        public List<DetailConditionEnum> Seats { get; set; }

    }
}
