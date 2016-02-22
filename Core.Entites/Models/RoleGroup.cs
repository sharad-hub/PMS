using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entites.Models
{
    public class RoleGroup:BaseEntity
    {      
        public virtual ICollection<TaskRole> Roles { get; set; }
        public string Name { get; set; }
    }
}
