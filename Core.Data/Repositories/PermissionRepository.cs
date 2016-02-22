using Core.Data.Infrastructure;
using Core.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Core.Data.Repositories
{
    public class PermissionRepository : RepositoryBase<Permission>, IPermissionRepository
    {
        public PermissionRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {

        }
        public Permission GetPermissionByName(string permissionskName)
        {
            var permissions = this.DbContext.Permissions.Where(c => c.Description == permissionskName).FirstOrDefault();

            return permissions;
        }
        public override void Update(Permission entity)
        {
            entity.UpdatedOn = DateTime.Now;
            entity.ModifiedBy = entity.ModifiedBy;
            base.Update(entity);
        }
    }
    public interface IPermissionRepository : IRepository<Permission>
    {
        Permission GetPermissionByName(string permissionName);
    }
}
