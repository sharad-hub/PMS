using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entites.Models
{
   public class TaskFeature
    {
        public int Id { get; set; }
        public IEnumerable<Tasks> Subtasks { get; set; }
    }
}
