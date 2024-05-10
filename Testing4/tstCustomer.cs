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
        public void Customer_IdPropertyOK()
        {
            clsCustomer anCustomer = new clsCustomer();
            Int32 TestData = 1;
            anCustomer.Customer_Id = TestData;
            Assert.AreEqual(anCustomer.Customer_Id, TestData);
        }

        [TestMethod]
        public void Customer_FirstNamePropertyOK()
        {
            clsCustomer anCustomer = new clsCustomer();
            String TestData = "Sahil";
            anCustomer.Customer_FirstName = TestData;
            Assert.AreEqual(anCustomer.Customer_FirstName, TestData);
        }

        [TestMethod]
        public void Customer_LastNamePropertyOK()
        {
            clsCustomer anCustomer = new clsCustomer();
            String TestData = "Suresh";
            anCustomer.Customer_LastName = TestData;
            Assert.AreEqual(anCustomer.Customer_LastName, TestData);
        }

        [TestMethod]
        public void Cusomter_PhoneNumberPropertyOK()
        {
            clsCustomer anCustomer = new clsCustomer();
            String TestData = "+447979481200";
            anCustomer.Customer_PhoneNumber = TestData;
            Assert.AreEqual(anCustomer.Customer_PhoneNumber, TestData);
        }


        [TestMethod]
        public void Cusomter_EmailPropertyOK()
        {
            clsCustomer anCustomer = new clsCustomer();
            String TestData = "sahilsurseh199@gmail.com";
            anCustomer.Customer_Email = TestData;
            Assert.AreEqual(anCustomer.Customer_Email, TestData);
        }


        [TestMethod]
        public void Cusomter_AddressPropertyOK()
        {
            clsCustomer anCustomer = new clsCustomer();
            String TestData = "Some Street";
            anCustomer.Customer_Address = TestData;
            Assert.AreEqual(anCustomer.Customer_Address, TestData);
        }

        
        [TestMethod]
        public void Cusomter_PasswordPropertyOK()
        {
            clsCustomer anCustomer = new clsCustomer();
            String TestData = "+$sahilsursh";
            anCustomer.Customer_Password = TestData;
            Assert.AreEqual(anCustomer.Customer_Password, TestData);
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
            Int32 Customer_Id = 5;
            //invoke the methods
            Found = anCustomer.Find(Customer_Id);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]   
        public void TestCustomer_IdFound()
        {
            //create an instanec of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (Assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Customer_Id = 5;
            //invoke the methods 
            Found = anCustomer.Find(Customer_Id);
            //check the customer Id
            if(anCustomer.Customer_Id != 5)
            {
                OK = false;
            }
            //Test to see that the restul is correct
            Assert.IsTrue(OK); 
        }

        [TestMethod]
        public void TestCustomer_FirstNameFound()
        {
            //create an instanec of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (Assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Customer_Id = 5;
            //invoke the methods 
            Found = anCustomer.Find(Customer_Id);
            //check the customer firstname property
            if (anCustomer.Customer_FirstName != "Karkit")
            {
                OK = false;
            }
            //Test to see that the restul is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomer_LastNameFound()
        {
            //create an instanec of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (Assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Customer_Id = 5;
            //invoke the methods 
            Found = anCustomer.Find(Customer_Id);
            //check the customer Lastname property
            if (anCustomer.Customer_LastName != "Dinesh")
            {
                OK = false;
            }
            //Test to see that the restul is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomer_PhoneNumberFound()
        {
            //create an instanec of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (Assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Customer_Id = 5;
            //invoke the methods 
            Found = anCustomer.Find(Customer_Id);
            //check the customer phone number property
            if (anCustomer.Customer_PhoneNumber != "07263548563")
            {
                OK = false;
            }
            //Test to see that the restul is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomer_EmailFound()
        {
            //create an instanec of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (Assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Customer_Id = 5;
            //invoke the methods 
            Found = anCustomer.Find(Customer_Id);
            //check the customer email property
            if (anCustomer.Customer_Email != "Kartik@gmail.com")
            {
                OK = false;
            }
            //Test to see that the restul is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomer_PasswordFound()
        {
            //create an instanec of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (Assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Customer_Id = 5;
            //invoke the methods 
            Found = anCustomer.Find(Customer_Id);
            //check the customer Password property
            if (anCustomer.Customer_Password != "youarefix")
            {
                OK = false;
            }
            //Test to see that the restul is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomer_AddressFound()
        {
            //create an instanec of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (Assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Customer_Id = 5;
            //invoke the methods 
            Found = anCustomer.Find(Customer_Id);
            //check the customer address property
            if (anCustomer.Customer_Address != "Some street, LE6 7OP") 
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
            Int32 Customer_Id = 5;
            //invoke the methods 
            Found = anCustomer.Find(Customer_Id);
            //check the customer address property
            if (anCustomer.Active != true)
            {
                OK = false;
            }
            //Test to see that the restul is correct
            Assert.IsTrue(OK);
        }










    }

}
