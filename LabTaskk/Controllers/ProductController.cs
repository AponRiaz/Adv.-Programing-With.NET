using LabTaskk.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabTaskk.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            var db = new LabTaskEntities2();
            var data = db.Products.ToList();
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
