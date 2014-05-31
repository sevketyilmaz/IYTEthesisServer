using System;
using System.Collections.Generic;


namespace IYTEthesis.Model
{
    public partial class OnlineVehicle
    {
        public int VehicleId { get; set; }
        public Nullable<int> DriverId { get; set; }
        public Nullable<int> StatusId { get; set; }
        public Nullable<double> Lat { get; set; }
        public Nullable<double> Lng { get; set; }
        public Nullable<System.DateTime> LastUpdate { get; set; }
        public Nullable<int> JobId { get; set; }
        public virtual Job Job { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public virtual VehicleStatus VehicleStatus { get; set; }
    }
}
