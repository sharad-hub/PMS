using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Core.Entites.Models
{
   public class Tasks:BaseEntity
    {
       public Tasks()
       {
           SubTasks = new List<Tasks>();
       }
        public string Name { get; set; }
        public Resource AssignedTo { get; set; }
        public int TimeInHrs { get; set; }
        public int TaskTypeId { get; set; }
        public int TaskStatusId { get; set; }
        public virtual TaskType TaskType { get; set; }
        public virtual TaskStatus TaskStatus  { get; set; }
        public IEnumerable<Tasks>  SubTasks { get; set; }
    }
}
