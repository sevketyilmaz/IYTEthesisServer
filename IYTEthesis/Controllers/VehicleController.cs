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
    public class VehicleController : Controller
    {
        private IYTEthesisDbContext db = new IYTEthesisDbContext();
        //
        // GET: /Vehicle/
        public ActionResult Index()
        {
            return View(db.Vehicles.ToList());
        }

        //
        // GET: /Vehicle/Details/5
        public ActionResult Details(int id = 0)
        {
            Vehicle vehicle = db.Vehicles.Find(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            return View(vehicle);
        }

        //
        // GET: /Vehicle/Create
        public ActionResult Create()
        {
            ViewBag.DriverId = new SelectList(db.Drivers, "DriverId", "DriverName");
            ViewBag.OwnerId = new SelectList(db.Owners, "OwnerId", "OwnerName");
            return View();
        }

        //
        // POST: /Vehicle/Create
        [HttpPost]
        public ActionResult Create(Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                db.Vehicles.Add(vehicle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DriverId = new SelectList(db.Drivers, "DriverId", "DriverName", vehicle.DriverId);
            ViewBag.OwnerId = new SelectList(db.Owners, "OwnerId", "OwnerName", vehicle.OwnerId);
            return View(vehicle);
        }

        //
        // GET: /Vehicle/Edit/5
        public ActionResult Edit(int id = 0)
        {
            Vehicle vehicle= db.Vehicles.Find(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            ViewBag.DriverId = new SelectList(db.Drivers, "DriverId", "DriverName", vehicle.DriverId);
            ViewBag.OwnerId = new SelectList(db.Owners, "OwnerId", "OwnerName", vehicle.OwnerId);
            return View(vehicle);
        }

        //
        // POST: /Vehicle/Edit/5
        [HttpPost]
        public ActionResult Edit(Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vehicle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DriverId = new SelectList(db.Drivers, "DriverId", "DriverName", vehicle.DriverId);
            ViewBag.OwnerId = new SelectList(db.Owners, "OwnerId", "OwnerName", vehicle.OwnerId);
            return View(vehicle);
        }

        //
        // GET: /Vehicle/Delete/5
        public ActionResult Delete(int id = 0)
        {
            Vehicle vehicle = db.Vehicles.Find(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            return View(vehicle);
        }

        //
        // POST: /Vehicle/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Vehicle vehicle = db.Vehicles.Find(id);
            db.Vehicles.Remove(vehicle);
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
