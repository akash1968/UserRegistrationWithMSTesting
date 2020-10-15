using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationWithMSTest
{
    public class Validation
    {
        /* public Boolean FirstNameValidation(string firstName)
         {
             Regex regularExpression = new Regex("^[A-Z][a-z]{2,}$");
             if (regularExpression.IsMatch(firstName))
                 return true;
             else
                 return false;
         }
         public Boolean LastNameValidation(string lastName)
         {

             Regex regularExpression = new Regex("^[A-Z][a-z]{2,}$");
             if (regularExpression.IsMatch(lastName))
                 return true;
             else
                 return false;
         }
         public Boolean EmailidValidation(string email)
         {
             Regex regularExpression = new Regex("^[0-9A-Za-z]+([+-_.][a-zA-Z]+)*[@][0-9A-Za-z]+[.][0-9A-Za-z]{2,3}$");
             if (regularExpression.IsMatch(email))
                 return true;
             else
                 return false;
         }
         public Boolean MobileNumberValidation(string mobileNo)
         {
             Regex regularExpression = new Regex("^[0-9]{2,3}\\s[1-9]{10}$");
             if (regularExpression.IsMatch(mobileNo))
                 return true;
             else
                 return false;
         }
         public Boolean PasswordValidationRule1(string password1)
         {
             Regex regularExpression = new Regex(@"(^[A-Za-z0-9]{8,}$)");    //UC6 Password Rule 1
             if (regularExpression.IsMatch(password1))
                 return true;
             else
                 return false;
         }
         public Boolean PasswordValidationRule2(string password2)
         {
             Regex regularExpression = new Regex(@"(^(?=.*[A-Z])[A-Za-z0-9@#-+]{8,}$)"); //UC6 Password Rule 2
             if (regularExpression.IsMatch(password2))
                 return true;
             else
                 return false;
         }
         public Boolean PasswordValidationRule3(string password3)
         {
             Regex regularExpression = new Regex(@"(^(?=.*[A-Z])(?=.*[0-9])[A-Za-z0-9@#-+]{8,}$)"); //UC7 Password Rule 3
             if (regularExpression.IsMatch(password3))
                 return true;
             else
                 return false;
         }
         public Boolean PasswordValidationRule4(string password4)
         {
             Regex regularExpression = new Regex(@"(^(?=.*[A-Z])(?=.*[0-9])(?=.*[@#+-\._])[A-Za-z0-9@#-+\._]{8,}$)"); //UC8 Password Rule 4
             if (regularExpression.IsMatch(password4))
                 return true;
             else
                 return false;
         }
         public static string Email_Regex = "^[a-zA-Z0-9]+([.+_-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]{2})?$";
         public bool ValidateEmailSet(string email)
         {
             return Regex.IsMatch(email, Email_Regex);
         }

         public string MoodAnalyser(string message)
         {
             if (message.Contains("HAPPY"))
                 return "HAPPY";
             else
                 return "SAD";
         }
        */
        public static string FIRSTNAME_REGX = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string LASTNAME_REGX = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string EMAIL_REGX = "[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";
        public static string MOBILENUMBER_REGX = "^[0-9]{2}[ ][0-9]{10}$";
        public static string PASSWORD = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[^0-9a-zA-Z])(?!.*[^0-9a-zA-Z].*[^0-9a-zA-Z]).{8,}$";

        public string isValidEmailID(string emailId)
        {
            try
            {
                if (Regex.IsMatch(emailId, EMAIL_REGX))
                    return "Correct Entry";
                else
                    throw new Exception();
            }
            catch
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.WRONG_MOBILENUMBER, "Invalid Entry");
            }
        }
        public string isValidName(string Name)
        {
            try
            {
                if (Regex.IsMatch(Name, FIRSTNAME_REGX))
                    return "Correct Entry";
                else
                    throw new Exception();
            }
            catch
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.WRONG_MOBILENUMBER, "Invalid Entry");
            }
        }
        public string isValidMobileNumber(string mobileNumber)
        {
            try
            {
                if (Regex.IsMatch(mobileNumber, MOBILENUMBER_REGX))
                    return "Correct Entry";
                else
                    throw new Exception();
            }
            catch
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.WRONG_MOBILENUMBER, "Invalid Entry");
            }

        }
        public string isValidPassword(string password)
        {
            try
            {
                if (Regex.IsMatch(password, PASSWORD))
                    return "Correct Entry";
                else
                    throw new Exception();
            }
            catch
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.WRONG_MOBILENUMBER, "Invalid Entry");
            }
        }
    }
}
