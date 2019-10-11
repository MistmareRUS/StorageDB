using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using StorageDBCourseWork.Models;
using StorageDBCourseWork.Repositories;

namespace StorageDBCourseWork.Controllers
{
    public class StoragesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public StoragesController()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
        }
        // GET: Storages
        public ActionResult Index()
        {
            return View(db.Storages.ToList());
        }

        // GET: Storages/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Storage storage = db.Storages.FirstOrDefault(s=>s.Id==id);
            var s1 = db.Storages.Include(s=>s.Products).ToList();
            var s2 = db.Storages.ToList();
            if (storage == null)
            {
                return HttpNotFound();
            }
            return View(storage);
        }

        // GET: Storages/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Storages/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Location,Area")] Storage storage)
        {
            if (ModelState.IsValid)
            {
                db.Storages.Add(storage);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(storage);
        }

        // GET: Storages/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Storage storage = db.Storages.Find(id);
            if (storage == null)
            {
                return HttpNotFound();
            }
            return View(storage);
        }

        // POST: Storages/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Location,Area")] Storage storage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(storage).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(storage);
        }

        // GET: Storages/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Storage storage = db.Storages.Find(id);
            if (storage == null)
            {
                return HttpNotFound();
            }
            return View(storage);
        }

        // POST: Storages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Storage storage = db.Storages.Find(id);
            db.Storages.Remove(storage);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
