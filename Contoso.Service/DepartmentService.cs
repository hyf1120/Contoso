using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model;
using Contoso.Data;

namespace Contoso.Service
{
    public class DepartmentService
    {
        DeptReporsitory repository;
        public DepartmentService ()
        {
            repository = new DeptReporsitory();
        }
        public List<Departments> GetAllDepartments()
        {
            var depts = repository.GetAll();
            return depts;

        }
        public void SaveDepartment(Departments dept)
        {
            repository.Create(dept);
        }
        public void DeleteDeptById(int id)
        {
            repository.DeleteById(id);
        }
        public Departments GetById(int id)
        {
            return repository.GetById(id);
        }
        public void Update (Departments obj)
        {
            repository.Update(obj);
        }
    }
}
