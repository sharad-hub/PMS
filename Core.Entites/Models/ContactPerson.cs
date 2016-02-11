using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Entites.Models
{
    public class ContactPerson 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ContactDetail> ContactDetails { get; set; }
    }
}
