using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveller.Models.Utils
{
    public class GlobalConsts
    {
        public const int MinVehiclePassagers = 30;
        public const int MaxVehiclePassagers = 150;

        public const int MinTrainPassagers = 1;
        public const int MaxTrainPassagers = 800;

        public const int MinBusPassagers = 10;
        public const int MaxBusPassagers = 50;

        public const decimal MinVehiclePricePerKM = 0.1m;
        public const decimal MaxVehiclePricePerKM = 2.5m;

        public const int MinTrainCarts = 1;
        public const int MaxTrainCarts = 15;

        public const int MinLocationNameLength = 5;
        public const int MaxLocationNameLength = 25;

        public const int MinDistance= 5;
        public const int MaxDistance = 5000;



    }
}
