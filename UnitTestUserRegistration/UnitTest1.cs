using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationWithMSTest;

namespace UnitTestUserRegistration
{
    [TestClass]
    public class UnitTest1
    {
        public static bool actual = true;
        [TestCategory("Names")]
        [TestMethod]
        public void TestingInputForFirstName()
        {
            //Arrange
            Validation userDataValidation = new Validation();
            //Act
            try
            {
                string expected = userDataValidation.isValidName("akash");
            }
            catch (UserRegistrationCustomException exception)
            {
                //Assert
                Assert.AreEqual("Invalid Entry", exception.Message);
            }
        }
        
        // To test the Last name
        
        [TestCategory("Names")]
        [TestMethod]
        public void TestingInputForLastName()
        {
            //Arrange
           Validation userDataValidation = new Validation();
            try
            {
                string expected = userDataValidation.isValidName("singh");
            }
            catch (UserRegistrationCustomException exception)
            {
                //Assert
                Assert.AreEqual("Invalid Entry", exception.Message);
            }
        }
        
        // To test the mobile number matching case
       
        [TestCategory("Mobile Number")]
        [TestMethod]
        public void TestingInputForMobileNumber()
        {
            //Arrange
           Validation userDataValidation = new Validation();
            try
            {
                string expected = userDataValidation.isValidMobileNumber("8855779966");
            }
            catch (UserRegistrationCustomException exception)
            {
                //Assert
                Assert.AreEqual("Invalid Entry", exception.Message);
            }
        }
   
        // To test the e-mail matching case
        
        [TestCategory("E-Mail")]
        [TestMethod]
        public void TestingInputForEmailId()
        {
            //Arrange
            Validation userDataValidation = new Validation();
            try
            {
                string expected = userDataValidation.isValidEmailID("aaa.reerr@gmail.com");
            }
            catch (UserRegistrationCustomException exception)
            {
                //Assert
                Assert.AreEqual("Invalid Entry", exception.Message);
            }
        }
        
        // Test Case For Multiple Email Entries
        
        [DataRow("akashsingh@gmail.co.in")]
        [DataRow("akash-singh@gmail.co.in")]
        [DataRow("akashsingh@gmail.co.us")]
        [TestCategory("Validate Multiple E-Mail")]
        [TestMethod]
        public void TestingInputForMultipleEmailId(string emailId)
        {
            //Arrange
            Validation userDataValidation = new Validation();
            try
            {
                string expected = userDataValidation.isValidEmailID(emailId);
                Assert.AreEqual("Correct Entry", expected);
            }
            catch (UserRegistrationCustomException exception)
            {
                //Assert
                Assert.AreEqual("Invalid Entry", exception.Message);
            }
        }
      
        // To test the password matching case
   
        [TestCategory("Password")]
        [TestMethod]
        public void TestingInputForPassword()
        {
            //Arrange
            Validation userDataValidation = new Validation();
            try
            {
                string expected = userDataValidation.isValidPassword("akash243@ddd");
            }
            catch (UserRegistrationCustomException exception)
            {
                //Assert
                Assert.AreEqual("Invalid Entry", exception.Message);
            }
        }      
    }
}
