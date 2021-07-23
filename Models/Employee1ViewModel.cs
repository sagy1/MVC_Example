using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVC_CRUD.Models
{
    public class Employee1ViewModel
    {

        [Key]

        [Required(ErrorMessage ="Enter Emp ID ")]
        public int EmpId { get; set; }

        [Required(ErrorMessage = "Enter Emp Name ")]
        public string EmpName { get; set; }
        public int Age { get; set; }

        [DataType(DataType.EmailAddress)]
        public string EmailId { get; set; }


    }
}
