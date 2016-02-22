using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entites.Models
{
   public class Resource:BaseEntity
    {       
        public int? TeamId { get; set; }
        public virtual Team Team { get; set; }
        public string UserInfoId { get; set; }
        public virtual ApplicationUser UserInfo { get; set; }
        public List<TaskRole> TaskRoles { get; set; }
        public int? TaskRoleId { get; set; }
        public virtual TaskRole TaskRole { get; set; }
        public int? DesignationId { get; set; }
        public virtual Designation Designation { get; set; }
    }
}
