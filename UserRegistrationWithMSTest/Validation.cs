using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationWithMSTest
{
    public class Validation
    {
        public Boolean FirstNameValidation(string firstName)
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

    }
}
