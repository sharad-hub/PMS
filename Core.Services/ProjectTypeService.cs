using Core.Data.Infrastructure;
using Core.Data.Repositories;
using Core.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class ProjectTypeService : IProjectTypeService
    {
        private IProjectTypeRepository projectRepository;
        private IUnitOfWork unitOfWork;
        public ProjectTypeService(IProjectTypeRepository projectRepository, IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            this.projectRepository = projectRepository;
        }
        public IEnumerable<ProjectType> GetAllProjectTypes(string name = null)
        {
            if (name == null)
                return projectRepository.GetAll();
            else
                return projectRepository.GetMany(x => x.Name == name);
        }

        public ProjectType GetProjectType(int id)
        {
            return projectRepository.GetById(id);
        }

        //public ProjectType GetProjectType(string name)
        //{
        //    return projectRepository.GetProjectByName(name);
        //}

        public void UpdateProjectType(ProjectType entity)
        {
            projectRepository.Update(entity);
            SaveProjectType();
        }

        public void CreateProjectType(ProjectType entity)
        {
            projectRepository.Add(entity);
            SaveProjectType();
        }
        public void SaveProjectType()
        {
            unitOfWork.Commit();
        }
    }
    public interface IProjectTypeService
    {
        IEnumerable<ProjectType> GetAllProjectTypes(string name = null);
        ProjectType GetProjectType(int id);
       // ProjectType GetProjectType(string name);
        void UpdateProjectType(ProjectType entity);
        void CreateProjectType(ProjectType entity);
        void SaveProjectType();

    }

}
