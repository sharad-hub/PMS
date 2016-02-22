using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entites.Models
{
   public class ProjectResource
   {
       public ProjectResource()
       {
           ResourceInstances = new List<ResourceInstance>();
       }
       public int Id { get; set; }
       public virtual Project Project { get; set; }
       public int ProjectId { get; set; }
       public IEnumerable<ResourceInstance> ResourceInstances { get; set; }
       
    }
}
