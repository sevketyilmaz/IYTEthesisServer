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
    public class JobController : ApiBaseController
    {
        public JobController(IiyteThesisUow uow)
        {
            Uow = uow;
        }

        #region OData Future : IQueryable<T>
        #endregion

        // GET api/job
        public IEnumerable<Job> Get()
        {
            return Uow.Jobs.GetAll();
        }

        // GET api/job/5
        public Job Get(int id)
        {
            return Uow.Jobs.GetById(id);
        }

        // GET api/job/getmetaxi
        [ActionName("getmetaxi")]
        [HttpGet]
        public dynamic GetMeTheTaxi([FromBody]Customer customer)
        {
            //JOB_STATUS ? JOB_EXIST = 1 : JOB_NONE = 2;

            return null;
        }

        // Post api/job/jobcontrol
        [ActionName("jobcontrol")]
        [HttpPost]
        public dynamic JobControl([FromBody]JobControlModel jobControlModel)
        {
            var query = Uow.Jobs.GetAll().Join(Uow.OnlineVehicles.GetAll(),
                                        j => j.JobId,
                                        ov => ov.JobId,
                                        (j, ov) => new
                                        {
                                            JobId = j.JobId,
                                            DriverId = j.DriverId,
                                            VehicleId = j.VehicleId,
                                            CustomerId = j.CustomerId,
                                            RequestDate = j.RequestDate,
                                            PickupDate = j.PickupDate,
                                            DropDate = j.DropDate,
                                            PickupLat = j.PickupLat,
                                            PickupLng = j.PickupLng,
                                            DropLat = j.DropLat,
                                            DropLng = j.DropLng,

                                            StatusId = ov.StatusId,
                                            Lat = ov.Lat,
                                            Lng = ov.Lng
                                        }).Where(a => a.VehicleId == jobControlModel.VehicleId && a.StatusId == 1).FirstOrDefault();
            return query;
        }

        //POST api/job/acceptdecline
        [ActionName("acceptdecline")]
        [HttpPost]
        public void AcceptDecline([FromBody]OnlineVehicle onlineVehicle)
        {
            if (onlineVehicle != null)
            {
                Uow.OnlineVehicles.Update(onlineVehicle);
                Uow.Commit();
            }
        }

    }
}
