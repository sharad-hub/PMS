using Core.Entites.Models;
using Core.Logging;
using Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Core.Data.Repositories;
using PMS.Models;
using PMS.ViewModel;
using AutoMapper;
using Web.Core.Extensions;
namespace PMS.Areas.Admin.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Admin/Project
        IProjectService _projectService;
        IUserService _userService;
        IProjectTypeRepository _projectTypeService;
        private ILogger _logger;
        public ProjectController(IProjectService projectService, IUserService userService, IProjectTypeRepository projectTypeService) //, UserBaseRepository userStore)
        {
           _projectService = projectService;
            _userService = userService;
            _projectTypeService = projectTypeService;
            _logger = LogManager.Instance;         
        }
        public ActionResult Index()
        {             
            return View(_projectService.GetAllProjects());
        }
        public ActionResult testv()
        {
            return View(_projectService.GetAllProjects());
        }

        // GET: Admin/Project/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Project/Create
        public ActionResult Create()
        {
           // ProjectViewModel model = new ProjectViewModel
            Project data = new Project();
            ProjectViewModel model = Mapper.Map<Project, ProjectViewModel>(data);
            model.ProjectTypes = _projectTypeService.GetAll().ToSelectListItems(-1);
            return View(model);
        }

        // POST: Admin/Project/Create
        [HttpPost]
        public ActionResult Create(ProjectViewModel data)
        {           
            Project model = Mapper.Map<ProjectViewModel, Project>(data);
            try
            {
                string currentUserId = User.Identity.GetUserId();            
                model.CreatedOn = DateTime.Now;
                model.UpdatedOn = DateTime.Now;
                model.CreatedByUser = _userService.GetUserByGuid(User.Identity.GetUserId()); ;
                _projectService.CreateProject(model);
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
            ProjectViewModel model = Mapper.Map<Project, ProjectViewModel>(_projectService.GetProject(id));
            int selectedProjectType = Convert.ToInt32(model.ProjectTypeId);
            model.ProjectTypes = _projectTypeService.GetAll().ToSelectListItems(selectedProjectType == 0 ? -1 : selectedProjectType);
            return View(model);
        }

        // POST: Admin/Project/Edit/5
        [HttpPost]
        public ActionResult Edit(ProjectViewModel data)//int id, FormCollection collection)
        {
            Project model = Mapper.Map<ProjectViewModel, Project>(data);
            try
            {
                // TODO: Add update logic here
               // model.UpdatedOn = DateTime.Now;
                //model.ModifiedBy = _userService.GetUserByGuid(User.Identity.GetUserId());
                model.ModifiedById = User.Identity.GetUserId();
                _projectService.UpdateProject(model);
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

        // POST: Admin/Project/Delete/5
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
