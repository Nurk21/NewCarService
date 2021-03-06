﻿using CarService.BL.Services;
using CarService.Common.DTO;
using CarService.Common.Models.Cars;
using CarService.Controllers;
using CarService.DAL.Repositories;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace CarService
{
    public static class DependencyResolver
    {
        public static void Resolve(IServiceCollection services, IConfiguration configuration)
        {
            var appSettingSection = configuration.GetSection("AppSettings");
            //services.Configure<AppSettings>(appSettingSection);
            services.AddMemoryCache();
            services.AddRouting();
            Repositories(services);
            Services(services);
            Validators(services);
        }


        private static void Validators(IServiceCollection services)
        {
            //services.AddScoped<IClientPaymentDataValidator, ClientPaymentDataValidator>();

        }

        private static void Services(IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddScoped<IRepairService<BaseCar>, RepairService<BaseCar>>();
            //services.AddMediatR(Assembly.GetExecutingAssembly(), typeof(Startup));
            //services.AddScoped<IClientPaymentDataService, ClientPaymentDataService>();
            //services.AddScoped<IOschadPaymentService, OschadPaymentService>();
            //services.AddScoped<ICryptographyService, CryptographyService>();
            //services.AddScoped<IPutSuccessPaymentRecordThroughWINTService, PutSuccessPaymentRecordThroughWINTService>();
            //services.AddScoped<IGetDataFromDBThroughWINTService, GetDataFromDBThroughWINTService>();
            //services.AddSwaggerGen(c =>
            //{
            //    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            //});
            //services.AddHttpClient();
        }

        private static void Repositories(IServiceCollection services)
        {

            //services.AddScoped<IMongoRepository<SuccessfulRepairDTO>, MongoRepository<SuccessfulRepairDTO>>();
        }

    }
}
