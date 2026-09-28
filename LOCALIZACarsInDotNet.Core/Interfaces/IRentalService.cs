using System;
using System.Collections.Generic;
using System.Text;

using LOCALIZACarsInDotNet.Core.Entities;

namespace LOCALIZACarsInDotNet.Core.Interfaces
{
    internal interface IRentalService
    {
        void Create(Rental rental);

        void Update(Rental rental);

        void Delete(Rental rental);

        Rental GetById(int rentalId);

        List<Rental> GetByCostumerId(int costumerId);

        List<Rental> GetAll();

        decimal TotalValue(Rental rental);

        bool IsVehicleAvailable(int vehicleId);

        void FinishRental(int rentalId);

        void CancelRental(int rentalId);
    }
}
