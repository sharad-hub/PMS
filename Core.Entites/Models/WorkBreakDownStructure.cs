using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entites.Models
{
  public class WorkBreakDownStructure:BaseEntity
    {        
        public ChangeRequest ChangeRequest { get; set; }
        public List<Tasks> Tasks { get; set; }        
    }
}
