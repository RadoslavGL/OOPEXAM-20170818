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
    public class Train : Vehicle, ITrain
    {
        #region Fields
        private int carts;
        private int passagerCapacity;
        #endregion

        public Train(int passagerCapacity, decimal pricePerKilometer, int carts) 
            : base(pricePerKilometer) 
            //I am not sure if this is going to work!
            
        {
            this.Carts = carts;
            this.passagerCapacity = PassangerCapacity;
        }
        #region Properties
        public int Carts
        {
            get
            {
                return this.carts;
            }
            set
            {
                Validators.NumberValidator(value,
                    GlobalConsts.MinTrainCarts,
                    GlobalConsts.MaxTrainCarts,
                    Messenger.NumberOfTrainCartsOutOfRange);
                this.carts = value;
            }
        }

        public new int PassangerCapacity
        {
            get
            {
                return this.passagerCapacity;
            }
            set
            {
                Validators.NumberValidator(value,
                    GlobalConsts.MinTrainPassagers,
                    GlobalConsts.MaxTrainPassagers,
                    Messenger.TrainCapacityOutOfRange);

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
            {
            }
        }
        #endregion


        protected override string DisplayAdditionalVehicleInformation()
        {
            return string.Format(
                "\nCarts amount: {0}",
                this.Carts);
        }

        protected override string DisplayVehicleKind()
        {
            return "Train";
        }
    }
}
