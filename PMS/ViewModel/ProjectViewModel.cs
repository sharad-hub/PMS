using Core.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.ViewModel
{
    public class ProjectViewModel:BaseEntity
    {
        public string Name { get; set; }
        public virtual ProjectType ProjectType { get; set; }
        public int? ProjectTypeId { get; set; }
        public IEnumerable<SelectListItem> ProjectTypes { get; set; }
    }
}