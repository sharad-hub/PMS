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
    public interface ITaskGroupService
    {
        IEnumerable<TaskGroup> GetTaskGroup(string name = null);
        TaskGroup GetTask(int id);
        TaskGroup GetTask(string name);
        void CreateTask(TaskGroup category);
        void   SaveTask();
    }

    public class TaskGroupService : ITaskGroupService
    {
        private readonly ITaskGroupRepository taskGroupRepository;
        private readonly IUnitOfWork unitOfWork;

        public TaskGroupService(ITaskGroupRepository taskGroupRepository, IUnitOfWork unitOfWork)
        {
            this.taskGroupRepository = taskGroupRepository;
            this.unitOfWork = unitOfWork;
        }

        #region ICategoryService Members

        public IEnumerable<TaskGroup> GetTaskGroup(string name = null)
        {
            if (string.IsNullOrEmpty(name))
                return taskGroupRepository.GetAll();
            else
                return taskGroupRepository.GetAll().Where(c => c.Description == name);
        }

        public TaskGroup GetTask(int id)
        {
            var category = taskGroupRepository.GetById(id);
            return category;
        }

        public TaskGroup GetTask(string name)
        {
            var category = taskGroupRepository.GetTaskByName(name);
            return category;
        }

        public void CreateTask(TaskGroup category)
        {
            taskGroupRepository.Add(category);
        }

        public void SaveTask()
        {
            unitOfWork.Commit();
        }

        #endregion
    }
}
