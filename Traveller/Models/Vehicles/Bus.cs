using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Models.Enums;
using Traveller.Models.Utils;
using Traveller.Models.Vehicles.Contracts;

namespace Traveller.Models.Vehicles
{
    public class Bus : Vehicle, IBus
    {
        #region Fields
        private int passagerCapacity;
        #endregion

        public Bus(int passagerCapacity, decimal pricePerKilometer)
            :base(pricePerKilometer)
        {
            this.PassangerCapacity = passagerCapacity;
        }


        #region Properties
        public new int PassangerCapacity
        {
            get
            {
                return this.passagerCapacity;
            }
            set
            {
                Validators.NumberValidator(
                    value,
                    GlobalConsts.MinBusPassagers,
                    GlobalConsts.MaxBusPassagers,
                    Messenger.BusCapacityOutOfRange);

                this.passagerCapacity = value;
            }

        }

        public override VehicleType Type
        {
            get
            {
                return VehicleType.Land;
            }
            set
            { }
        }
        #endregion

        #region Methods
        protected override string DisplayAdditionalVehicleInformation()
        {
            return "";
        }

        protected override string DisplayVehicleKind()
        {
            return "Bus";
        }
        #endregion

    }
}
