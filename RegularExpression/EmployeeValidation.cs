using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExpression
{
    internal class EmployeeValidation
    {
        public static void ValidateData()
        {
            Employee employee = new Employee();

            Console.WriteLine("Enter the data for Employee Validations");
            Console.WriteLine();

            Console.WriteLine("Enter Id: ");
            employee.ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter First Name: ");
            employee.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name: ");
            employee.LastName = Console.ReadLine();

            Console.WriteLine("Enter Email-Id: ");
            employee.Email = Console.ReadLine();

            Console.WriteLine("Enter Mobile Number: ");
            employee.Contact = Console.ReadLine();

            Console.WriteLine("Enter Birth Date (yyyy-mm-dd): ");
            employee.BirthDate = Console.ReadLine();

            Console.WriteLine("Enter Gender ( Male / Female): ");
            employee.Gender = Console.ReadLine();

            Console.WriteLine();

            var context = new ValidationContext(employee);
            var result = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(employee, context, result, true);

            if ( isValid )
            {
                Console.WriteLine("All data is Valid.");
            }
            else
            {
                foreach( var err in result )
                {
                    Console.WriteLine(err.ErrorMessage);
                }
            }

        }
    }
}
