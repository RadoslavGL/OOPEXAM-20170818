using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Models.Enums;
using Traveller.Models.Vehicles.Contracts;

namespace Traveller.Models.Vehicles
{
    public class Airplane : Vehicle, IAirplane
    {
        #region Fields
        private bool hasFreeFood;
        #endregion

        public Airplane(int passagerCapacity, decimal pricePerKilometer, bool hasFreeFood)
            :base(passagerCapacity,pricePerKilometer)
        {
            this.HasFreeFood = hasFreeFood;
        }

        #region Properties
        public bool HasFreeFood
        {
            get; set;
        }

        public override VehicleType Type
        {
            get
            {
                return VehicleType.Air;
            }
            set
            { }
        }

        #endregion

        #region Methods
        protected override string DisplayAdditionalVehicleInformation()
        {
           return string.Format(
                "\nHas free food: {0}",
                this.HasFreeFood);
        }

        protected override string DisplayVehicleKind()
        {
            return "Airplane";
        }
        #endregion

    }
}
