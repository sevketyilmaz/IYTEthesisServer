using System;
using System.Collections.Generic;

namespace IYTEthesis.Model
{
    public partial class Owner
    {
        public Owner()
        {
            this.Vehicles = new List<Vehicle>();
        }

        public int OwnerId { get; set; }
        public string OwnerName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string GSM { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
