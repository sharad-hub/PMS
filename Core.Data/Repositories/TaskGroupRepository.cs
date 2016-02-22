using Core.Data.Infrastructure;
using Core.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Core.Data.Repositories
{
    public class TaskGroupRepository : RepositoryBase<TaskGroup>, ITaskGroupRepository
    {
        public TaskGroupRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {

        }
        public TaskGroup GetTaskByName(string taskName)
        {
            var task = this.DbContext.TaskGroups.Where(c => c.Description.Contains(taskName)).FirstOrDefault();
            return task;
        }
        public override void Update(TaskGroup entity)
        {
            entity.UpdatedOn = DateTime.Now;
            entity.ModifiedBy = entity.ModifiedBy;
            base.Update(entity);
        }
    }
    public interface ITaskGroupRepository : IRepository<TaskGroup>
    {
        TaskGroup GetTaskByName(string taskName);
    }
}
