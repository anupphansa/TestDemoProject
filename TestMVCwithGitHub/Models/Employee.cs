using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TestMVCwithGitHub.Models
{
    public class Employee
    {

        public int EmployeeId { get; set; }
        
        [Required]
        [Display(Name="First Name")]
        public string EmpFirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string EmpLastName { get; set; }
    }
}