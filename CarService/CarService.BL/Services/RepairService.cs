using CarService.Common.Models.Cars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace CarService.BL.Services
{
    //public interface IRepairService<T>
    //{
    //    double EstimateRepair<T>(T carType);
    //}
    public interface IRepairService<T> where T : BaseCar
    {
        double EstimateRepair(T carType);
        Task Repair();
    }

    public class RepairService<T> : IRepairService<T> where T : BaseCar
    {
       
        public double EstimateRepair(T carType)
        {
            return carType.EstimateRepair();

            #region Comments
            //double totalPrice = 0; 
            //foreach (var prop in carType.GetType().GetProperties())
            //{
            //    if (prop.PropertyType == typeof(DetailConditionEnum) )
            //    {
            //        int itemSwitch = (int)carType.  $(prop.Name);
            //        totalPrice += itemSwitch switch
            //        {
            //            2 => (int)RepairPriceList.(prop.Name),
            //            3 => (int)ReplacementPriceList.(prop.Name)
            //        };
            //    }
            //    else if (prop.PropertyType == typeof(List<DetailConditionEnum>))
            //    {
            //        string a = prop.Name;
            //        foreach (var item in carType.a)
            //        {
            //            int itemSwitch = (int)carType.  $(prop.Name);
            //            totalPrice += itemSwitch switch
            //            {
            //                2 => (int)RepairPriceList.(prop.Name),
            //                3 => (int)ReplacementPriceList.(prop.Name)
            //            };
            //        }
            //    }

            //}
            //return totalPrice;

            #endregion
        }

        Task IRepairService<T>.Repair()
        {
            throw new NotImplementedException();
        }
    }
}
