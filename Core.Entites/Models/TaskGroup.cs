using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Entites.Models
{
   public class TaskGroup:BaseEntity
    {     
        public virtual ChangeRequestType ChangeRequestType { get; set; }
    }
}
