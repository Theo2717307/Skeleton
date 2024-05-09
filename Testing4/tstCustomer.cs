using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class TstCustomer

    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer anCustomer = new clsCustomer();
            Assert.IsNotNull(anCustomer);
        }

        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            clsCustomer anCustomer = new clsCustomer();
            Int32 TestData = 1;
            anCustomer.CustomerId = TestData;
            Assert.AreEqual(anCustomer.CustomerId, TestData);
        }

        [TestMethod]
        public void CustomerFirstNamePropertyOK()
        {
            clsCustomer anCustomer = new clsCustomer();
            String TestData = "Sahil";
            anCustomer.CustomerFirstName = TestData;
            Assert.AreEqual(anCustomer.CustomerFirstName, TestData);
        }

        [TestMethod]
        public void CustomerLastNamePropertyOK()
        {
            clsCustomer anCustomer = new clsCustomer();
            String TestData = "Suresh";
            anCustomer.CustomerLastName = TestData;
            Assert.AreEqual(anCustomer.CustomerLastName, TestData);
        }

        [TestMethod]
        public void CusomterPhoneNumberPropertyOK()
        {
            clsCustomer anCustomer = new clsCustomer();
            String TestData = "+447979481200";
            anCustomer.CustomerPhoneNumber = TestData;
            Assert.AreEqual(anCustomer.CustomerPhoneNumber, TestData);
        }


        [TestMethod]
        public void CusomterEmailPropertyOK()
        {
            clsCustomer anCustomer = new clsCustomer();
            String TestData = "sahilsurseh199@gmail.com";
            anCustomer.CustomerEmail = TestData;
            Assert.AreEqual(anCustomer.CustomerEmail, TestData);
        }


        [TestMethod]
        public void CusomterAddressPropertyOK()
        {
            clsCustomer anCustomer = new clsCustomer();
            String TestData = "Some Street";
            anCustomer.CustomerAddress = TestData;
            Assert.AreEqual(anCustomer.CustomerAddress, TestData);
        }

        
        [TestMethod]
        public void CusomterPasswordPropertyOK()
        {
            clsCustomer anCustomer = new clsCustomer();
            String TestData = "+$sahilsursh";
            anCustomer.CustomerPassword = TestData;
            Assert.AreEqual(anCustomer.CustomerPassword, TestData);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            clsCustomer anCustomer = new clsCustomer();
            Boolean TestData = true;
            anCustomer.Active = TestData;
            Assert.AreEqual(anCustomer.Active, TestData);
        }







    }

}
