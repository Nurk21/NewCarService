
using CarService.BL.Services;
using CarService.Common.DTO;
using CarService.DAL.Repositories;
using CarService.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CarService.Handlers
{
    public class RepairHandler : IRequestHandler<RepairQuery, IActionResult>
    {
        private readonly IRepairService<T> _repairService;
        public RepairHandler(/*IRepairService<T> repairService*/ IServiceProvider serviceProvider)
        {
            _repairService = serviceProvider.GetRequiredService<IRepairService<T>>();
        }
        public async Task<IActionResult> Handle(RepairQuery request, CancellationToken cancellationToken)
        {             
            string connectionString = "mongodb://localhost:27017";
            MongoClient client = new MongoClient(connectionString);
            IMongoDatabase database = client.GetDatabase("test");
            MongoRepository<SuccessfulRepairDTO> repository = new MongoRepository<SuccessfulRepairDTO>(database, "SuccessfulRepairs");
            await _repairService.Repair();
            await repository.AddAsync(LOGGGGG);
            return Ok();
        }
    }
}
