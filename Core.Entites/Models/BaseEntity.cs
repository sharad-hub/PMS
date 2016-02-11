using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entites.Models
{
   public class BaseEntity
    {
        public int Id { get; set; }
        public virtual ApplicationUser CreatedBy { get; set; }
        public virtual ApplicationUser ModifiedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
