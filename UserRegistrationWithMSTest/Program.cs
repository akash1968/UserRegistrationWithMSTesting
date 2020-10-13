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


        }
    }
}
