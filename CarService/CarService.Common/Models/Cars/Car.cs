﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Common.Models.Cars
{
    public class Car: BaseCar, IBaseCar
    {
        public override double EstimateRepair()
        {
            int itemSwitch = 1;
            double resPrice = 0;
            foreach (var item in Wheels)
            {
                itemSwitch = (int)item;
                resPrice += itemSwitch switch
                {
                    1 => (int)PriceList.RepairPriceList.Wheels,
                    2 => (int)PriceList.ReplacementPriceList.Wheels,
                };
            }
            foreach (var item in Doors)
            {
                itemSwitch = (int)item;
                resPrice += itemSwitch switch
                {
                    1 => (int)PriceList.RepairPriceList.Doors,
                    2 => (int)PriceList.ReplacementPriceList.Doors,
                };
            }
           
            itemSwitch = (int)Body;
            resPrice += itemSwitch switch
            {
                1 => (int)PriceList.RepairPriceList.Body,
                2 => (int)PriceList.ReplacementPriceList.Body,
            };
            itemSwitch = (int)Undecarriage;
            resPrice += itemSwitch switch
            {
                1 => (int)PriceList.RepairPriceList.Undecarriage,
                2 => (int)PriceList.ReplacementPriceList.Undecarriage,
            };
            itemSwitch = (int)Engine;
            resPrice += itemSwitch switch
            {
                1 => (int)PriceList.RepairPriceList.Engine,
                2 => (int)PriceList.ReplacementPriceList.Engine,
            };
           
            return resPrice;
        }
    }
}
