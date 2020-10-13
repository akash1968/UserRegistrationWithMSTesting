using System;

namespace UserRegistrationWithMSTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Validation val = new Validation();
           
            //UC1 First Name Validation
            Console.WriteLine("Enter the first name of the user");
            String firstName = Console.ReadLine();
            while (!val.FirstNameValidation(firstName))
            {
                Console.WriteLine("Enter a valid First Name with first letter as Capital");
                firstName = Console.ReadLine();
            }
           
            //UC2 Last Name Validation
            Console.WriteLine("Enter the last name of the user:");
            String lastName = Console.ReadLine();
            while (!val.LastNameValidation(lastName))
            {
                Console.WriteLine("Enter a valid Last Name with first letter as Capital and minimum 3 character");
                lastName = Console.ReadLine();
            }

            //UC3 Email Id Validation
            Console.WriteLine("Enter a valid Email Id: ");
            String email = Console.ReadLine();
            while (!val.EmailidValidation(email))
            {
                Console.WriteLine("Email Id is not valid. Enter Again: ");
                email = Console.ReadLine();
            }

            //UC4 Mobile Number Validation
            Console.WriteLine("Enter the Mobile Number of the User: ");
            String mobileNo = Console.ReadLine();
            while (!val.MobileNumberValidation(mobileNo))
            {
                Console.WriteLine("Enter a 10 digit mobile number preceeded with country code: ");
                mobileNo = Console.ReadLine();
            }

            // UC5 Password Rule 1 Validation
            Console.WriteLine("Enter a password: ");
            String password1 = Console.ReadLine();
            while (!val.PasswordValidation(password1))
            {
                Console.WriteLine("Enter a password with minimum 8 characters ");
                password1 = Console.ReadLine();
            }


        }
    }
}
