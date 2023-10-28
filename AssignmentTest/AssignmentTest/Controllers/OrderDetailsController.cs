using AssignmentTest.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssignmentTest.Controllers
{
    public class OrderDetailsController : Controller
    {
        // GET: OrderDetails
        public ActionResult OrderDetails()
        {
            var db = new AssignmentDatabaseEntities();
            var data = db.OrderDetails.ToList();
            return View(data);
        }
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(OrderDetail ot)
        {
            var db = new AssignmentDatabaseEntities();
            db.OrderDetails.Add(ot);
            db.SaveChanges();
            return RedirectToAction("OrderDetails");

        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var db = new AssignmentDatabaseEntities();
            var data = db.OrderDetails.Find(Id);
            return View(data);

        }
        [HttpPost]
        public ActionResult Edit(OrderDetail ot)
        {
            var db = new AssignmentDatabaseEntities();
            var ex = db.OrderDetails.Find(ot.Id);
            ex.Id = ot.Id;
            db.SaveChanges();
            return RedirectToAction("OrderDetails");


        }
        public ActionResult Delete(int id)
        {
            var db = new AssignmentDatabaseEntities();
            var data = db.OrderDetails.Find(id);
            db.OrderDetails.Remove(data);
            db.SaveChanges();
            return RedirectToAction("OrderDetails");
        }
        public ActionResult Details(int id)
        {
            var db = new AssignmentDatabaseEntities();
            var details = db.OrderDetails.Find(id);

            return View(details);

        }
    }
}