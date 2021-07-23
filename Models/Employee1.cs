using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVC_CRUD.Models
{
    public class Employee1
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int Age { get; set; }
        public string EmailId { get; set; }



    }
}
