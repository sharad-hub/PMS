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
    public class BugTypesController : Controller
    {
        private CoreDbContext db = new CoreDbContext();

        // GET: Admin/BugTypes
        public ActionResult Index()
        {
            return View(db.BugTypes.ToList());
        }

        // GET: Admin/BugTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BugType bugType = db.BugTypes.Find(id);
            if (bugType == null)
            {
                return HttpNotFound();
            }
            return View(bugType);
        }

        // GET: Admin/BugTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/BugTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Description")] BugType bugType)
        {
            if (ModelState.IsValid)
            {
                db.BugTypes.Add(bugType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bugType);
        }

        // GET: Admin/BugTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BugType bugType = db.BugTypes.Find(id);
            if (bugType == null)
            {
                return HttpNotFound();
            }
            return View(bugType);
        }

        // POST: Admin/BugTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Description")] BugType bugType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bugType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bugType);
        }

        // GET: Admin/BugTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BugType bugType = db.BugTypes.Find(id);
            if (bugType == null)
            {
                return HttpNotFound();
            }
            return View(bugType);
        }

        // POST: Admin/BugTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BugType bugType = db.BugTypes.Find(id);
            db.BugTypes.Remove(bugType);
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
