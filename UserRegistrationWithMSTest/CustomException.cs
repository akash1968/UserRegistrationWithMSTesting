using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.ExceptionServices;

namespace UserRegistrationWithMSTest
{
    class CustomException : ApplicationException
    {
        public CustomException(string message) : base(message)
        {

        }
    }
}
