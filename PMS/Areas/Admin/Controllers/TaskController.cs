using Core.Entites.Models;
using Core.Logging;
using Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Areas.Admin.Controllers
{
    [Authorize]
    public class TaskController : Controller
    {
        // GET: Admin/Task
        ITaskService _taskService;
        private ILogger _logger;
        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
            _logger = LogManager.Instance;
        }
        public ActionResult Index()
        {
            return View(_taskService.GetTasks().Where(x=>x.TaskStatus.Id==1));
        }

        // GET: Admin/Task/Details/5
        public ActionResult Details(int id)
        {
            return View(_taskService.GetTask(id));
        }

        // GET: Admin/Task/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Task/Create
        [HttpPost]
        public ActionResult Create(Tasks model) //FormCollection collection)
        {
            try
            {
                _taskService.CreateTask(model);
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                _logger.Error(string.Format("Failed to create task : {0}:\n type {1}", model.Name, model.TaskType));            
                return View();
            }
        }

        // GET: Admin/Task/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Task/Edit/5
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

        // GET: Admin/Task/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Task/Delete/5
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
