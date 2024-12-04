using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorPagesEx.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Add Employee Name")]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters"), MinLength(3, ErrorMessage = "Name cannot be less than 3 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Add Employee Email")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }
        public string? ImageUrl { get; set; }

        [Required(ErrorMessage = "Please Add Employee Department")]
        public Dept? Department { get; set; }
    }
}
