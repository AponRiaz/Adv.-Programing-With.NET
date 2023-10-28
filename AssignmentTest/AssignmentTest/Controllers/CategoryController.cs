using AssignmentTest.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssignmentTest.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Category()
        {
            var db = new AssignmentDatabaseEntities();
            var data = db.Categories.ToList();
            return View(data);
        }
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(Category ct)
        {
            var db = new AssignmentDatabaseEntities();
            db.Categories.Add(ct);
            db.SaveChanges();
            return RedirectToAction("Category");

        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var db = new AssignmentDatabaseEntities();
            var data = db.Categories.Find(Id);
            return View(data);

        }
        [HttpPost]
        public ActionResult Edit(Category ct)
        {
            var db = new AssignmentDatabaseEntities();
            var ex = db.Categories.Find(ct.Id);
            ex.Id = ct.Id;
            db.SaveChanges();
            return RedirectToAction("Category");


        }
        public ActionResult Delete(int id)
        {
            var db = new AssignmentDatabaseEntities();
            var data = db.Categories.Find(id);
            db.Categories.Remove(data);
            db.SaveChanges();
            return RedirectToAction("Category");
        }
        public ActionResult Details(int id)
        {
            var db = new AssignmentDatabaseEntities();
            var details = db.Categories.Find(id);

            return View(details);

        }
    }
}