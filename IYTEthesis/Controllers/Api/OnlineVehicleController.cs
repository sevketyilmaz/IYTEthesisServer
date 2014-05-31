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
    public class OnlineVehicleController : ApiBaseController
    {
        public OnlineVehicleController(IiyteThesisUow uow)
        {
            Uow = uow;
        }

        #region OData Future : IQueryable<T>
        #endregion

        //GET api/onlinevehicle
        public IEnumerable<OnlineVehicle> Get()
        {
            return Uow.OnlineVehicles.GetAll();
        }

        //GET api/onlicevehicle/5
        public OnlineVehicle Get(int id)
        {
            OnlineVehicle onlineVehicle = Uow.OnlineVehicles.GetById(id);

            if (onlineVehicle == null)
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));

            return onlineVehicle;
        }

        //PUT api/onlinevehicle
        public HttpResponseMessage Put(OnlineVehicle onlineVehicle)
        {
            //check if the vehicle is online?
            OnlineVehicle ov = Uow.OnlineVehicles.GetAll().Where(o =>
                                    o.VehicleId == onlineVehicle.VehicleId).FirstOrDefault();

            if (ov == null) //we should add to the online vehicles
            {
                Uow.OnlineVehicles.Add(onlineVehicle);
                Uow.Commit();
            }
            else // we should update the online vehicle
            {
                ov.VehicleId = onlineVehicle.VehicleId;
                ov.DriverId = onlineVehicle.DriverId;
                ov.Lat = onlineVehicle.Lat;
                ov.Lng = onlineVehicle.Lng;
                ov.StatusId = onlineVehicle.StatusId;
                ov.LastUpdate = onlineVehicle.LastUpdate;
                ov.JobId = onlineVehicle.JobId;

                Uow.OnlineVehicles.Update(ov);
                Uow.Commit();
            }


            return new HttpResponseMessage(HttpStatusCode.NoContent);
        }

        //// GET api/onlinevehicle
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/onlinevehicle/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/onlinevehicle
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/onlinevehicle/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/onlinevehicle/5
        //public void Delete(int id)
        //{
        //}
    }
}
