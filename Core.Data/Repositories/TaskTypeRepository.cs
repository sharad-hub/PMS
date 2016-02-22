using Core.Data.Infrastructure;
using Core.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Core.Data.Repositories
{
    public class TaskTypeRepository : RepositoryBase<TaskType>, ITaskTypeRepository
    {
        public TaskTypeRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {

        }
        public TaskType GetTaskByName(string taskTypeName)
        {
            var task = this.DbContext.TaskTypes.Where(c => c.Name == taskTypeName).FirstOrDefault();

            return task;
        }
        public override void Update(TaskType entity)
        {
            entity.UpdatedOn = DateTime.Now;
            entity.ModifiedBy = entity.ModifiedBy;
            base.Update(entity);
        }
    }
    public interface ITaskTypeRepository : IRepository<TaskType>
    {
        TaskType GetTaskByName(string taskTypeName);
    }
}
