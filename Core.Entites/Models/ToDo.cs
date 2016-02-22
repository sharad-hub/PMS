using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entites.Enums;
using System.ComponentModel.DataAnnotations;

namespace Core.Entites.Models
{
   public class ToDo
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public ApplicationUser CreatedBy { get; set; }
        public string CreatedById { get; set; }
        public string ToDoTask { get; set; }
        public string Description { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime TargetDate { get; set; }
        public Priority Priority { get; set; }
        public int? ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
