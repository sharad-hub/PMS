using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Core.Data;
using Core.Entites.Models;
using Microsoft.AspNet.Identity;
namespace PMS.Areas.Admin.Controllers
{
    public class TaskRolesController : Controller
    {
        private CoreDbContext db = new CoreDbContext();

        // GET: Admin/TaskRoles
        public async Task<ActionResult> Index()
        {
            var pMSRoles = db.PMSRoles.Include(t => t.CreatedByUser).Include(t => t.ModifiedBy);
            return View(await pMSRoles.ToListAsync());
        }

        // GET: Admin/TaskRoles/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskRole taskRole = await db.PMSRoles.FindAsync(id);
            if (taskRole == null)
            {
                return HttpNotFound();
            }
            return View(taskRole);
        }

        // GET: Admin/TaskRoles/Create
        public ActionResult Create()
        {          
            return View();
        }

        // POST: Admin/TaskRoles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,RoleName,Description,IsActive")] TaskRole taskRole)
        {
            taskRole.CreatedByUserId = User.Identity.GetUserId();
            taskRole.CreatedOn = DateTime.Now;
            taskRole.IsArchieved = false;
            if (ModelState.IsValid)
            {
                db.PMSRoles.Add(taskRole);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }        
            return View(taskRole);
        }

        // GET: Admin/TaskRoles/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskRole taskRole = await db.PMSRoles.FindAsync(id);
            if (taskRole == null)
            {
                return HttpNotFound();
            }          
            return View(taskRole);
        }

        // POST: Admin/TaskRoles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,RoleName,CreatedByUserId,CreatedOn,Description,IsActive,IsArchieved")] TaskRole taskRole)
        {
            taskRole.ModifiedById = User.Identity.GetUserId();
            taskRole.UpdatedOn = DateTime.Now;
          
            if (ModelState.IsValid)
            {
                db.Entry(taskRole).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }         
            return View(taskRole);
        }

        // GET: Admin/TaskRoles/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskRole taskRole = await db.PMSRoles.FindAsync(id);
            if (taskRole == null)
            {
                return HttpNotFound();
            }
            return View(taskRole);
        }

        // POST: Admin/TaskRoles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            TaskRole taskRole = await db.PMSRoles.FindAsync(id);
            db.PMSRoles.Remove(taskRole);
            await db.SaveChangesAsync();
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
