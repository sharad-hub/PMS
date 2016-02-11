using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Entites.Models;
using Core.Data.Infrastructure;


namespace Core.Data.Repositories
{
    public class ChangeRequestRepository : RepositoryBase<ChangeRequest>, IChangeRequestRepository
    {
        public ChangeRequestRepository(IDbFactory dbContext)
            : base(dbContext)
        {
        }
        public override void Update(ChangeRequest entity)
        {
            entity.UpdatedOn = DateTime.Now;
            entity.ModifiedBy = entity.ModifiedBy;
            base.Update(entity);
        }
    }
    public interface IChangeRequestRepository : IRepository<ChangeRequest>
    {
       
    }
}
