using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entites.Models
{
   public class Bug 
    {
        public int Id { get; set; }
        public int Description { get; set; }
        public virtual ChangeRequest ChangeRequest { get; set; }
        public virtual Resource RaisedBy { get; set; }
        public virtual Resource AssignedTo{ get; set; }
        public DateTime AssignedOn { get; set; }
        public DateTime FixedOn { get; set; }
        public int TimeTakenToFix { get; set; }
        public virtual BugType BugType { get; set; }
    }
}
