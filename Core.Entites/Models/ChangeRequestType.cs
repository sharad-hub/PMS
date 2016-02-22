using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Entites.Models
{
  public class ChangeRequestType:BaseEntity
    {      
        public string Name { get; set; }
        public string OtherProperties { get; set; }
    }
}
