using AutoMapper;
using CarService.Common.DTO;
using CarService.Common.Models.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarService
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<Car, CarDTO>();
            CreateMap<CarDTO, Car>();

            CreateMap<Bus, BusDTO>();
            CreateMap<BusDTO, Bus>();

            CreateMap<Truck, TruckDTO>();
            CreateMap<TruckDTO, Truck>();
        }
    }
}
