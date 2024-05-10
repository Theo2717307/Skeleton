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

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomer anCustomer = new clsCustomer();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the methods
            Int32 CustomerId = 22;
            //invoke the methods
            Found = anCustomer.Find(CustomerId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]   
        public void TestCustomerIdFound()
        {
            //create an instanec of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (Assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 customerId = 20;
            //invoke the methods 
            Found = anCustomer.Find(customerId);
            //check the customer Id
            if(anCustomer.CustomerId != 20)
            {
                OK = false;
            }
            //Test to see that the restul is correct
            Assert.IsTrue(OK); 
        }

        [TestMethod]
        public void TestCustomerFirstNameFound()
        {
            //create an instanec of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (Assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 customerId = 20;
            //invoke the methods 
            Found = anCustomer.Find(customerId);
            //check the customer firstname property
            if (anCustomer.CustomerFirstName != "Sahil") ;
            {
                OK = false;
            }
            //Test to see that the restul is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerLastNameFound()
        {
            //create an instanec of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (Assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 customerId = 20;
            //invoke the methods 
            Found = anCustomer.Find(customerId);
            //check the customer Lastname property
            if (anCustomer.CustomerLastName != "Suresh") ;
            {
                OK = false;
            }
            //Test to see that the restul is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerPhoneNumberFound()
        {
            //create an instanec of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (Assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 customerId = 20;
            //invoke the methods 
            Found = anCustomer.Find(customerId);
            //check the customer phone number property
            if (anCustomer.CustomerPhoneNumber != "+447373485923") ;
            {
                OK = false;
            }
            //Test to see that the restul is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerEmailFound()
        {
            //create an instanec of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (Assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 customerId = 20;
            //invoke the methods 
            Found = anCustomer.Find(customerId);
            //check the customer email property
            if (anCustomer.CustomerEmail != "test@gmail.com") ;
            {
                OK = false;
            }
            //Test to see that the restul is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerPasswordFound()
        {
            //create an instanec of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (Assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 customerId = 20;
            //invoke the methods 
            Found = anCustomer.Find(customerId);
            //check the customer Password property
            if (anCustomer.CustomerPassword != "testPassWord234") ;
            {
                OK = false;
            }
            //Test to see that the restul is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerAddressFound()
        {
            //create an instanec of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (Assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 customerId = 20;
            //invoke the methods 
            Found = anCustomer.Find(customerId);
            //check the customer address property
            if (anCustomer.CustomerAddress != "some street name, LE4 6JP") ;
            {
                OK = false;
            }
            //Test to see that the restul is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instanec of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (Assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 customerId = 20;
            //invoke the methods 
            Found = anCustomer.Find(customerId);
            //check the customer address property
            if (anCustomer.Active != true) ;
            {
                OK = false;
            }
            //Test to see that the restul is correct
            Assert.IsTrue(OK);
        }










    }

}
