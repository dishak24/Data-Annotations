using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExpression
{
    internal class Employee
    {
        [Required(ErrorMessage = "ID is required.")]
        [RegularExpression(@"^[0-9]{100,}$", ErrorMessage = "ID must start from 100.")]
        public int ID { get; set; }



        [Required(ErrorMessage = "First Name is required.")]
        [RegularExpression(@"^[A-Z]{1}[a-z]{2,}$", 
                            ErrorMessage = "First Name must start with a capital letter and be atleast 3 characters long.")]
        public string FirstName { get; set; }



        [Required(ErrorMessage = "Last Name is required.")]
        [RegularExpression(@"^[A-Z]{1}[a-z]{2,}$", 
                            ErrorMessage = "Last Name must start with a capital letter and be atleast 3 characters long.")]
        public string LastName { get; set; }



        [Required(ErrorMessage = "Email is required.")]
        [RegularExpression(@"^[a-zA-Z0-9]+([._-][0-9a-zA-Z]+)*@[a-zA-Z0-9]+([.-][0-9a-zA-Z]+)*\.[a-zA-Z]{2,}$", 
                            ErrorMessage = "Email must be in proper format.")]
        public string Email { get; set; }



        [Required(ErrorMessage = "Contact is required.")]
        [RegularExpression(@"(^[0-9]{10}$) || (^\+[0-9]{2} \s+ [0-9]{ 10}$) || (^\+[0-9]{2}[0-9]{ 10}$)",
                            ErrorMessage ="Mobile number must be in correct way.")]
        public string Contact { get; set; }



        [Required(ErrorMessage = "Gender is required.")]
        [RegularExpression(@"^(Male)||(Female)$", ErrorMessage ="Gender must be Male or Female")]
        public string Gender { get; set; }




        [Required(ErrorMessage = "Birth date is required.")]
        [DataType(DataType.Date, ErrorMessage ="Invalide Date format.")]
        [Range(typeof(DateTime), "2001-01-01","2025-01-01", ErrorMessage = "Birthdate must be between 2001 - 2025.")]
        public string BirthDate { get; set; }

    }
}
