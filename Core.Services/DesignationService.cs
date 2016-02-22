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
 public class DesignationService :IDesignationService
    {
     UnitOfWork unitOfWork;
     IDesignationRepository designationRepository;
     public DesignationService(UnitOfWork unitOfWork,IDesignationRepository designationRepository)
     {
         this.unitOfWork = unitOfWork;
         this.designationRepository = designationRepository;
     }
     public IEnumerable<Designation> GetAllDesignation()
     {
         return designationRepository.GetAll();
     }
     public Designation GetById(int id) {
         return designationRepository.GetById(id);
     }
     public void SaveDesignation()
     {
         unitOfWork.Commit();
     }
     public void AddDesignation(Designation designation)
     {
         designationRepository.Add(designation);
         SaveDesignation();
     }
     public void UpdateDesignation(Designation designation)
     {
         designationRepository.Update(designation);
         SaveDesignation();
     }
    }
 interface IDesignationService
 {
     void AddDesignation(Core.Entites.Models.Designation designation);
     System.Collections.Generic.IEnumerable<Core.Entites.Models.Designation> GetAllDesignation();
     Core.Entites.Models.Designation GetById(int id);
     void SaveDesignation();
     void UpdateDesignation(Core.Entites.Models.Designation designation);
 }
}
