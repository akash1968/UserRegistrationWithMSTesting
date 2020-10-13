using System;

namespace UserRegistrationWithMSTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Validation val = new Validation();
            Console.WriteLine("Enter the first name of the user");
            String firstName = Console.ReadLine();
            while (!val.FirstNameValidation(firstName))
            {
                Console.WriteLine("Enter a valid First Name with first letter as Capital");
                firstName = Console.ReadLine();
            }
            Console.WriteLine("Enter the last name of the user:");
            String lastName = Console.ReadLine();
            while (!val.LastNameValidation(lastName))
            {
                Console.WriteLine("Enter a valid Last Name with first letter as Capital and minimum 3 character");
                lastName = Console.ReadLine();
            }
            Console.WriteLine("Enter a valid Email Id: ");
            String email = Console.ReadLine();
            while (!val.EmailidValidation(email))
            {
                Console.WriteLine("Email Id is not valid. Enter Again: ");
                email = Console.ReadLine();
            }


        }
    }
}
