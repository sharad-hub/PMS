using Core.Entites.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entites.Models
{
    public class Assignment : BaseEntity
    {
        public int Id { get; set; }
        public string TaskName { get; set; }  
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public Priority Priority { get; set; }
        public Resource Resource { get; set; }
   }

   
}
