using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Entites.Models
{
   public class TaskType :BaseEntity
    {
        public string Name { get; set; }
        public int Order { get; set; }
        public virtual RoleGroup AllowedGroup { get; set; }
    }
}
