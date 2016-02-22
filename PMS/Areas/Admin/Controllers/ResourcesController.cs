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
    public class ResourcesController : Controller
    {
        private CoreDbContext db = new CoreDbContext();

        // GET: Admin/Resources
        public async Task<ActionResult> Index()
        {
            var resources = db.Resources.Include(r => r.CreatedByUser).Include(r => r.Designation).Include(r => r.ModifiedBy).Include(r => r.TaskRole).Include(r => r.Team);
            return View(await resources.ToListAsync());
        }

        // GET: Admin/Resources/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Resource resource = await db.Resources.FindAsync(id);
            if (resource == null)
            {
                return HttpNotFound();
            }
            return View(resource);
        }

        // GET: Admin/Resources/Create
        public ActionResult Create()
        {
            ViewBag.UserInfoId = new SelectList(db.Users, "Id", "FirstName"); 
            ViewBag.DesignationId = new SelectList(db.Designations, "Id", "Name");            
            ViewBag.TaskRoleId = new SelectList(db.PMSRoles, "Id", "RoleName");
            ViewBag.TeamId = new SelectList(db.Teams, "Id", "Code");
            return View();
        }

        // POST: Admin/Resources/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name,TeamId,UserInfoId,TaskRoleId,DesignationId,Description,IsActive")] Resource resource)
        {
            resource.CreatedByUserId = User.Identity.GetUserId();
            resource.CreatedOn = DateTime.Now;
            if (ModelState.IsValid)
            {
                db.Resources.Add(resource);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.UserInfoId = new SelectList(db.Users, "Id", "FirstName", resource.UserInfoId); 
            ViewBag.DesignationId = new SelectList(db.Designations, "Id", "Name", resource.DesignationId);           
            ViewBag.TaskRoleId = new SelectList(db.PMSRoles, "Id", "RoleName", resource.TaskRoleId);
            ViewBag.TeamId = new SelectList(db.Teams, "Id", "Code", resource.TeamId);
            return View(resource);
        }

        // GET: Admin/Resources/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Resource resource = await db.Resources.FindAsync(id);
            if (resource == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserInfoId = new SelectList(db.Users, "Id", "FirstName", resource.UserInfoId); 
            ViewBag.DesignationId = new SelectList(db.Designations, "Id", "Name", resource.DesignationId);          
            ViewBag.TaskRoleId = new SelectList(db.PMSRoles, "Id", "RoleName", resource.TaskRoleId);
            ViewBag.TeamId = new SelectList(db.Teams, "Id", "Code", resource.TeamId);
            return View(resource);
        }

        // POST: Admin/Resources/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name,TeamId,UserInfoId,TaskRoleId,DesignationId,CreatedByUserId,CreatedOn,Description,IsActive,IsArchieved")] Resource resource)
        {
            resource.ModifiedById = User.Identity.GetUserId();
            resource.UpdatedOn = DateTime.Now;
            if (ModelState.IsValid)
            {
                db.Entry(resource).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.UserInfoId = new SelectList(db.Users, "Id", "FirstName", resource.UserInfoId);  
            ViewBag.DesignationId = new SelectList(db.Designations, "Id", "Name", resource.DesignationId);           
            ViewBag.TaskRoleId = new SelectList(db.PMSRoles, "Id", "RoleName", resource.TaskRoleId);
            ViewBag.TeamId = new SelectList(db.Teams, "Id", "Code", resource.TeamId);
            return View(resource);
        }

        // GET: Admin/Resources/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Resource resource = await db.Resources.FindAsync(id);
            if (resource == null)
            {
                return HttpNotFound();
            }
            return View(resource);
        }

        // POST: Admin/Resources/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Resource resource = await db.Resources.FindAsync(id);
            db.Resources.Remove(resource);
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
