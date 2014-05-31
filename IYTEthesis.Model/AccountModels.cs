using System;

namespace IYTEthesis.Model
{
    public class LoginModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string NumberPlate { get; set; }

    }

    public class JobControlModel
    {
        public int VehicleId { get; set; }
        public int DriverId { get; set; }
        public int StatusId { get; set; }
    }
    
}
