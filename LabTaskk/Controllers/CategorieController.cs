using LabTaskk.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabTaskk.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Category()
        {
            var db = new LabTaskEntities2();
            var data = db.Categories1.ToList();
            return View(data);
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Edit()
        {
            return View();
        }
        public ActionResult Delete()
        {
            return View();
        }
    }
}