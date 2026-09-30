using System;
using System.Collections.Generic;
using System.Text;
using LOCALIZACarsInDotNet.Core.Entities;

namespace LOCALIZACarsInDotNet.Core.Services
{
    internal interface IRentalService
    {
        void Create(Rental rental);

        void Cancel(Rental rental);

        decimal TotalValue(Rental rental);

        bool IsVehicleAvailable(int vehicleId);

        void FinishRental(int rentalId);
    }
}
