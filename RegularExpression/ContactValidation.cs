using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression
{
    internal class ContactValidation
    {        
        public static void ValidatePhoneNumber()
        {
            string pattern = @"(^[0-9]{10}$) || (^\+[0-9]{2} \s+ [0-9]{ 10}$) || (^\+[0-9]{2}[0-9]{ 10}$) ";
                                             
            Regex regex = new Regex(pattern);

            Console.WriteLine("Enter your mobile number: ");
            string phone = Console.ReadLine();
                        

            if (regex.IsMatch(phone))
            {
                Console.WriteLine("Yes, Your mobile number is valid." );
            }
            else
            {
                Console.WriteLine("Please, Enter valid mobile number !!!");

            }
        }
    }
}
