using Core.Data.Infrastructure;
using Core.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Core.Data.Repositories
{
    public class RoleRepository : RepositoryBase<TaskRole>, IRoleRepository
    {
        public RoleRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {

        }
        public TaskRole GetRoleyName(string roleName)
        {
            var task = this.DbContext.PMSRoles.Where(c => c.Description == roleName).FirstOrDefault();

            return task;
        }
        public override void Update(TaskRole entity)
        {
            entity.UpdatedOn = DateTime.Now;
            entity.ModifiedBy = entity.ModifiedBy;
            base.Update(entity);
        }
    }
    public interface IRoleRepository : IRepository<TaskRole>
    {
        TaskRole GetRoleyName(string roleName);
    }
}
