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

        public const string NumberOfTrainCartsOutOfRange =
            "A train cannot have less than 1 cart or more than 15 carts.";

        public const string TrainCapacityOutOfRange =
            "A train cannot have less than 30 passengers or more than 150 passengers.";

        public const string BusCapacityOutOfRange =
            "A bus cannot have less than 10 passengers or more than 50 passengers.";

        public const string StartLocationNameLengthOutOfRange =
            "The StartingLocation's length cannot be less than 5 or more than 25 symbols long.";

        public const string DestinationNameLengthOutOfRange =
            "The Destination's length cannot be less than 5 or more than 25 symbols long.";

        public const string JourneyDistanceOutOfRange =
            "The Distance cannot be less than 5 or more than 5000 kilometers.";





    }
}
