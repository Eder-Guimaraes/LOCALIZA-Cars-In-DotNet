using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using LOCALIZACarsInDotNet.Core.Repositories.Interfaces;
using LOCALIZACarsInDotNet.Core.Entities;

namespace LOCALIZACarsInDotNet.Core.Repositories
{
    internal class RentalRepository : IRentalRepository
    {
        private List<Rental> _rentals;

        public RentalRepository()
        {
            _rentals = new List<Rental>();
        }

        public void Add(Rental rental)
        {
            _rentals.Add(rental);
        }

        public void Update(Rental rental)
        {
            var index = _rentals.FindIndex(r => r.Id == rental.Id);
            if (index != -1)
            {
                _rentals[index] = rental;
            }
        }

        public void Delete(Rental rental)
        {
            _rentals.Remove(rental);
        }

        public Rental? GetById(int rentalId)
        {
            return _rentals.FirstOrDefault(r => r.Id == rentalId);
        }

        public List<Rental> GetAll()
        {
            return _rentals.ToList();
        }

        public List<Rental> GetByCustomerId(int costumerId)
        {
            return _rentals.Where(r => r.Id == costumerId).ToList();
        }
    }
}
