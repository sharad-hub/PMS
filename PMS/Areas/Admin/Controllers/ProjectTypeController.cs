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
    public class ProjectTypeController : Controller
    {
        // GET: Admin/ProjectType
        // GET: Admin/Project
        IProjectTypeService _projectTypeService;
        IUserService _userService;
       // UserBaseRepository userStore;
        private ILogger _logger;
        public ProjectTypeController(IProjectTypeService projectTypeService, IUserService userService) //, UserBaseRepository userStore)
        {
            _projectTypeService = projectTypeService;
            _userService = userService;
            _logger = LogManager.Instance;         
        }
        public ActionResult Index()
        {
            return View(_projectTypeService.GetAllProjectTypes());
        }

        // GET: Admin/Project/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Project/Create
        public ActionResult Create()
        {
            return View(new ProjectType());
        }

        // POST: Admin/Project/Create
        [HttpPost]
        public ActionResult Create(ProjectType model)
        {
            try
            {              
                _projectTypeService.CreateProjectType(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Project/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_projectTypeService.GetProjectType(id));
        }

        // POST: Admin/Project/Edit/5
        [HttpPost]
        public ActionResult Edit(ProjectType model)//int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here               
                _projectTypeService.CreateProjectType(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Project/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }
    }
}