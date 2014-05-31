using System;
using System.Collections.Generic;

namespace IYTEthesis.Model
{
    public partial class Driver
    {
        public Driver()
        {
            this.Vehicles = new List<Vehicle>();
        }

        public int DriverId { get; set; }
        public string DriverName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string GSM { get; set; }
        public string DriverLicence { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
