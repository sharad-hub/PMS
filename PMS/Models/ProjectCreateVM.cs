using Core.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PMS.Models
{
    public class ProjectCreateVM
    {
        public Project Project { get; set; }
        public IEnumerable<ProjectType> ProjectTypes { get; set; }
        //public ProjectType SelectedProjectType { get; set; }
    }
}