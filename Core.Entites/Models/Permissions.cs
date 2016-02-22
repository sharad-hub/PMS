using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entites.Models
{
  public  class Permission : BaseEntity
    {
       // public virtual ApplicationUser User { get; set; }
        public string AreaName { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public virtual List<TaskRole> AllowedRoles { get; set; }
       // public Lis MyProperty { get; set; }
        public AccessLevel AccessLevel { get; set; }
    }
}
