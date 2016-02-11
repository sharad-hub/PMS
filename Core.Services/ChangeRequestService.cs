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
    public class ChangeRequestService : IChangeRequestService
    {
        IChangeRequestRepository changeRequestRepository;
        IUnitOfWork unitOfWork;
        public ChangeRequestService(IChangeRequestRepository changeRequestRepository, IUnitOfWork unitOfWork)
        {
            this.changeRequestRepository = changeRequestRepository;
            this.unitOfWork = unitOfWork;
        }
        public IEnumerable<ChangeRequest> GetAllChangeRequests(string name = null)
        {
            if (name == null)
                return changeRequestRepository.GetAll();
            else
                return changeRequestRepository.GetMany(x => x.Name == name);
        }

        public ChangeRequest GetChangeRequest(int id)
        {
            return changeRequestRepository.GetById(id);
        }

        //public ChangeRequest GetChangeRequest(string name)
        //{
        //    return changeRequestRepository.get
        //}

        public void UpdateChangeRequest(ChangeRequest entity)
        {
            changeRequestRepository.Update(entity);
        }

        public void CreateChangeRequest(ChangeRequest entity)
        {
            changeRequestRepository.Add(entity);
        }
    }
    public interface IChangeRequestService 
    {
        IEnumerable<ChangeRequest> GetAllChangeRequests(string name = null);
        ChangeRequest GetChangeRequest(int id);
        //ChangeRequest GetChangeRequest(string name);
        void UpdateChangeRequest(ChangeRequest entity);
        void CreateChangeRequest(ChangeRequest entity);
    }
}
