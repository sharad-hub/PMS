using Core.Data.Infrastructure;
using Core.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Entites.Models;

namespace Core.Services
{ 
    // operations you want to expose
    public interface IRoleService
    {
        IEnumerable<TaskRole> GetRoles(string name = null);
        TaskRole GetRole(int id);
        TaskRole GetRoleByName(string name);
        void CreateRole(TaskRole role);
        void SaveRole();
    }

    public class RoleService : IRoleService
    {
        private readonly IRoleRepository repository;
        private readonly IUnitOfWork unitOfWork;

        public RoleService(IRoleRepository repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }

        #region ICategoryService Members

        public IEnumerable<TaskRole> GetRoles(string name = null)
        {
            if (string.IsNullOrEmpty(name))
                return repository.GetAll();
            else
                return repository.GetAll().Where(c => c.Description == name);
        }

        public TaskRole GetRole(int id)
        {
            var category = repository.GetById(id);
            return category;
        }

        public TaskRole GetRoleByName(string name)
        {
            var category = repository.GetRoleyName(name);
            return category;
        }

        public void CreateRole(TaskRole category)
        {
            repository.Add(category);
        }

        public void SaveRole()
        {
            unitOfWork.Commit();
        }

        #endregion
    }
}
