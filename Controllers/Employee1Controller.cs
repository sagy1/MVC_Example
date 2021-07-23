using Microsoft.AspNetCore.Mvc;
using MVC_CRUD.DAL;
using MVC_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MVC_CRUD.Controllers
{
    public class Employee1Controller : Controller
    {
        Employee1Repository EmpRpo;


        public Employee1Controller(Employee1Context _dbcontext) 
        {
            EmpRpo = new Employee1Repository(_dbcontext);
        }
        public IActionResult Index()
        {
            var test = EmpRpo.GetEmployees().ToList();
            var lstEmployees1 = EmpRpo.GetEmployees().Select(e => new Employee1ViewModel
            {
                EmpId = e.EmpId,
                EmpName = e.EmpName,
                Age = e.Age,
                EmailId = e.EmailId
            }).ToList();


            return View(lstEmployees1);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Employee1ViewModel emp = new Employee1ViewModel();
            return View(emp);

        }

        [HttpPost]
        public IActionResult Create(Employee1ViewModel emp)
        {
            if (ModelState.IsValid) 
            {
                Employee1 empEntity = new Employee1()
                {
                    EmpId = emp.EmpId,
                    EmpName = emp.EmpName,
                    EmailId = emp.EmailId
                };
                EmpRpo.CreateEmployee(empEntity);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Employee1ViewModel selectemployee = EmpRpo.GetEmployees().Where(i => i.EmpId == id).Select(e => new Employee1ViewModel
            {
                EmpId = e.EmpId,
                EmpName = e.EmpName,
                Age = e.Age,
                EmailId = e.EmailId
            }).FirstOrDefault();
            return View(selectemployee);

        }

        [HttpPost]
        public IActionResult Edit(Employee1ViewModel emp)
        {
            if (ModelState.IsValid)
            {
                Employee1 empEntity = new Employee1()
                {
                    EmpId = emp.EmpId,
                    EmpName = emp.EmpName,
                    Age=emp.Age,
                    EmailId = emp.EmailId
                };
                EmpRpo.EditEmployee(empEntity);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            Employee1ViewModel selectemployee = EmpRpo.GetEmployees().Where(i => i.EmpId == id).Select(e => new Employee1ViewModel
            {
                EmpId = e.EmpId,
                EmpName = e.EmpName,
                Age = e.Age,
                EmailId = e.EmailId
            }).FirstOrDefault();
            return View(selectemployee);

        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            Employee1ViewModel selectemployee = EmpRpo.GetEmployees().Where(i => i.EmpId == id).Select(e => new Employee1ViewModel
            {
                EmpId = e.EmpId,
                EmpName = e.EmpName,
                Age = e.Age,
                EmailId = e.EmailId
            }).FirstOrDefault();
            return View(selectemployee);

        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {

            EmpRpo.DeleteEmployee(id);

            return RedirectToAction("Index");
        }





    }
}
