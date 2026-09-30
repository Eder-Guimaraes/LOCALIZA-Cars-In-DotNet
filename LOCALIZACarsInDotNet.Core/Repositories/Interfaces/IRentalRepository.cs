using System;
using System.Collections.Generic;
using System.Text;
using LOCALIZACarsInDotNet.Core.Entities;

namespace LOCALIZACarsInDotNet.Core.Repositories.Interfaces
{
    internal interface IRentalRepository
    {
        void Add(Rental rental);

        void Update(Rental rental);

        void Delete(Rental rental);

        Rental? GetById(int rentalId);

        List<Rental> GetAll();

        List<Rental> GetByCustomerId(int costumerId);
    }
}
