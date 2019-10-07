using SrorageCourseWork.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SrorageCourseWork.Controllers
{
    public class HomeController : Controller
    {
        StorageContext db;
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
        public HomeController()
        {
            db = new StorageContext();
        }
        public ActionResult Index()
        {

            return View(db.Storages.ToList());
        }        
    }
}