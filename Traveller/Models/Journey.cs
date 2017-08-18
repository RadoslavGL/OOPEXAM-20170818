using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Models.Contracts;
using Traveller.Models.Vehicles.Contracts;

namespace Traveller.Models
{
    public class Journey : IJourney
    {


        public string Destination => throw new NotImplementedException();

        public int Distance => throw new NotImplementedException();

        public string StartLocation => throw new NotImplementedException();

        public IVehicle Vehicle => throw new NotImplementedException();

        public decimal CalculateTravelCosts()
        {
            throw new NotImplementedException();
        }
    }
}
