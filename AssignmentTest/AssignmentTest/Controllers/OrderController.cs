using AssignmentTest.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssignmentTest.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Order()
        {
            var db = new AssignmentDatabaseEntities();
            var data = db.Orders.ToList();
            return View(data);
        }
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(Order ord)
        {
            var db = new AssignmentDatabaseEntities();
            db.Orders.Add(ord);
            db.SaveChanges();
            return RedirectToAction("Order");

        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var db = new AssignmentDatabaseEntities();
            var data = db.Orders.Find(Id);
            return View(data);

        }
        [HttpPost]
        public ActionResult Edit(Order ord)
        {
            var db = new AssignmentDatabaseEntities();
            var ex = db.Products.Find(ord.Id);
            ex.Id = ord.Id;
            db.SaveChanges();
            return RedirectToAction("Order");


        }
        public ActionResult Delete(int id)
        {
            var db = new AssignmentDatabaseEntities();
            var data = db.Orders.Find(id);
            db.Orders.Remove(data);
            db.SaveChanges();
            return RedirectToAction("Order");
        }
        public ActionResult Details(int id)
        {
            var db = new AssignmentDatabaseEntities();
            var details = db.Orders.Find(id);

            return View(details);

        }
    }
}