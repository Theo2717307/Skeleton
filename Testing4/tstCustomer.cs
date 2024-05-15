using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class TstCustomer

    {
        //good test data
        //create some test data to pass the methods
        string Customer_FirstName = "Sahil";
        string Customer_LastName = "Suresh";
        string Customer_PhoneNumber = "+447456392837";
        string Customer_Email = "sahilsursh43@gmail.com";
        string Customer_Password = "039723865sa";
        string Customer_Address = "Some test street, LE5 6Jf";
        string Customer_PostCode = "LE6 9GG";
        string Registration = DateTime.Now.ToShortDateString();


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
        public void Cusomter_PostCodePropertyOK()
        {
            clsCustomer anCustomer = new clsCustomer();
            String TestData = "LE3 6JW";
            anCustomer.Customer_PostCode = TestData;
            Assert.AreEqual(anCustomer.Customer_PostCode, TestData);
        }

        [TestMethod]
        public void RegistrationPropertyOK()
        {
            clsCustomer anCustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            anCustomer.Registration = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(anCustomer.Registration, TestData);

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

        //testing ID Found

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
        public void TestCustomer_PostCodeFound()
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
            if (anCustomer.Customer_PostCode != "PL5 5EE")
            {
                OK = false;
            }
            //Test to see that the restul is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestRegistrationFound()
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
            if (anCustomer.Registration != Convert.ToDateTime("20/02/2023"))
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

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an intsance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Customer_FirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_FirstName = ""; //This should trigger an error
                                            //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration );
            //test to see that the restult is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Customer_FirstNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_FirstName = "J"; //This should trigger an error
                                            //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Customer_FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_FirstName = "Le"; //This should trigger an error
                                             //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Customer_FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_FirstName = "aersdfsdfjghfjfjfjssssaaaaarrgggggrjejejerotjerej"; //This should trigger an error
                                              //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Customer_FirstNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_FirstName = "aersdfsdfjghfjfjfjssssaaaaarrgggggrjejejerotjerejs"; //This should trigger an error
                                                                                             //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Customer_FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_FirstName = "aersdfsdfjghfjfjfjssssaaaaarrgggggrjejejerotjerejss"; //This should trigger an error
                                                                                              //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Customer_FirstNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_FirstName = "aersdfsdfjghfjfjfjssssaaa"; //This should trigger an error
                                                                                               //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Customer_FirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_FirstName = ""; 
            Customer_FirstName = Customer_FirstName.PadRight(500, 'a'); //This should fail

            //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void Customer_LastNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_LastName = ""; //This should trigger an error
                                            //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Customer_LastNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_LastName = "J"; //This should trigger an error
                                             //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Customer_LastNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_LastName = "Le"; //This should trigger an error
                                              //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Customer_LastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_LastName = "aersdfsdfjghfjfjfjssssaaaaarrgggggrjejejerotjerej"; //This should trigger an error
                                                                                             //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Customer_LastNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_LastName = "aersdfsdfjghfjfjfjssssaaaaarrgggggrjejejerotjerejs"; //This should trigger an error
                                                                                              //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Customer_LastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_LastName = "aersdfsdfjghfjfjfjssssaaaaarrgggggrjejejerotjerejss"; //This should trigger an error
                                                                                               //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Customer_LastNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_LastName = "aersdfsdfjghfjfjfjssssaaa"; //This should trigger an error
                                                                     //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Customer_LastNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_LastName = "";
            Customer_LastName = Customer_LastName.PadRight(500, 'a'); //This should fail

            //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Customer_PhoneNumberMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_PhoneNumber = ""; //This should trigger an error
                                           //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Customer_PhoneNumberMin()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_PhoneNumber = "0797948129"; //This should trigger an error
                                            //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Customer_PhoneNumberMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_PhoneNumber = "079794812902"; //This should trigger an error
                                             //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Customer_PhoneNumberMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_PhoneNumber = "0797928129023456789"; //This should trigger an error
                                                                                            //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Customer_PhoneNumberMax()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_PhoneNumber = "+4407979382194756930"; //This should trigger an error
                                                                                             //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Customer_PhoneNumberMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_PhoneNumber = "++4407979382194756930"; //This should trigger an error
                                                                                              //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Customer_PhoneNumberMid()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_PhoneNumber = "07979481290"; //This should trigger an error
                                                                    //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Customer_PhoneNumberExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_PhoneNumber = "";
            Customer_PhoneNumber= Customer_PhoneNumber.PadRight(500, 'a'); //This should fail

            //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Customer_EmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_Email = "as"; //This should trigger an error
                                           //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Customer_EmailMin()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_Email = "a@s"; //This should trigger an error
                                            //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Customer_EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_Email = "as@s"; //This should trigger an error
                                             //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Customer_EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_Email = "";
            Customer_Email = Customer_Email.PadRight(99, 'a'); //This should fail
                                                                            //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Customer_EmailMax()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_Email = "";
            Customer_Email = Customer_Email.PadRight(100, 's');
                                                                                             //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Customer_EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_Email = ""; //This should trigger an error
            Customer_Email = Customer_Email.PadRight(101, 's');
                                                                                              //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Customer_EmailMid()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_Email = ""; //This should trigger an error
            Customer_Email = Customer_Email.PadRight(50, 's');
                                                                    //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Customer_EmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_Email = "";
            Customer_Email = Customer_Email.PadRight(500, 'a'); //This should fail

            //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void Customer_PasswordMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_Password = "9372fjd"; //This should trigger an error
                                          //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Customer_PasswordMin()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_Password = "07979sde"; //This should trigger an error
                                           //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Customer_PasswordMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_Password = "07979sdes"; //This should trigger an error
                                            //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Customer_PasswordMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_Password = "";
            Customer_Password = Customer_Password.PadRight(199, 'a'); //This should fail
                                                               //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Customer_PasswordMax()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_Password = "";
            Customer_Password = Customer_Password.PadRight(200, 's');
            //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Customer_PasswordMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_Password = ""; //This should trigger an error
            Customer_Password = Customer_Password.PadRight(201, 's');
            //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Customer_PasswordMid()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_Password = ""; //This should trigger an error
            Customer_Password = Customer_Password.PadRight(100, 's');
            //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Customer_PasswordExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_Password = "";
            Customer_Password = Customer_Password.PadRight(500, 'a'); //This should fail

            //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Customer_AddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_Address = ""; //This should trigger an error
                                                  //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Customer_AddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_Address = "S"; //This should trigger an error
                                                   //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Customer_AddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_Address = "Sj"; //This should trigger an error
                                                    //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Customer_AddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_Address = "";
            Customer_Address = Customer_Address.PadRight(199, 'a'); //This should fail
                                                                      //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Customer_AddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_Address = "";
            Customer_Address = Customer_Address.PadRight(200, 's');
            //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Customer_AddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_Address = ""; //This should trigger an error
            Customer_Address = Customer_Address.PadRight(201, 's');
            //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Customer_AddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_Address = ""; //This should trigger an error
            Customer_Address = Customer_Address.PadRight(100, 's');
            //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Customer_AddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_Address = "";
            Customer_Address = Customer_Address.PadRight(500, 'a'); //This should fail

            //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void Customer_PostCodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_PostCode = "LE45H"; //This should trigger an error
                                                  //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Customer_PostCodeMin()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_PostCode = "Le45hj"; //This should trigger an error
                                                   //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Customer_PostCodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_PostCode = "LE5 8JP"; //This should trigger an error
                                                   //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Customer_PostCodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_PostCode = "LeUh4 5hp";
             
                                                                    //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Customer_PostCodeMax()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_PostCode = "";
            Customer_PostCode = Customer_PostCode.PadRight(10, 's');
            //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Customer_PostCodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_PostCode = ""; //This should trigger an error
            Customer_PostCode = Customer_PostCode.PadRight(11, 's');
            //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Customer_PostCodeMid()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_PostCode = ""; //This should trigger an error
            Customer_PostCode = Customer_PostCode.PadRight(5, 's');
            //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Customer_PostCodeExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String Customer_PostCode = "";
            Customer_PostCode = Customer_PostCode.PadRight(500, 'a'); //This should fail

            //invoke the methods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the restult is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RegistrationExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data 
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years 
            TestDate = TestDate.AddYears(-100);
            //convert the data variable to a string variable
            string Registration = TestDate.ToString();
            //invoke the moethods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RegistrationMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data 
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years 
            TestDate = TestDate.AddYears(-1);
            //convert the data variable to a string variable
            string Registration = TestDate.ToString();
            //invoke the moethods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RegistrationMin()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data 
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the data variable to a string variable
            string Registration = TestDate.ToString();
            //invoke the moethods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RegistrationMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data 
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the data variable to a string variable
            string Registration = TestDate.ToString();
            //invoke the moethods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RegistrationExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data 
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddYears(100);
            //convert the data variable to a string variable
            string Registration = TestDate.ToString();
            //invoke the moethods
            Error = anCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }











    }

}
