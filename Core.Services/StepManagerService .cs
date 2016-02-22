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
    public interface IStepManagerService
    {
        IEnumerable<StepManager> GetStepManager(string name = null);
        StepManager GetStepManager(int id);
        //StepManager GetStepManager(string name);
        void CreateStepManager(StepManager category);
        void SaveStepManager();
    }

    public class StepManagerervice : IStepManagerService
    {
        private readonly IStepManagerRepository StepManagerRepository;
        private readonly IUnitOfWork unitOfWork;

        public StepManagerervice(IStepManagerRepository StepManagerRepository, IUnitOfWork unitOfWork)
        {
            this.StepManagerRepository = StepManagerRepository;
            this.unitOfWork = unitOfWork;
        }

        #region ICategoryService Members

        public IEnumerable<StepManager> GetStepManager(string name = null)
        {
            if (string.IsNullOrEmpty(name))
                return StepManagerRepository.GetAll();
            else
                return StepManagerRepository.GetAll().Where(c => c.Name == name);
        }

        public StepManager GetStepManager(int id)
        {
            var category = StepManagerRepository.GetById(id);
            return category;
        }

        //public StepManager GetTask(string name)
        //{
        //    var category = StepManagerRepository.(name);
        //    return category;
        //}

        public void CreateStepManager(StepManager category)
        {
            StepManagerRepository.Add(category);
        }

        public void SaveStepManager()
        {
            unitOfWork.Commit();
        }

        #endregion
    }
}
