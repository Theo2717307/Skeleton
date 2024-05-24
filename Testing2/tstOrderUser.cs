using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstOrderUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsOrderUser demo_user = new clsOrderUser();
            //test to see it exists
            Assert.IsNotNull(demo_user);
        }
        [TestMethod]
        public void UserIDPropertyOK()
        {
            //create an instance of the class
            clsOrderUser demo_user = new clsOrderUser();
            //create some test data to assign to the property
            Int32 test_data = 1;
            demo_user.UserID = test_data;
            //test to see the values are the same
            Assert.AreEqual(demo_user.UserID, test_data);
        }
        [TestMethod]
        public void UsernamePropertyOK()
        {
            //create an instance of the class
            clsOrderUser demo_user = new clsOrderUser();
            //create some test data to assign to the property
            String test_data = "demo_user";
            demo_user.Username = test_data;
            //test to see the values are the same
            Assert.AreEqual(demo_user.Username, test_data);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class
            clsOrderUser demo_user = new clsOrderUser();
            //create some test data to assign to the property
            String test_data = "demo";
            demo_user.Password = test_data;
            //test to see the values are the same
            Assert.AreEqual(demo_user.Password, test_data);
        }
        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class
            clsOrderUser demo_user = new clsOrderUser();
            //create some test data to assign to the property
            String test_data = "demo";
            demo_user.Department = test_data;
            //test to see the values are the same
            Assert.AreEqual(demo_user.Department, test_data);
        }
        [TestMethod]
        public void FindUserMethodOK()
        {
            //create an instance of the class
            clsOrderUser demo_user = new clsOrderUser();
            //create a boolean var to store the result of validation
            Boolean found = false;
            //create some test data to assign to the property
            String test_username = "Demo_order";
            String test_password = "demo";
            demo_user.Username = test_username;
            demo_user.Password = test_password;
            //invoke method
            found = demo_user.FindUser(test_username, test_password);
            //test to see found is true
            Assert.IsTrue(found);
        }
        [TestMethod]
        public void TestUserNamePWFound()
        {
            //create an instance of the class
            clsOrderUser demo_user = new clsOrderUser();
            //create a boolean var to store the result of validation
            Boolean found = false;
            //create a boolean vaar to store if the data is ok
            Boolean OK = true;
            //create some test data to assign to the property
            String test_username = "Demo_order";
            String test_password = "demo";
            //invoke method
            found = demo_user.FindUser(test_username, test_password);
            if (demo_user.Username != test_username || demo_user.Password != test_password)
            {
                OK = false;
            }
            //test to see found is true
            Assert.IsTrue(OK);
        }


    }
}
