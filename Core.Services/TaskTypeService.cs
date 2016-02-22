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
    public interface ITaskTypeService
    {
        IEnumerable<TaskType> GetTaskType(string name = null);
        TaskType GetTask(int id);
        TaskType GetTask(string name);
        void CreateTaskType(TaskType category);
        void   SaveTaskType();
    }

    public class TaskTypeService : ITaskTypeService
    {
        private readonly ITaskTypeRepository taskTypeRepository;
        private readonly IUnitOfWork unitOfWork;

        public TaskTypeService(ITaskTypeRepository taskTypeRepository, IUnitOfWork unitOfWork)
        {
            this.taskTypeRepository = taskTypeRepository;
            this.unitOfWork = unitOfWork;
        }



        public IEnumerable<TaskType> GetTaskType(string name = null)
        {
            if (string.IsNullOrEmpty(name))
                return taskTypeRepository.GetAll();
            else
                return taskTypeRepository.GetAll().Where(c => c.Name == name);
        }

        public TaskType GetTask(int id)
        {
            return taskTypeRepository.GetById(id);
        }

        public TaskType GetTask(string name)
        {
            return taskTypeRepository.GetTaskByName(name);
        }

        public void CreateTaskType(TaskType taskType)
        {
            taskTypeRepository.Add(taskType);
        }

        public void SaveTaskType()
        {
            unitOfWork.Commit();
        }
    }
}
