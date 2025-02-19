using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotationPractice
{
    internal class Student
    {
        [Required(ErrorMessage =" Name is Required !")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Please enter atleast 2 letters initial of name !")]
        public string Name { get; set; }

        [Required(ErrorMessage = " Age is Required !")]
        [Range(15, 28, ErrorMessage = "Please enter age between 15 - 28!")]
        public int Age { get; set; }

        [Required(ErrorMessage = " Percentage is Required !")]
        [Range(35, 100, ErrorMessage = "Please enter valid percentage!")]
        public double Percentage { get; set; }
    }
}
