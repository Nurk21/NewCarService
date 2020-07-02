using CarService.Common.Models.Cars;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarService.Common.Models.MongoEntities
{
    public class SuccessfulRepair<T> where T : class
    {
        public Guid Id { get; set; }
        public T CarType { get; set; }
        public List<DetailCondition> detailConditions { get; set; }
        public double Price { get; set; }
    }
}
