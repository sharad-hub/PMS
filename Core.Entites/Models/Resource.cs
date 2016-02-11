using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entites.Models
{
   public class Resource:BaseEntity
    {
        public string Name { get; set; }
        public virtual Team Team { get; set; }
        public ApplicationUser UserInfo { get; set; }
        public List<Role> TaskRoles { get; set; }
        public Role ActualRole { get; set; }
    }
}
