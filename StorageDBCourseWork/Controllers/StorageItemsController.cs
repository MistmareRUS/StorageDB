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
    public class StorageItemsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: StorageItems
        public ActionResult Index()
        {
            var storageItems = db.StorageItems.Include(s => s.Product).Include(s => s.Storage);
            return View(storageItems.ToList());
        }

        // GET: StorageItems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StorageItem storageItem = db.StorageItems.Find(id);
            if (storageItem == null)
            {
                return HttpNotFound();
            }
            return View(storageItem);
        }

        // GET: StorageItems/Create
        public ActionResult Create(int movingItemId)
        {
            ViewBag.ProductId = new SelectList(db.Products, "Id", "Name");
            var mi = db.MovingItems.Find(movingItemId);
            ViewBag.StorageId = mi.StorageToId;
            ViewBag.MovingItemId =mi.Id;
            return View();
        }

        // POST: StorageItems/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StorageItem storageItem)
        {
            if (ModelState.IsValid)
            {
                db.StorageItems.Add(storageItem);
                db.SaveChanges();
                return RedirectToAction("StorageItemsCreate", "MovingItems",new { id=storageItem.MovingItemId });
            }

            ViewBag.ProductId = new SelectList(db.Products, "Id", "Name", storageItem.ProductId);
            ViewBag.StorageId = storageItem.StorageId;
            return View(storageItem);
        }

        // GET: StorageItems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StorageItem storageItem = db.StorageItems.Find(id);
            if (storageItem == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProductId = new SelectList(db.Products, "Id", "Name", storageItem.ProductId);
            ViewBag.StorageId = new SelectList(db.Storages, "Id", "Name", storageItem.StorageId);
            return View(storageItem);
        }

        // POST: StorageItems/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Count,Comment,ProductId,StorageId")] StorageItem storageItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(storageItem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProductId = new SelectList(db.Products, "Id", "Name", storageItem.ProductId);
            ViewBag.StorageId = new SelectList(db.Storages, "Id", "Name", storageItem.StorageId);
            return View(storageItem);
        }

        // GET: StorageItems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StorageItem storageItem = db.StorageItems.Find(id);
            if (storageItem == null)
            {
                return HttpNotFound();
            }
            return View(storageItem);
        }

        // POST: StorageItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StorageItem storageItem = db.StorageItems.Find(id);
            db.StorageItems.Remove(storageItem);
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
