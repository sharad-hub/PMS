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
    public interface IUserService
    {
        // IEnumerable<ApplicationUser> GetUsers(string name = null);
        //ApplicationUser GetUser(int id);
        ApplicationUser GetUserByGuid(string id);
        //void CreateUser(ApplicationUser User);
       // void SaveUser();
    }

    public class UserService : IUserService
    {
        private readonly IApplicationUserRepository repository;
        private readonly IUnitOfWork unitOfWork;

        public UserService(IApplicationUserRepository repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }

        //    #region ICategoryService Members

        //    public IEnumerable<ApplicationUser> GetUsers(string name = null)
        //    {
        //        if (string.IsNullOrEmpty(name))
        //            return repository.GetAll();
        //        else
        //            return repository.GetAll().Where(c => c.FirstName == name);
        //    }

        //    public ApplicationUser GetUser(int id)
        //    {
        //        var category = repository.GetById(id);
        //        return category;
        //    }

        public ApplicationUser GetUserByGuid(string id)
    {
        var user = repository.GetUserById(id);
        return user;
    }

        //    public void CreateUser(ApplicationUser category)
        //    {
        //        repository.Add(category);
        //    }

        //    public void SaveUser()
        //    {
        //        unitOfWork.Commit();
        //    }

        //    #endregion
        //}
    }
}