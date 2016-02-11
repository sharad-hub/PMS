using Core.Logging;
using Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Areas.Admin.Controllers
{
    public class RoleGroupController : Controller
    {
        ITaskService _taskService;
        private ILogger _logger;
        // GET: Admin/RoleGroup
        public ActionResult Index()
        {
            return View();
        }

        // GET: Admin/RoleGroup/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/RoleGroup/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/RoleGroup/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/RoleGroup/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/RoleGroup/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/RoleGroup/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/RoleGroup/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
