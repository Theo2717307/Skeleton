using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class Prop1Test
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AnAddress = new clsStaff();
            //test to see that it exits
            Assert.IsNotNull(AnAddress);
            //this
        }

        [TestMethod]
        public void IsManagerPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnAddress = new clsStaff();
            //create some test test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnAddress.IsManager = TestData;
            //test to see that the two values are the dame
            Assert.AreEqual(AnAddress.IsManager, TestData);
        }
        [TestMethod]
        public void StartDatePropertyOK()
        {
            //create and instance of the class we want to create
            clsStaff AnAddress = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnAddress.StartDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.StartDate, TestData);


        }
        [TestMethod]
        public void Staff_IdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnAddress = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnAddress.Staff_ID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.Staff_ID, TestData);
        }
        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnAddress = new clsStaff();
            //create some test data to assign to the property
            string TestData = "John";
            //assign the data to the property
            AnAddress.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.FirstName, TestData);
        }
        [TestMethod]
        public void LastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnAddress = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Wick";
            //assign the data to the property
            AnAddress.LastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.LastName, TestData);



        }
        [TestMethod]
        public void PositionPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnAddress = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Sales Assistant";
            //assign the data to the property
            AnAddress.Position = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.Position, TestData);


        }
        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnAddress = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Sales";
            //assign the data to the property
            AnAddress.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.Department, TestData);
        }

    }
}
