using Core.Logging;
using Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Areas.Admin.Controllers
{
    public class TaskTypeController : Controller
    {
        ITaskService _taskService;
        private ILogger _logger;
        // GET: Admin/TaskType
        public ActionResult Index()
        {
            return View();
        }

        // GET: Admin/TaskType/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/TaskType/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/TaskType/Create
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

        // GET: Admin/TaskType/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/TaskType/Edit/5
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

        // GET: Admin/TaskType/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/TaskType/Delete/5
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
