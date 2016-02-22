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
    public class TaskGroupsController : Controller
    {
        private CoreDbContext db = new CoreDbContext();

        // GET: Admin/TaskGroups
        public ActionResult Index()
        {
            var taskGroups = db.TaskGroups.Include(t => t.CreatedByUser).Include(t => t.ModifiedBy);
            return View(taskGroups.ToList());
        }

        // GET: Admin/TaskGroups/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskGroup taskGroup = db.TaskGroups.Find(id);
            if (taskGroup == null)
            {
                return HttpNotFound();
            }
            return View(taskGroup);
        }

        // GET: Admin/TaskGroups/Create
        public ActionResult Create()
        {
            ViewBag.CreatedByUserId = new SelectList(db.Users, "Id", "FirstName");
            ViewBag.ModifiedById = new SelectList(db.Users, "Id", "FirstName");
            return View();
        }

        // POST: Admin/TaskGroups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CreatedByUserId,ModifiedById,CreatedOn,UpdatedOn,Description,IsActive,IsArchieved")] TaskGroup taskGroup)
        {
            if (ModelState.IsValid)
            {
                db.TaskGroups.Add(taskGroup);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CreatedByUserId = new SelectList(db.Users, "Id", "FirstName", taskGroup.CreatedByUserId);
            ViewBag.ModifiedById = new SelectList(db.Users, "Id", "FirstName", taskGroup.ModifiedById);
            return View(taskGroup);
        }

        // GET: Admin/TaskGroups/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskGroup taskGroup = db.TaskGroups.Find(id);
            if (taskGroup == null)
            {
                return HttpNotFound();
            }
            ViewBag.CreatedByUserId = new SelectList(db.Users, "Id", "FirstName", taskGroup.CreatedByUserId);
            ViewBag.ModifiedById = new SelectList(db.Users, "Id", "FirstName", taskGroup.ModifiedById);
            return View(taskGroup);
        }

        // POST: Admin/TaskGroups/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CreatedByUserId,ModifiedById,CreatedOn,UpdatedOn,Description,IsActive,IsArchieved")] TaskGroup taskGroup)
        {
            if (ModelState.IsValid)
            {
                db.Entry(taskGroup).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CreatedByUserId = new SelectList(db.Users, "Id", "FirstName", taskGroup.CreatedByUserId);
            ViewBag.ModifiedById = new SelectList(db.Users, "Id", "FirstName", taskGroup.ModifiedById);
            return View(taskGroup);
        }

        // GET: Admin/TaskGroups/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskGroup taskGroup = db.TaskGroups.Find(id);
            if (taskGroup == null)
            {
                return HttpNotFound();
            }
            return View(taskGroup);
        }

        // POST: Admin/TaskGroups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TaskGroup taskGroup = db.TaskGroups.Find(id);
            db.TaskGroups.Remove(taskGroup);
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
