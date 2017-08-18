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
    public abstract class Vehicle : IVehicle
    {
        #region Fields
        private int passagerCapacity;
        private decimal pricePerKilometer;
        private VehicleType type;
        #endregion

        public Vehicle(int passagerCapacity, decimal pricePerKilometer)
        {
            this.PassangerCapacity = passagerCapacity;
            this.PricePerKilometer = pricePerKilometer;
        }

        public Vehicle(decimal pricePerKilometer)
        {
            this.PricePerKilometer = pricePerKilometer;
        }

        public Vehicle(int passagerCapacity)
        {
            this.PassangerCapacity = passagerCapacity;
        }

        #region Properties
        public int PassangerCapacity
        {
            get
            {
                return this.passagerCapacity;
            }
            set
            {
                Validators.NumberValidator(
                    value,
                    GlobalConsts.MinVehiclePassagers,
                    GlobalConsts.MaxVehiclePassagers,
                    Messenger.VehicleCapacityOutOfRange);

                this.passagerCapacity = value;
            }
        }

        public decimal PricePerKilometer
        {
            get
            {
                return this.pricePerKilometer;
            }
            set
            {
                Validators.NumberValidator(
                    value,
                    GlobalConsts.MinVehiclePricePerKM,
                    GlobalConsts.MaxVehiclePricePerKM,
                    Messenger.VehiclePricePerKMOutOfRange);

                this.pricePerKilometer = value;
            }
        }

        public abstract VehicleType Type
        {
            get; set;
        }
        #endregion

        #region Methods

        //should be OK with "protected" as only children will use it
        protected abstract string DisplayVehicleKind();
        protected abstract string DisplayAdditionalVehicleInformation();

        public override string ToString()
        {
            return string.Format(
                "{0} ----" +
                "\nPassenger capacity: {1}" +
                "\nPrice per kilometer: {2}" +
                "\nVehicle type: {3}" +
                "{4}",
                this.DisplayVehicleKind(),
                this.PassangerCapacity,
                this.PricePerKilometer,
                this.Type,
                this.DisplayAdditionalVehicleInformation());
        }

        #endregion
    }
}
