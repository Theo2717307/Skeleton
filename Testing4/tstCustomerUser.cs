using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstCustomerUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class 
            clsCustomerUser anUser = new clsCustomerUser();
            //test to see that it exist
            Assert.IsNotNull(anUser);
        }

        [TestMethod]
        public void UserIdPropertyOK()
        {
            //create an instance of the class 
            clsCustomerUser anUser = new clsCustomerUser();
            //create some test data
            Int32 TestData = 1;
            //assign the data to the property
            anUser.UserId = TestData;
            //test to see that it exist
            Assert.AreEqual(anUser.UserId, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerUser AnUser = new clsCustomerUser();
            //create some test data to assign to the property
            string TestData = "Dawn";
            //assign the data to the property
            AnUser.UserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerUser AnUser = new clsCustomerUser();
            //create some test data to assign to the property
            string TestData = "password123";
            //assign the data to the property
            AnUser.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerUser AnUser = new clsCustomerUser();
            //create some test data to assign to the property
            string TestData = "Address Book";
            //assign the data to the property
            AnUser.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            //create an instance of class
            clsCustomerUser anUser = new clsCustomerUser();
            //create a boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the methods
            string UserName = "Dawn";
            string Password = "pass124";
            //invoke the method
            Found = anUser.FindUser(UserName, Password);
            Assert.IsTrue(Found);  

        }

        [TestMethod]

        public void TestUserNamePWFound()
        {
            //create an instance of the class 
            clsCustomerUser anUser = new clsCustomerUser();
            //Create vriable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is Ok
            Boolean OK = true;
            //create some test data to use with the methods
            string UserName = "Dawn";
            string Password = "pass124";
            //invoke the methods
            Found = anUser.FindUser(UserName, Password);
            //check the user Id property
            if (anUser.UserName != UserName && anUser.Password != Password) 
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

    }

}
