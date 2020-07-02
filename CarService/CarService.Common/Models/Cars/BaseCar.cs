using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Common.Models.Cars
{
    public enum DetailConditionEnum
    {
        NoNeedInRepair = 1,
        Repair,
        Replacement
    }
    public interface IBaseCar
    {
        public List<DetailConditionEnum> Wheels { get; set; }
        public DetailConditionEnum Body { get; set; }
        public DetailConditionEnum Undecarriage { get; set; }
        public DetailConditionEnum Engine { get; set; }
        public List<DetailConditionEnum> Doors { get; set; }
    }
    public class BaseCar : IBaseCar 
    { 
        public List<DetailConditionEnum> Wheels { get; set; }
        public DetailConditionEnum Body { get; set; }
        public DetailConditionEnum Undecarriage { get; set; }
        public DetailConditionEnum Engine { get; set; }
        public List<DetailConditionEnum> Doors { get; set; }

        //public BaseCar(BaseCarEnum wheels, BaseCarEnum body, BaseCarEnum undecarriage, BaseCarEnum engine)
        //{
        //    Wheels = wheels;
        //    Body = body;
        //    Undecarriage = undecarriage;
        //    Engine = engine;
        //}
    }
}
