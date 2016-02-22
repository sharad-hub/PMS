using Core.Data.Infrastructure;
using Core.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Core.Data.Repositories
{
    public class TaskStatusRepository : RepositoryBase<TaskStatus>, ITaskStatusRepository
    {
        public TaskStatusRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {

        }
        public TaskStatus GetTaskByName(string taskName)
        {
            var task = this.DbContext.TaskStatuses.Where(c => c.Name == taskName).FirstOrDefault();

            return task;
        }
        public override void Update(TaskStatus entity)
        {         
            base.Update(entity);
        }
    }
    public interface ITaskStatusRepository : IRepository<TaskStatus>
    {
        TaskStatus GetTaskByName(string taskName);
    }
}
