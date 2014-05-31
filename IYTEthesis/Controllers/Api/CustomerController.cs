using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using IYTEthesis.Data.Contracts;
using IYTEthesis.Model;
using IYTEthesis.Data;

namespace IYTEthesis.Controllers.Api
{
    public class CustomerController : ApiBaseController
    {

        public CustomerController(IiyteThesisUow uow)
        {
            Uow = uow;
        }

        #region OData Future : IQueryable<T>
        #endregion

        // GET api/customer
        public IEnumerable<Customer> Get()
        {
            return Uow.Customers.GetAll();
        }

        // GET api/customer/5
        public Customer Get(int id)
        {
            Customer customer = Uow.Customers.GetById(id);

            if (customer == null)
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));

            return customer;
        }

        // POST api/customer
        //public Customer Post([FromBody]LoginModel model)
        //{
        //    Customer customer = Uow.Customers.GetAll().Where(c =>
        //                            c.CustomerName == model.UserName && c.Password == model.Password)
        //                            .FirstOrDefault();

        //    return customer;
        //}

        //// PUT api/customer/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/customer/5
        //public void Delete(int id)
        //{
        //}
    }
}
