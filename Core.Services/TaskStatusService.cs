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
    public interface ITaskStatusService
    {
        IEnumerable<TaskStatus> GetTasks(string name = null);
        TaskStatus GetTask(int id);
        TaskStatus GetTask(string name);
        void CreateTask(TaskStatus category);
        void   SaveTask();
    }

    public class TaskStatusService : ITaskStatusService
    {
        private readonly ITaskStatusRepository repository;
        private readonly IUnitOfWork unitOfWork;

        public TaskStatusService(ITaskStatusRepository repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }

        #region ICategoryService Members

        public IEnumerable<TaskStatus> GetTasks(string name = null)
        {
            if (string.IsNullOrEmpty(name))
                return repository.GetAll();
            else
                return repository.GetAll().Where(c => c.Name == name);
        }

        public TaskStatus GetTask(int id)
        {
            var category = repository.GetById(id);
            return category;
        }

        public TaskStatus GetTask(string name)
        {
            var category = repository.GetTaskByName(name);
            return category;
        }

        public void CreateTask(TaskStatus taskStatus)
        {
            repository.Add(taskStatus);
        }

        public void SaveTask()
        {
            unitOfWork.Commit();
        }

        #endregion
    }
}
