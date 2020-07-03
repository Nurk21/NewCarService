using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Common.Models.Cars
{    
    public class Bus : BaseCar<Bus> , IBaseCar
    {
        public Bus()
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
            foreach (var item in Seats)
            {
                itemSwitch = (int)item;
                resPrice += itemSwitch switch
                {
                    2 => (int)PriceList.RepairPriceList.Seats,
                    3 => (int)PriceList.ReplacementPriceList.Seats
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
            itemSwitch = (int)Handrails;
            resPrice += itemSwitch switch
            {
                2 => (int)PriceList.RepairPriceList.Handrails,
                3 => (int)PriceList.ReplacementPriceList.Handrails
            };

            return resPrice;
        }
        public DetailConditionEnum Handrails { get; set; }
        public List<DetailConditionEnum> Seats { get; set; }

    }
}
