using System;
using System.Collections.Generic;

namespace IYTEthesis.Model
{
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string GSM { get; set; }
        public Nullable<double> Lat { get; set; }
        public Nullable<double> Lng { get; set; }
        public Nullable<System.DateTime> LastUpdate { get; set; }
    }
}
