using System;

namespace UserRegistrationWithMSTest
{
    public class Program
    {
        public static string firstName;
        public static string lastName;
        public static string emailId;
        public static string mobileNumber;
        public static string password;
        static void Main(string[] args)
        {
           Validation val = new Validation();
            Console.WriteLine("Enter User First Name=");
            firstName = Console.ReadLine();

            var validationKey = "";
            validationKey = val.isValidName(firstName);
            Console.WriteLine(validationKey);

            Console.WriteLine("Enter User Last Name=");
            lastName = Console.ReadLine();

            validationKey = val.isValidName(lastName);
            Console.WriteLine(validationKey);

            Console.WriteLine("Enter User Email Id=");
            emailId = Console.ReadLine();

            validationKey = val.isValidEmailID(emailId);
            Console.WriteLine(validationKey);


            Console.WriteLine("Enter User Mobile Number=");
            mobileNumber = Console.ReadLine();

            validationKey = val.isValidMobileNumber(mobileNumber);
            Console.WriteLine(validationKey);

            Console.WriteLine("Enter User Password=");
            password = Console.ReadLine();

            validationKey = val.isValidPassword(password);
            Console.WriteLine(validationKey);
        }
    }
}
