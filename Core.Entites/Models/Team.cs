using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entites.Models
{
 public  class Team:BaseEntity
    {
     public Team()
     {
         Resources = new List<Resource>();
     }
       
        public string Code { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Resource> Resources { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedBy { get; set; }
        public string Description { get; set; }
    }
}
