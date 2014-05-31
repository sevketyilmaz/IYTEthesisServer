using System;
using System.Collections.Generic;

namespace IYTEthesis.Model
{
    public partial class VehicleStatus
    {
        public VehicleStatus()
        {
            this.OnlineVehicles = new List<OnlineVehicle>();
        }

        public int StatusId { get; set; }
        public string Status { get; set; }
        public virtual ICollection<OnlineVehicle> OnlineVehicles { get; set; }
    }
}
