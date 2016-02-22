using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Entites.Models
{
   public class TaskGroup:BaseEntity
    {
       public TaskGroup()
       {
           Tasks = new List<Tasks>();
       }
        public virtual ChangeRequestType ChangeRequestType { get; set; }
        public IEnumerable<Tasks>  Tasks { get; set; }
    }
}
