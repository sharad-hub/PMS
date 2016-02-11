using System.Collections;
using System.Collections.Generic;

namespace Core.Entites.Models
{
   public class ClientInfo:BaseEntity
    {
       
        public string Name { get; set; }
        public virtual ICollection<ContactPerson> ContactPersons { get; set; }
        public string Address { get; set; }
    }


}
