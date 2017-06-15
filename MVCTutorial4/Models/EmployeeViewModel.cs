using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCTutorial4.Models
{
    public class EmployeeViewModel
    {

        [Required(ErrorMessage = "Enter the Id")]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage ="Enter the Name")]
        public string Emri { get; set; }

        [Required(ErrorMessage = "Select the Department")]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "Enter the address")]
        public string Address { get; set; }

        public string DepartmentName { get; set; }
        public Boolean Remember { get; set; }

        public virtual Department Department { get; set; }
    }
}