using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Core.Data;
using Core.Entites.Models;

namespace PMS.Areas.Admin.Controllers
{
    public class TaskTypesController : Controller
    {
        private CoreDbContext db = new CoreDbContext();

        // GET: Admin/TaskTypes
        public ActionResult Index()
        {
            var taskTypes = db.TaskTypes.Include(t => t.CreatedByUser).Include(t => t.ModifiedBy);
            return View(taskTypes.ToList());
        }

        // GET: Admin/TaskTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskType taskType = db.TaskTypes.Find(id);
            if (taskType == null)
            {
                return HttpNotFound();
            }
            return View(taskType);
        }

        // GET: Admin/TaskTypes/Create
        public ActionResult Create()
        {
            ViewBag.CreatedByUserId = new SelectList(db.Users, "Id", "FirstName");
            ViewBag.ModifiedById = new SelectList(db.Users, "Id", "FirstName");
            return View();
        }

        // POST: Admin/TaskTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Order,CreatedByUserId,ModifiedById,CreatedOn,UpdatedOn,Description,IsActive,IsArchieved")] TaskType taskType)
        {
            if (ModelState.IsValid)
            {
                db.TaskTypes.Add(taskType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CreatedByUserId = new SelectList(db.Users, "Id", "FirstName", taskType.CreatedByUserId);
            ViewBag.ModifiedById = new SelectList(db.Users, "Id", "FirstName", taskType.ModifiedById);
            return View(taskType);
        }

        // GET: Admin/TaskTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskType taskType = db.TaskTypes.Find(id);
            if (taskType == null)
            {
                return HttpNotFound();
            }
            ViewBag.CreatedByUserId = new SelectList(db.Users, "Id", "FirstName", taskType.CreatedByUserId);
            ViewBag.ModifiedById = new SelectList(db.Users, "Id", "FirstName", taskType.ModifiedById);
            return View(taskType);
        }

        // POST: Admin/TaskTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Order,CreatedByUserId,ModifiedById,CreatedOn,UpdatedOn,Description,IsActive,IsArchieved")] TaskType taskType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(taskType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CreatedByUserId = new SelectList(db.Users, "Id", "FirstName", taskType.CreatedByUserId);
            ViewBag.ModifiedById = new SelectList(db.Users, "Id", "FirstName", taskType.ModifiedById);
            return View(taskType);
        }

        // GET: Admin/TaskTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskType taskType = db.TaskTypes.Find(id);
            if (taskType == null)
            {
                return HttpNotFound();
            }
            return View(taskType);
        }

        // POST: Admin/TaskTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TaskType taskType = db.TaskTypes.Find(id);
            db.TaskTypes.Remove(taskType);
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
