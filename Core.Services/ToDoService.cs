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
    public class ToDoService : IToDoService
    {
        IUnitOfWork unitOfWork;
        IToDoRepository toDoRepository;
        public ToDoService(IUnitOfWork unitOfWork, IToDoRepository toDoRepository)
        {
            this.toDoRepository = toDoRepository;
            this.unitOfWork = unitOfWork;
        }
       public ToDo GetToDo(int id)
        {
            return toDoRepository.GetById(id);
        }
       public IEnumerable<ToDo> GetAllToDo()
        {
            return toDoRepository.GetAll();
        }
       public IEnumerable<ToDo> GetToDoForUser(string userId)
        {
            return toDoRepository.GetMany(u => u.CreatedById == userId);

        }
       public void AddToDo(ToDo toDo)
        {
            toDoRepository.Add(toDo);
            SaveToDo();
        }
       public void UpdateToDo(ToDo toDo)
        {
            toDoRepository.Update(toDo);
            SaveToDo();
        }
      public  void SaveToDo()
        {
            unitOfWork.Commit();
        }
    }

    public interface IToDoService
    {
        ToDo GetToDo(int id);
        IEnumerable<ToDo> GetAllToDo();
        IEnumerable<ToDo> GetToDoForUser(string userId);
        void AddToDo(ToDo toDo);
        void SaveToDo();
        void UpdateToDo(ToDo toDo);
    }
}
