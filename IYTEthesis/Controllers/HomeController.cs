using IYTEthesis.Data.Contracts;
using IYTEthesis.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IYTEthesis.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        
        //GET: /Home/Link
        public ActionResult Link()
        {
            return View();
        }

    }
}
