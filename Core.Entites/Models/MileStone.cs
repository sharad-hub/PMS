using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entites.Models
{
   public class MileStone:BaseEntity
    {
        public string Name { get; set; }
      //public Project Project { get; set; }
        public ChangeRequest ChangeRequest { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Resource AssignedTo { get; set; }
    }
}
