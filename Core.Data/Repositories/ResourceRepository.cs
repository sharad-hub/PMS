using Core.Data.Infrastructure;
using Core.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Core.Data.Repositories
{
    public class ResourceRepository : RepositoryBase<Resource>, IResourceRepository
    {
        public ResourceRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {

        }
        public Resource GetResourceByName(string resourceName)
        {
            var resource = this.DbContext.Resources.Where(c => c.UserInfo.FirstName == resourceName).FirstOrDefault();

            return resource;
        }
        public override void Update(Resource entity)
        {
            entity.UpdatedOn = DateTime.Now;
            entity.ModifiedBy = entity.ModifiedBy;
            base.Update(entity);
        }
    }
    public interface IResourceRepository : IRepository<Resource>
    {
        Resource GetResourceByName(string resourceName);
    }
}
