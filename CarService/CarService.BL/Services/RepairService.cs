using CarService.Common.Models.Cars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CarService.BL.Services
{
    public interface IRepairService
    {
        double EstimateRepair(T carType);
    }
    
    public class RepairService<T> : IRepairService
    {
        private enum RepairPriceList
        {
            Wheels = 1000,
            Body = 1500,
            Undecarriage = 750,
            Engine = 3000,
            Doors = 500
        }
        private enum ReplacementPriceList
        {
            Wheels = 1500,
            Body = 2500,
            Undecarriage = 1250,
            Engine = 5000,
            Doors = 1500
        }
        public double EstimateRepair(T carType)
        {
            double totalPrice = 0; 
            foreach (var prop in carType.GetType().GetProperties())
            {
                if (prop.PropertyType == typeof(DetailConditionEnum) )
                {
                    int itemSwitch = (int)carType.  $(prop.Name);
                    totalPrice += itemSwitch switch
                    {
                        2 => (int)RepairPriceList.(prop.Name),
                        3 => (int)ReplacementPriceList.(prop.Name)
                    };
                }
                else if (prop.PropertyType == typeof(List<DetailConditionEnum>))
                {
                    string a = prop.Name;
                    foreach (var item in carType.a)
                    {
                        int itemSwitch = (int)carType.  $(prop.Name);
                        totalPrice += itemSwitch switch
                        {
                            2 => (int)RepairPriceList.(prop.Name),
                            3 => (int)ReplacementPriceList.(prop.Name)
                        };
                    }
                }
                    
            }
            return totalPrice;
        }
        public void Repair()
        {
            //Add data to DB
            
        }
    }
}
