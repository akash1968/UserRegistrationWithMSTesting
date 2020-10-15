using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationWithMSTest
{
    public class Validation
    {
        
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
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.WRONG_EMAIL, "Invalid Entry");
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
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.WRONG_FIRSTNAME, "Invalid Entry");
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
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.WRONG_PASSWORD, "Invalid Entry");
            }
        }
    }
}
