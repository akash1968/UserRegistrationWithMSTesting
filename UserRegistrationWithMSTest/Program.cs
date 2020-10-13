using System;

namespace UserRegistrationWithMSTest
{
    public class Program
    {
       
        static void Main(string[] args)
        {
            Validation val = new Validation();
            string firstname, lastname, email, MobileNo;
            while (true)
            {
                Console.WriteLine("Enter your First Name : ");
                firstname = Console.ReadLine();
                try
                {
                    if (!val.FirstNameValidation(firstname))
                    {
                        throw new CustomException("Invalid first name");
                    }
                    break;
                }
                catch (CustomException ce)
                {
                    Console.WriteLine(ce.Message);
                }

            }

            while (true)
            {
                Console.WriteLine("Enter your Last Name : ");
                lastname = Console.ReadLine();
                try
                {
                    if (!val.LastNameValidation(lastname))
                    {
                        throw new CustomException("Invalid last name");
                    }
                    break;
                }
                catch (CustomException ce)
                {
                    Console.WriteLine(ce.Message);
                }

            }

            while (true)
            {
                Console.WriteLine("Enter your emailId : ");
                email = Console.ReadLine();
                try
                {
                    if (!val.EmailidValidation(email))
                    {
                        throw new CustomException("Invalid emailId");
                    }
                    break;
                }
                catch (CustomException ce)
                {
                    Console.WriteLine(ce.Message);
                }
            }

            while (true)
            {
                Console.WriteLine("Enter your mobile number : ");
                MobileNo = Console.ReadLine();
                try
                {
                    if (!val.MobileNumberValidation(MobileNo))
                    {
                        throw new CustomException("Invalid mobile number");
                    }
                    break;
                }

                catch (CustomException ce)
                {
                    Console.WriteLine(ce.Message);
                }
            }

            while (true)
            {
                Console.WriteLine("Enter a password : ");
                string password = Console.ReadLine();
                try
                {
                    if (!val.PasswordValidationRule4(password))
                    {
                        throw new CustomException("Invalid password");
                    }
                    break;
                }
                catch (CustomException ce)
                {
                    Console.WriteLine(ce.Message);
                }
            }

            //UC1 First Name Validation
            /* Console.WriteLine("Enter the first name of the user");
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

             // UC5 Password Rule1 Validation
             Console.WriteLine("Enter a password: ");
             String password1 = Console.ReadLine();
             while (!val.PasswordValidationRule1(password1))
             {
                 Console.WriteLine("Enter a password with minimum 8 characters ");
                 password1 = Console.ReadLine();
             }
             // UC6 Password Rule2 Validation
             Console.WriteLine("Enter a password: ");
             String password2 = Console.ReadLine();
             while (!val.PasswordValidationRule2(password2))
             {
                 Console.WriteLine("Enter a password with minimum 8 characters and Alteast One Upper Case ");
                 password2 = Console.ReadLine();
             }
             // UC7 Password Rule3 Validation
             Console.WriteLine("Enter a password: ");
             String password3 = Console.ReadLine();
             while (!val.PasswordValidationRule3(password3))
             {
                 Console.WriteLine("Enter a password with minimum 8 characters and Alteast One Upper Case and alteast One Number ");
                 password3 = Console.ReadLine();
             }
             // UC8 Password Rule4 Validation
             Console.WriteLine("Enter a password: ");
             String password4 = Console.ReadLine();
             while (!val.PasswordValidationRule4(password4))
             {
                 Console.WriteLine("Enter a password with minimum 8 characters and Alteast One Upper Case and alteast One Number and Atleast One Special Character ");
                 password4 = Console.ReadLine();
             }

            //UC9 All Email Samples


             Console.WriteLine("Registration Successful.");
             Console.WriteLine("Name of the User :" + firstName + " " + lastName);
             Console.WriteLine("Email ID of User : " + email);
             Console.WriteLine("Mobile Number of User: " + mobileNo);
           */
        }
    }
}
