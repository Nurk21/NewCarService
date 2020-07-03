using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Common.Models.Cars
{
    public class Truck : BaseCar<Truck>, IBaseCar
    {
        public Truck()
        {

        }
        public override double EstimateRepair()
        {
            int itemSwitch = 1;
            double resPrice = 0;
            foreach (var item in Wheels)
            {
                itemSwitch = (int)item;
                resPrice += itemSwitch switch
                {
                    2 => (int)PriceList.RepairPriceList.Wheels,
                    3 => (int)PriceList.ReplacementPriceList.Wheels
                };
            }
            foreach (var item in Doors)
            {
                itemSwitch = (int)item;
                resPrice += itemSwitch switch
                {
                    2 => (int)PriceList.RepairPriceList.Doors,
                    3 => (int)PriceList.ReplacementPriceList.Doors
                };
            }

            itemSwitch = (int)Body;
            resPrice += itemSwitch switch
            {
                2 => (int)PriceList.RepairPriceList.Body,
                3 => (int)PriceList.ReplacementPriceList.Body
            };
            itemSwitch = (int)Undecarriage;
            resPrice += itemSwitch switch
            {
                2 => (int)PriceList.RepairPriceList.Undecarriage,
                3 => (int)PriceList.ReplacementPriceList.Undecarriage
            };
            itemSwitch = (int)Engine;
            resPrice += itemSwitch switch
            {
                2 => (int)PriceList.RepairPriceList.Engine,
                3 => (int)PriceList.ReplacementPriceList.Engine
            };
            itemSwitch = (int)LargeWheels;
            resPrice += itemSwitch switch
            {
                2 => (int)PriceList.RepairPriceList.LargeWheels,
                3 => (int)PriceList.ReplacementPriceList.LargeWheels
            };
            itemSwitch = (int)Trunk;
            resPrice += itemSwitch switch
            {
                2 => (int)PriceList.RepairPriceList.Trunk,
                3 => (int)PriceList.ReplacementPriceList.Trunk
            };

            return resPrice;
        }
    
        public DetailConditionEnum LargeWheels { get; set; }
        public DetailConditionEnum Trunk { get; set; }

    }
}
