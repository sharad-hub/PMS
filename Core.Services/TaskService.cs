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
    public interface ITaskService
    {
        IEnumerable<Tasks> GetTasks(string name = null);
        Tasks GetTask(int id);
        Tasks GetTask(string name);
        void CreateTask(Tasks category);
        void   SaveTask();
    }

    public class TaskService : ITaskService
    {
        private readonly ITaskRepository tasksRepository;
        private readonly IUnitOfWork unitOfWork;

        public TaskService(ITaskRepository tasksRepository, IUnitOfWork unitOfWork)
        {
            this.tasksRepository = tasksRepository;
            this.unitOfWork = unitOfWork;
        }

        #region ICategoryService Members

        public IEnumerable<Tasks> GetTasks(string name = null)
        {
            if (string.IsNullOrEmpty(name))
                return tasksRepository.GetAll();
            else
                return tasksRepository.GetAll().Where(c => c.Name == name);
        }

        public Tasks GetTask(int id)
        {
            var category = tasksRepository.GetById(id);
            return category;
        }

        public Tasks GetTask(string name)
        {
            var category = tasksRepository.GetTaskByName(name);
            return category;
        }

        public void CreateTask(Tasks category)
        {
            tasksRepository.Add(category);
        }

        public void SaveTask()
        {
            unitOfWork.Commit();
        }

        #endregion
    }
}
