using System;
using System.Collections.Generic;
using System.Text;

using LOCALIZACarsInDotNet.Core.Entites;
using LOCALIZACarsInDotNet.Core.Repositories.Interfaces;

namespace LOCALIZACarsInDotNet.Core.Repositories
{
    internal class VehicleRepository : IVehicleRepository
    {
        private List<Vehicle> _vehicles;

        public VehicleRepository()
        {
            _vehicles = new List<Vehicle>();
        }

        public void Add(Vehicle vehicle)
        {
            _vehicles.Add(vehicle);
        }

        public void Update(Vehicle vehicle)
        {
            var index = _vehicles.FindIndex(v => v.Id == vehicle.Id);
            if (index != -1)
            {
                _vehicles[index] = vehicle;
            }
        }

        public void Delete(Vehicle vehicle)
        {
            _vehicles.Remove(vehicle);
        }

        public Vehicle? GetById(int vehicleId)
        {
            return _vehicles.FirstOrDefault(v => v.Id == vehicleId);
        }

        public List<Vehicle> GetAll()
        {
            return _vehicles.ToList();
        }
    }
}
