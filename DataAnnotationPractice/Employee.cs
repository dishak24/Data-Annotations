using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotationPractice
{
    internal class Employee
    {
        [Required(ErrorMessage = "ID is required!")]
        [Range(100, int.MaxValue, ErrorMessage = "Length of ID must be starts from 100 !")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Name is required!")]
        [StringLength(20,MinimumLength =2, ErrorMessage = "Please enter atleast 2 letters initial of name !")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required!")]
        [EmailAddress( ErrorMessage = "Invalid email format !")]
        public string Email { get; set; }



         


    }
}
