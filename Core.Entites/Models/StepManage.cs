using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entites.Models
{
   public class StepManager:BaseEntity
    {       
        public string Name { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public virtual ICollection<TaskRole>  AllowedRoles { get; set; }
        public virtual ICollection<ChangeRequestType> AllowedCRTypes { get; set; }
        public int OrderOfStep { get; set; }
    }
}
