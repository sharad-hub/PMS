using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Core.Entites.Models
{
   public class Tasks:BaseEntity
    {      
        public string Name { get; set; }
        public Resource AssignedTo { get; set; }
        public int TimeInHrs { get; set; }       
        public virtual TaskType TaskType { get; set; }
        public virtual TaskStatus TaskStatus  { get; set; }
    }
}
