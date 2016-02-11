using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entites.Models
{
   public class ContactDetail
    {
        public int Id { get; set; }
        public ContactType Type { get; set; }
        public string Value { get; set; }
        public int Order { get; set; }
    }

}
