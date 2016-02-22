using Core.Data.Infrastructure;
using Core.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Repositories
{
  public  class DesignationRepository : RepositoryBase<Designation>, IDesignationRepository
    {
        public DesignationRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {

        }
    }

    public interface IDesignationRepository : IRepository<Designation>
    {
    }

}