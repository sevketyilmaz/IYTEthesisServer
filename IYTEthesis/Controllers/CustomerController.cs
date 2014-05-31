﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IYTEthesis.Data;
using IYTEthesis.Model;
using System.Data.Entity;

namespace IYTEthesis.Controllers
{
    public class CustomerController : Controller
    {
        private IYTEthesisDbContext db = new IYTEthesisDbContext();
        //
        // GET: /Customer/
        public ActionResult Index()
        {
            return View(db.Customers.ToList());
        }

        //
        // GET: /Customer/Details/5
        public ActionResult Details(int id = 0)
        {
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        //
        // GET: /Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Customer/Create
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            if(ModelState.IsValid){
                db.Customers.Add(customer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        //
        // GET: /Customer/Edit/5
        public ActionResult Edit(int id = 0)
        {
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        //
        // POST: /Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        //
        // GET: /Customer/Delete/5
        public ActionResult Delete(int id = 0)
        {
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        //
        // POST: /Customer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Customer customer = db.Customers.Find(id);
            db.Customers.Remove(customer);
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
