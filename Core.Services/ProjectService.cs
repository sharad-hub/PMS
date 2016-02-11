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
    public class ProjectService : IProjectService
    {
        private IProjectRepository projectRepository;
        private IUnitOfWork unitOfWork;
        public ProjectService(IProjectRepository projectRepository, IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            this.projectRepository = projectRepository;
        }
        public IEnumerable<Project> GetAllProjects(string name = null)
        {
            if (name == null)
                return projectRepository.GetAll();
            else
                return projectRepository.GetMany(x => x.Name == name);
        }

        public Project GetProject(int id)
        {
            return projectRepository.GetById(id);
        }

        public Project GetProject(string name)
        {
            return projectRepository.GetProjectByName(name);
        }

        public void UpdateProject(Project entity)
        {
            projectRepository.Update(entity);
        }

        public void CreateProject(Project entity)
        {
            projectRepository.Add(entity);
        }
    }
    interface IProjectService
    {
        IEnumerable<Project> GetAllProjects(string name = null);
        Project GetProject(int id);
        Project GetProject(string name);
        void UpdateProject(Project entity);
        void CreateProject(Project entity);
    }

}
