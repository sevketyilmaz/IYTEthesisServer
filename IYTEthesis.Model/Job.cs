using System;
using System.Collections.Generic;

namespace IYTEthesis.Model
{
    public partial class Job
    {
        public Job()
        {
            this.OnlineVehicles = new List<OnlineVehicle>();
        }

        public int JobId { get; set; }
        public Nullable<int> DriverId { get; set; }
        public Nullable<int> VehicleId { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<System.DateTime> RequestDate { get; set; }
        public Nullable<System.DateTime> PickupDate { get; set; }
        public Nullable<System.DateTime> DropDate { get; set; }
        public Nullable<double> PickupLat { get; set; }
        public Nullable<double> PickupLng { get; set; }
        public Nullable<double> DropLat { get; set; }
        public Nullable<double> DropLng { get; set; }
        public virtual ICollection<OnlineVehicle> OnlineVehicles { get; set; }
    }
}
