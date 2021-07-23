using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_CRUD.Models;

namespace MVC_CRUD.DAL
{
    public class Employee1Context:DbContext
    {
        public Employee1Context(DbContextOptions<Employee1Context> options) : base(options)
        { 
                
        }

        public DbSet<Employee1> Employees1 { get; set; }

        public DbSet<MVC_CRUD.Models.Employee1ViewModel> Employee1ViewModel { get; set; }
    }
}
