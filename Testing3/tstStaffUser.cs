﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStaffUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the clas we want to creare
            clsStaffUser AnUser = new clsStaffUser();
            //test to see that it exists
            Assert.IsNotNull(AnUser);
        }

        [TestMethod]
        public void UserIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffUser AnUser = new clsStaffUser();
            //create some test data to assgn to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnUser.UserId = TestData;
            //test to see thar the two values are the same
            Assert.AreEqual(AnUser.UserId, TestData);

        }
        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffUser AnUser = new clsStaffUser();
            //create some test data to assign to the property
            string TestData = "Admin_Staff";
            //assign the data to the property
            AnUser.UserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserName, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffUser AnUser = new clsStaffUser();
            //create some test data to assign to the property
            string TestData = "Staff123";
            //assign the data to the property
            AnUser.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffUser AnUser = new clsStaffUser();
            //create some test data to assign to the property
            string TestData = "Staff";
            //assign the data to the property
            AnUser.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Department, TestData);
        }
        [TestMethod]
        public void FindUserMethodOK()
        {
            //create an instance of class
            clsStaffUser AnUser = new clsStaffUser();
            //create a boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the methods
            string UserName = "Admin_Staff";
            string Password = "Staff123";
            //invoke the method
            Found = AnUser.FindUser(UserName, Password);
            Assert.IsTrue(Found);

        }

        [TestMethod]

        public void TestUserNamePWFound()
        {
            //create an instance of the class 
            clsStaffUser anUser = new clsStaffUser();
            //Create vriable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is Ok
            Boolean OK = true;
            //create some test data to use with the methods
            string UserName = "Admin_Staff";
            string Password = "Staff123";
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
