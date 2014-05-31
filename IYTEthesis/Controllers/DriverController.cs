using IYTEthesis.Data;
using IYTEthesis.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IYTEthesis.Controllers
{
    public class DriverController : Controller
    {
        private IYTEthesisDbContext db = new IYTEthesisDbContext();
        //
        // GET: /Driver/
        public ActionResult Index()
        {
            return View(db.Drivers.ToList());
        }

        //
        // GET: /Driver/Details/5
        public ActionResult Details(int id = 0)
        {
            Driver driver = db.Drivers.Find(id);
            if (driver == null)
            {
                return HttpNotFound();
            }
            return View(driver);
        }

        //
        // GET: /Driver/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Driver/Create
        [HttpPost]
        public ActionResult Create(Driver driver)
        {
            if (ModelState.IsValid)
            {
                db.Drivers.Add(driver);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(driver);
        }

        //
        // GET: /Driver/Edit/5
        public ActionResult Edit(int id = 0)
        {
            Driver driver = db.Drivers.Find(id);
            if (driver == null)
            {
                return HttpNotFound();
            }
            return View(driver);
        }

        //
        // POST: /Driver/Edit/5
        [HttpPost]
        public ActionResult Edit(Driver driver)
        {
            if (ModelState.IsValid)
            {
                db.Entry(driver).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(driver);
        }

        //
        // GET: /Driver/Delete/5
        public ActionResult Delete(int id = 0)
        {
            Driver driver = db.Drivers.Find(id);
            if (driver == null)
            {
                return HttpNotFound();
            }
            return View(driver);
        }

        //
        // POST: /Driver/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Driver driver = db.Drivers.Find(id);
            db.Drivers.Remove(driver);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
