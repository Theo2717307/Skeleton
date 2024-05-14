using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Testing3
{
    [TestClass]
    public class tstStaff
    {

        //good test data
        //create some test data to pass the meth
        string FirstName = "Smith";
        string LastName = "Davis";
        string Position = "Assistant";
        string Department = "Saloon";
        string StartDate = DateTime.Now.ToShortDateString();

        /***************Instance of the CLASS TEST ***********/
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //test to see that it exits
            Assert.IsNotNull(AnStaff);

        }
        /***************************PROPERTY OK TESTS*************/
        [TestMethod]
        public void IsManagerPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnStaff.IsManager = TestData;
            //test to see that the two values are the dame
            Assert.AreEqual(AnStaff.IsManager, TestData);
        }
        [TestMethod]
        public void StartDatePropertyOK()
        {
            //create and instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnStaff.StartDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StartDate, TestData);


        }
        [TestMethod]
        public void Staff_IdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnStaff.Staff_ID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Staff_ID, TestData);
        }
        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "John";
            //assign the data to the property
            AnStaff.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.FirstName, TestData);
        }
        [TestMethod]
        public void LastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Wick";
            //assign the data to the property
            AnStaff.LastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.LastName, TestData);



        }
        [TestMethod]
        public void PositionPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Sales Assistant";
            //assign the data to the property
            AnStaff.Position = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Position, TestData);


        }
        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Sales";
            //assign the data to the property
            AnStaff.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Department, TestData);
       
        }
        /**************************FIND METH TEST************/
        [TestMethod]
        public void FindMethodOK()
        {
        //create an instance of the class we want to create 
        clsStaff AnStaff = new clsStaff();
        //create a boolean variable to store the results of the validation
        Boolean Found = false;
        //create a boolean var to record if the data is OK
        Boolean OK = true;
        //create some test data to use with the method
        Int32 Staff_ID = 3;
        //invoke the method
        Found = AnStaff.Find(Staff_ID);
        //check the staff id 
        if (AnStaff.Staff_ID != 3)
            {
                OK = false; 
            }
        //test to see if the result is correct
        Assert.IsTrue(OK);

        }



        /***************** PROPERTY DATA TEST **************************/
        [TestMethod]
        public void TestStaff_IDFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Staff_Id = 3;
            //invoke the method
            Found = AnStaff.Find(Staff_Id);
            //check the Staff ID property
            if (AnStaff.Staff_ID != 3)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Staff_Id = 3;
            //invoke the method
            Found = AnStaff.Find(Staff_Id);
            //check the First Name property
            if (AnStaff.FirstName != "Smith")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
       

        [TestMethod]
        public void TestLastNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Staff_ID = 3;
            //invoke the method
            Found = AnStaff.Find(Staff_ID);
            //check the Last Name property
            if (AnStaff.LastName != "Davis")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPositionFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Staff_ID = 3;
            //invoke the method
            Found = AnStaff.Find(Staff_ID);
            //check the Position property
            if (AnStaff.Position != "Assistant")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDepartmentFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Staff_ID = 3;
            //invoke the method
            Found = AnStaff.Find(Staff_ID);
            //check the Department property
            if (AnStaff.Department != "Saloon")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStartDateFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Staff_ID = 3;
            //invoke the method
            Found = AnStaff.Find(Staff_ID);
            //check the StartDate property
            if (AnStaff.StartDate != Convert.ToDateTime("12/01/2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsManagerFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Staff_ID = 3;
            //invoke the method
            Found = AnStaff.Find(Staff_ID);
            //check the IsManager property
            if (AnStaff.IsManager != false)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        /************* Test for method ******************/

        [TestMethod]

        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error msg
            String Error = "";
            //invoke the method
            Error = AnStaff.Valid(FirstName,LastName,Position,Department,StartDate);
            //test to see the result is correct
            Assert.AreEqual(Error, "");



        }

        ///*************** Tests for MID, MIN, MAX, PLUSONE, LESSONE *****************////////////

        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "a"; //this should be ok
                                    //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aa"; //this should be ok
                                     //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
                                        //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMax()
        {
            // Create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // Test data for the method
            string FirstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; // this should be ok
                                         // Invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            // Test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMid()
        {
            // Create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // Test data for the method
            string FirstName = "aaaaaaaaaaaaaaaaaaaaaaaaa"; // this should be ok
                                      // Invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            // Test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; // should fail
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            //test to see tha t result is correct
            Assert.AreNotEqual(Error, "");



        }

        [TestMethod]
        public void FirstNameExtremeMax() 
        {
            //create an instance of the class we want to create 
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error msg
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(500, 'a');// should fail
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            //test to see tha t result is correct
            Assert.AreNotEqual(Error, "");

        }

        ////
    }
}
