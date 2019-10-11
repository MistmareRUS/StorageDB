using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using StorageDBCourseWork.Models;
using StorageDBCourseWork.Repositories;

namespace StorageDBCourseWork.Controllers
{
    public class MovingItemsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: MovingItems
        public ActionResult Index()
        {
            var movingItems = db.MovingItems.Include(m => m.StorageFrom).Include(m => m.StorageTo);
            return View(movingItems.ToList());
        }

        // GET: MovingItems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovingItem movingItem = db.MovingItems.Find(id);
            if (movingItem == null)
            {
                return HttpNotFound();
            }
            return View(movingItem);
        }

        // GET: MovingItems/Create
        public ActionResult Create()
        {
            ViewBag.StorageFromId = new SelectList(db.Storages, "Id", "Name");
            ViewBag.StorageToId = new SelectList(db.Storages, "Id", "Name");
            return View();
        }

        // POST: MovingItems/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Date,StorageFromId,StorageToId")] MovingItem movingItem)
        {
            if (ModelState.IsValid)
            {
                db.MovingItems.Add(movingItem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.StorageFromId = new SelectList(db.Storages, "Id", "Name", movingItem.StorageFromId);
            ViewBag.StorageToId = new SelectList(db.Storages, "Id", "Name", movingItem.StorageToId);
            return View(movingItem);
        }

        // GET: MovingItems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovingItem movingItem = db.MovingItems.Find(id);
            if (movingItem == null)
            {
                return HttpNotFound();
            }
            ViewBag.StorageFromId = new SelectList(db.Storages, "Id", "Name", movingItem.StorageFromId);
            ViewBag.StorageToId = new SelectList(db.Storages, "Id", "Name", movingItem.StorageToId);
            return View(movingItem);
        }

        // POST: MovingItems/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Date,StorageFromId,StorageToId")] MovingItem movingItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movingItem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.StorageFromId = new SelectList(db.Storages, "Id", "Name", movingItem.StorageFromId);
            ViewBag.StorageToId = new SelectList(db.Storages, "Id", "Name", movingItem.StorageToId);
            return View(movingItem);
        }

        // GET: MovingItems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovingItem movingItem = db.MovingItems.Find(id);
            if (movingItem == null)
            {
                return HttpNotFound();
            }
            return View(movingItem);
        }

        // POST: MovingItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MovingItem movingItem = db.MovingItems.Find(id);
            db.MovingItems.Remove(movingItem);
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
