using Core.Data.Infrastructure;
using Core.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Core.Data.Repositories
{
    public class MileStoneRepository : RepositoryBase<MileStone>, IMileStoneRepository
    {
        public MileStoneRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {

        }
        public MileStone GetTaskByName(string taskName)
        {
            var task = this.DbContext.MileStones.Where(c => c.Name == taskName).FirstOrDefault();

            return task;
        }
        public override void Update(MileStone entity)
        {
            entity.UpdatedOn = DateTime.Now;
            entity.ModifiedBy = entity.ModifiedBy;
            base.Update(entity);
        }
    }
    public interface IMileStoneRepository : IRepository<MileStone>
    {
        MileStone GetTaskByName(string taskName);
    }
}
