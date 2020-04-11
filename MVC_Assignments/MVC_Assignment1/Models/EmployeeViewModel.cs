using MVC_Assignment1.Models.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Assignment1.Models
{
    public class EmployeeViewModel
    {

        public int ID { get; set; }
        [Required(ErrorMessage = "Please fill in the required field")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please fill in the required field")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please fill in the required field")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Please fill in the required field")]
        [Range(1000, 50000000, ErrorMessage = "Salary Must be between 1000 to 50000000")]
        public float Salary { get; set; }
    }
}