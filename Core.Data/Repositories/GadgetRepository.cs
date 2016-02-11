using Core.Data.Infrastructure;
using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Repositories
{
    public class GadgetRepository : RepositoryBase<Gadget>, IGadgetRepository
    {
        public GadgetRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IGadgetRepository : IRepository<Gadget>
    {

    }
}
