using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Common
{
    public interface IPriceList
    {
        //enum RepairPriceList 
        //{
        //    Wheels,
        //    Body,
        //    Undecarriage,
        //    Engine,
        //    Doors,
        //    HandRails,
        //};
        //enum ReplacementPriceList 
        //{
        //    Wheels,
        //    Body,
        //    Undecarriage,
        //    Engine,
        //    Doors,
        //    HandRails,
        //};

    }
    public class PriceList : IPriceList
    {
        public enum RepairPriceList
        {
            Wheels = 1000,
            Body = 1500,
            Undecarriage = 750,
            Engine = 3000,
            Doors = 500,
            Handrails = 500,
            Seats = 750,
            LargeWheels = 1000,
            Trunk = 1500
        }
        public enum ReplacementPriceList
        {
            Wheels = 1500,
            Body = 2500,
            Undecarriage = 1250,
            Engine = 5000,
            Doors = 1500,
            Handrails = 1000,
            Seats = 2000,
            LargeWheels = 2500,
            Trunk = 3000;
        }
    }
}
