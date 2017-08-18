using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveller.Models.Utils
{
    public class Messenger
    {
        public const string VehicleCapacityOutOfRange =
            "A vehicle with less than 1 passengers or more than 800 passengers cannot exist!";

        public const string VehiclePricePerKMOutOfRange =
            "A vehicle with a price per kilometer lower than $0.10 or higher than $2.50 cannot exist!";

    }
}
