using System;
using System.Collections.Generic;
using System.Text;
using LOCALIZACarsInDotNet.Core.Entities;

namespace LOCALIZACarsInDotNet.Core.Repositories.Interfaces
{
    internal interface ICostumerRepository
    {
        void Add(Costumer costumer);

        void Update(Costumer costumer);

        void Delete(Costumer costumer);

        Costumer? GetById(int costumerId);

        List<Costumer> GetAll();
    }
}
