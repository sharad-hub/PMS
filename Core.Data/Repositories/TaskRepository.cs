using Core.Data.Infrastructure;
using Core.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Core.Data.Repositories
{
    public class TaskRepository : RepositoryBase<Tasks>, ITaskRepository
    {
        public TaskRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {

        }
        public Tasks GetTaskByName(string taskName)
        {
            var task = this.DbContext.Tasks.Where(c => c.Name == taskName).FirstOrDefault();

            return task;
        }
        public override void Update(Tasks entity)
        {
            entity.UpdatedOn = DateTime.Now;
            entity.UpdatedBy = entity.UpdatedBy;
            base.Update(entity);
        }
    }
    public interface ITaskRepository : IRepository<Tasks>
    {
        Tasks GetTaskByName(string taskName);
    }
}
