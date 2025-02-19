using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotationPractice
{
    internal class UserLogin
    {
        [Required(ErrorMessage = "User Name is required!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "UserName must be atleast 3 letters !")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        [StringLength(6,MinimumLength = 6, ErrorMessage = "Please enter 6 digit password !")]
        //[PasswordPropertyText]
        public string Password { get; set; }

        /*[Required(ErrorMessage = "Confirm Password is required!")]
        [PasswordPropertyText]
        //[Compare(UserLogin.UserName, ErrorMessage = "The fields Password and PasswordConfirmation should be equals")]
        public string ConfirmPassword { get; set; } */
    }
}
