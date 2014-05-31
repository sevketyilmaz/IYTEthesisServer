using System;
using System.Collections.Generic;

namespace IYTEthesis.Model
{
    public partial class Vehicle
    {
        public int VehicleId { get; set; }
        public string NumberPlate { get; set; }
        public Nullable<int> OwnerId { get; set; }
        public Nullable<int> DriverId { get; set; }
        public Nullable<double> Lat { get; set; }
        public Nullable<double> Lng { get; set; }
        public Nullable<System.DateTime> LastUpdate { get; set; }
        public virtual Driver Driver { get; set; }
        public virtual OnlineVehicle OnlineVehicle { get; set; }
        public virtual Owner Owner { get; set; }
    }
}
