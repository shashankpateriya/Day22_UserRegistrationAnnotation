using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Day22_UserRegistrationAnnotation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to user registration!");

            UserRegistrationAnnotation obj = new UserRegistrationAnnotation();
            string FirstName, LastName, email, number, password;

            Console.Write("Enter First Name: ");
            FirstName = Console.ReadLine();
            obj.firstName=FirstName;

            Console.Write("Enter Last Name: ");
            LastName = Console.ReadLine();
            obj.lastName=LastName;

            Console.Write("Enter your email addresss: ");
            email = Console.ReadLine();
            obj.emailId=email;

            Console.Write("Enter your mobile number: ");
            number = Console.ReadLine();
            obj.phoneNum=number;

            Console.Write("Enter your password: ");
            password = Console.ReadLine();
            obj.password=password;

            ValidationContext context = new ValidationContext(obj, null, null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(obj, context, results, true);

            if (!valid)
            {
                foreach (ValidationResult TotalResult in results)
                {
                    Console.WriteLine("Error Msg : {0}{1}", TotalResult.ErrorMessage, Environment.NewLine);
                }
            }

            Console.ReadKey();

        }
    }
}