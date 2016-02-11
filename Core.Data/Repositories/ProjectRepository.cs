using Core.Data.Infrastructure;
using Core.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Core.Data.Repositories
{
    public class ProjectRepository : RepositoryBase<Project>, IProjectRepository
    {
        public ProjectRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public Project GetProjectByName(string projectName)
        {
            var category = this.DbContext.Projects.Where(c => c.Name == projectName).FirstOrDefault();

            return category;
        }

        public override void Update(Project entity)
        {
            entity.UpdatedOn = DateTime.Now;
            entity.ModifiedBy = entity.ModifiedBy;
            base.Update(entity);
        }
    }

    public interface IProjectRepository : IRepository<Project>
    {
        Project GetProjectByName(string projectName);
    }
}
