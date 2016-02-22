using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entites.Models
{
    public class Project : BaseEntity
    {      
        public string Name { get; set; }
        public int? ProjectTypeId { get; set; }
        public virtual ProjectType ProjectType { get; set; }
        public IEnumerable<ResourceInstance> Managers { get; set; }
        //public virtual IEnumerable<ChangeRequest> ChangeRequests { get; set; }
    }
}
