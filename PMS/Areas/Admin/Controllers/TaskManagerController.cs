using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Areas.Admin.Controllers
{
    public class TaskManagerController : Controller
    {
        // GET: Admin/TaskManager
        public ActionResult Index()
        {
            return View();
        }
    }
}