using System;
using System.Collections.Generic;
using System.Text;
using LOCALIZACarsInDotNet.Core.Entites;

namespace LOCALIZACarsInDotNet.Core.Interfaces
{
    internal interface IVehicleRepository
    {
        void Add(Vehicle vehicle);

        void Update(Vehicle vehicle);

        void Delete(Vehicle vehicle);

        Vehicle? GetById(int vehicleId);

        List<Vehicle> GetAll();
    }
}
