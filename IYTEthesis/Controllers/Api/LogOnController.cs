using IYTEthesis.Data.Contracts;
using IYTEthesis.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IYTEthesis.Controllers.Api
{
    public class LogOnController : ApiBaseController
    {
        public LogOnController(IiyteThesisUow uow)
        {
            Uow = uow;
        }

        #region OData Future : IQueryable<T>
        #endregion

        //Post api/Logon/customer
        [ActionName("customer")]
        [HttpPost]
        public Customer LogonCustomer([FromBody]LoginModel model)
        {
            Customer customer = Uow.Customers.GetAll().Where(c =>
                                    c.CustomerName == model.UserName && c.Password == model.Password)
                                    .FirstOrDefault();

            return customer;
        }

        //doesnt used anymore!!!
        //Post api/Logon/driver
        //[ActionName("driver")]
        //[HttpPost]
        //public Driver LogonDriver([FromBody]LoginModel model)
        //{
        //    Driver driver = Uow.Drivers.GetAll().Where(d =>
        //                        d.DriverName == model.UserName && d.Password == model.Password)
        //                        .FirstOrDefault();

        //    return driver;
        //}

        //POST api/Logon/drivervehicle
        [ActionName("drivervehicle")]
        [HttpPost]
        public dynamic DriverMyVehicle([FromBody]LoginModel model)
        {
            var query = Uow.Drivers.GetAll().Join(Uow.Vehicles.GetAll(),
                                            d => d.DriverId,
                                            v => v.DriverId,
                                            (d, v) => new
                                            {
                                                DriverId = d.DriverId,
                                                DriverName = d.DriverName,
                                                Email = d.Email,
                                                Password = d.Password,
                                                GSM = d.GSM,
                                                DriverLicence = d.DriverLicence,
                                                VehicleId = v.VehicleId,
                                                NumberPlate = v.NumberPlate
                                            }).Where(a => a.DriverName == model.UserName &&
                                                        a.Password == model.Password &&
                                                        a.NumberPlate == model.NumberPlate).FirstOrDefault();
            return query;
        }
    }
}
