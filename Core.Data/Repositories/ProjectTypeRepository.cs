using Core.Data.Infrastructure;
using Core.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Core.Data.Repositories
{
    public class ProjectTypeRepository : RepositoryBase<ProjectType>, IProjectTypeRepository
    {
        public ProjectTypeRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
       

        public override void Update(ProjectType entity)
        {           
            base.Update(entity);
        }
    }

    public interface IProjectTypeRepository : IRepository<ProjectType>
    {
       // ProjectType GetProjectByName(string projectName);
    }
}
