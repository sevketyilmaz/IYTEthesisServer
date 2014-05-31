using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using IYTEthesis.Data.Contracts;
using IYTEthesis.Model;

namespace IYTEthesis.Controllers.Api
{
    public class DriverController : ApiBaseController
    {
        public DriverController(IiyteThesisUow uow)
        {
            Uow = uow;
        }

        #region OData Future : IQueryable<T>
        #endregion

        // GET api/driver
        public IEnumerable<Driver> Get()
        {
            return Uow.Drivers.GetAll();
        }

        // GET api/driver/5
        public Driver Get(int id)
        {
            Driver driver = Uow.Drivers.GetById(id);

            if(driver == null)
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));

            return driver;
        }

        //POST api/driver/myvehicle
        //[ActionName("myvehicle")]
        //[HttpPost]
        //public dynamic DriverMyVehicle([FromBody]LoginModel model)
        //{
        //    var query = Uow.Drivers.GetAll().Join(Uow.Vehicles.GetAll(),
        //                                    d => d.DriverId,
        //                                    v => v.DriverId,
        //                                    (d, v) => new
        //                                    {
        //                                        DriverId = d.DriverId,
        //                                        DriverName = d.DriverName,
        //                                        Email = d.Email,
        //                                        Password = d.Password,
        //                                        GSM = d.GSM,
        //                                        DriverLicence = d.DriverLicence,
        //                                        VehicleId = v.VehicleId,
        //                                        NumberPlate = v.NumberPlate
        //                                    }).Where(a=> a.DriverName == model.UserName && 
        //                                                a.Password == model.Password &&
        //                                                a.NumberPlate == model.NumberPlate).FirstOrDefault();
        //    return query;
        //}


        //// PUT api/driver/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/driver/5
        //public void Delete(int id)
        //{
        //}
    }
}
