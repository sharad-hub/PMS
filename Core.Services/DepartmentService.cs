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
    public class DepartmentService : IDepartmentService
    {
        IDepartmentRepository departmentRepository;
        IUnitOfWork unitOfWork;
        public DepartmentService(IDepartmentRepository departmentRepository, IUnitOfWork unitOfWork)
        {
            this.departmentRepository = departmentRepository;
            this.unitOfWork = unitOfWork;
        }
        public Department GetDepartment(int id)
        {
            return departmentRepository.GetById(id);
        }
        public IEnumerable<Department> GetDepartment(string name)
        {
            return departmentRepository.GetMany(x => x.Name.Contains(name));
        }
        public IEnumerable<Department> GetAllDepartments()
        {
            return departmentRepository.GetAll();
        }
    }
    public interface IDepartmentService
    {
        Department GetDepartment(int id);
        IEnumerable<Department> GetDepartment(string name);
        IEnumerable<Department> GetAllDepartments();
    }
}
