using MVC_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_CRUD.DAL
{

    
    public class Employee1Repository
    {
        private Employee1Context _dbcontext;
    public Employee1Repository(Employee1Context dbcontext)
        {
            _dbcontext = dbcontext;
     }

        public List<Employee1> GetEmployees() 
        {
            return _dbcontext.Employees1.ToList();
        }

        public void CreateEmployee(Employee1 employee1) 
        {
            _dbcontext.Employees1.Add(employee1);
            _dbcontext.SaveChanges();
        }

        public void EditEmployee(Employee1 employee1)
        {
            _dbcontext.Employees1.Update(employee1);
            _dbcontext.SaveChanges();
        }

        public void DeleteEmployee(int EmpId)
        {
            var selectedEmployee = _dbcontext.Employees1.Where(i => i.EmpId == EmpId).FirstOrDefault();

            if (selectedEmployee != null) 
            {
                _dbcontext.Employees1.Remove(selectedEmployee);
                _dbcontext.SaveChanges();

            }
        }



    }
}
