using Core.Data.Infrastructure;
using Core.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Core.Data.Repositories
{
    public class StepManagerRepository : RepositoryBase<StepManager>, IStepManagerRepository
    {
        public StepManagerRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {

        }
        //public Team GetTaskByName(string taskName)
        //{
        //    var task = this.DbContext.StepManager.Where(c => cd == taskName).FirstOrDefault();

        //    return task;
        //}
        public override void Update(StepManager entity)
        {
            entity.UpdatedOn = DateTime.Now;
            entity.ModifiedBy = entity.ModifiedBy;
            base.Update(entity);
        }
    }
    public interface IStepManagerRepository : IRepository<StepManager>
    {
       // Team GetTaskByName(string taskName);
    }
}
