using AssignmentTest.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssignmentTest.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Product()
        {
            var db = new AssignmentDatabaseEntities();
            var data = db.Products.ToList();
            return View(data);
        }
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(Product pt)
        {
            var db = new AssignmentDatabaseEntities();
            db.Products.Add(pt);
            db.SaveChanges();
            return RedirectToAction("Product");

        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var db = new AssignmentDatabaseEntities();
            var data = db.Products.Find(Id);
            return View(data);

        }
        [HttpPost]
        public ActionResult Edit(Category pt)
        {
            var db = new AssignmentDatabaseEntities();
            var ex = db.Products.Find(pt.Id);
            ex.Id = pt.Id;
            db.SaveChanges();
            return RedirectToAction("Product");


        }
        public ActionResult Delete(int id)
        {
            var db = new AssignmentDatabaseEntities();
            var data = db.Products.Find(id);
            db.Products.Remove(data);
            db.SaveChanges();
            return RedirectToAction("Product");
        }
        public ActionResult Details(int id)
        {
            var db = new AssignmentDatabaseEntities();
            var details = db.Products.Find(id);

            return View(details);

        }

    }
}