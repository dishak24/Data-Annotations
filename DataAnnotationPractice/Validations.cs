using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotationPractice
{
    internal class Validations
    {
        public static void ValidateStudentInformation()
        {
            Console.WriteLine("Enter Students Data for validation: ");
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Percentage: ");
            double percentage = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            var student = new Student()
                        {
                            Name = name,
                            Age = age,
                            Percentage = percentage
                        };

            var context = new ValidationContext(student);
            var results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(student, context, results, true);

            if (isValid)
            {
                Console.WriteLine("Students information is Valid ! ");
            }
            else
            {
                Console.WriteLine("Errors: ");
                Console.WriteLine();
                foreach( var err in results)
                {
                    Console.WriteLine($"{err.ErrorMessage}");
                    
                }
            }
            Console.WriteLine();
        }

        public static void ValidateEmployeeInformation()
        {
            Console.WriteLine("Enter Employee's Data for validation: ");
            Console.WriteLine("ID: ");
            int empId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Name: ");
            String empName = Console.ReadLine();

            Console.WriteLine("Email: ");
            string empEmail = Console.ReadLine();
            Console.WriteLine();

            var employee = new Employee()
            {
                ID= empId,
                Name = empName,
                Email = empEmail

            };

            var context = new ValidationContext(employee);
            var result = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(employee,context, result, true);

            if (isValid)
            {
                Console.WriteLine("Employee's information is Valid ! ");
            }
            else
            {
                Console.WriteLine("Errors: ");
                Console.WriteLine();
                foreach (var err in result)
                {
                    Console.WriteLine($"{err.ErrorMessage}");

                }
            }
        }

        public static void ValidateUserLogin()
        {
            Console.WriteLine("Enter User Data for validation: ");
            Console.WriteLine("User Name: ");
            string uName = Console.ReadLine();

            Console.WriteLine("Password: ");
            String pass = Console.ReadLine();

  

            var user = new UserLogin()
            {
                UserName = uName,
                Password = pass

            };

            var context = new ValidationContext(user);
            var result = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(user, context, result, true);

            if (isValid)
            {
                Console.WriteLine("User Login successfull ! ");
            }
            else
            {
                Console.WriteLine("Errors: ");
                Console.WriteLine();
                foreach (var err in result)
                {
                    Console.WriteLine($"{err.ErrorMessage}");

                }
            }
        }
    }
}
