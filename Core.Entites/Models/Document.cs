using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entites.Models
{
   public class Document:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<DocumentVersion> DocVersions { get; set; }
    }
}
