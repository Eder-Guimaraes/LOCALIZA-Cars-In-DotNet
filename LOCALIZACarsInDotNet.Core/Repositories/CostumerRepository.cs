using System;
using System.Collections.Generic;
using System.Text;

using LOCALIZACarsInDotNet.Core.Entities;
using LOCALIZACarsInDotNet.Core.Repositories.Interfaces;

namespace LOCALIZACarsInDotNet.Core.Repositories
{
    internal class CostumerRepository : ICostumerRepository
    {
        private List<Costumer> _costumers;

        public CostumerRepository()
        {
            _costumers = new List<Costumer>();
        }

        public void Add(Costumer costumer)
        {
            _costumers.Add(costumer);
        }

        public void Update(Costumer costumer)
        {
            var index = _costumers.FindIndex(c => c.Id == costumer.Id);
            if (index != -1)
            {
                _costumers[index] = costumer;
            }
        }

        public void Delete(Costumer costumer)
        {
            _costumers.Remove(costumer);
        }

        public Costumer? GetById(int costumerId)
        {
            return _costumers.FirstOrDefault(c => c.Id == costumerId);
        }

        public List<Costumer> GetAll()
        {
            return _costumers.ToList();
        }
    }
}
