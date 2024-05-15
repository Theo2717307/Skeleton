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
        public void FirstNameMinLessOne()
        {
            //create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string FirstName = "";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FirstName = "a";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FirstName = "aa";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FirstName = "";
            FirstName = FirstName.PadRight(49, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FirstName = "";
            FirstName = FirstName.PadRight(50, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string FirstName = "";
            FirstName = FirstName.PadRight(51, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FirstName = "";
            FirstName = FirstName.PadRight(25, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        ////**************** START DATE TEST *****************************//
        [TestMethod]
        public void StartDateExtremeMin()
        { //create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string StartDate = TestDate.ToString("dd/MM/yyyy");
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate); //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StartDateAddedMinLessOne()
        {
            //create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate = DateTime.Now.Date.AddDays(-1);
            //convert the date variable to a string variable
            string StartDate = TestDate.ToString("dd/MM/yyyy");
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        
        [TestMethod]
        public void StartDateAddedMin()
        {
            //create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string StartDate = TestDate.ToString("dd/MM/yyyy");
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StartDateAddedMinPlusOne()
        {
            //create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string StartDate = TestDate.ToString("dd/MM/yyyy");
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StartDateExtremeMax()
        {
            //create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string StartDate = TestDate.ToString("dd/MM/yyyy");
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StartDateInvalidData() 
        {  
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store an error message
            String Error = "";
            //string variable to store the err msg
            string StartDate = "this is not a date!";
            //invoke the meth
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            //test to see that te result is correct
            Assert.AreNotEqual(Error, "");
        
        }
        [TestMethod]
        public void LastNameMinLessOne()
        {
            //create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string LastName = "";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMin()
        {
            //create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string LastName = "a";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            //create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string LastName = "aa";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string LastName = "";
            LastName = LastName.PadRight(49, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMax()
        {
            //create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string LastName = "";
            LastName = LastName.PadRight(50, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string LastName = "";
            LastName = LastName.PadRight(51, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string LastName = "";
            LastName = LastName.PadRight(25, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PositionMinLessOne()
        {
            //create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Position = "";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PositionMin()
        {
            //create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Position = "a";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PositionMinPlusOne()
        {
            //create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Position = "aa";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PositionMaxLessOne()
        {
            //create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Position = "";
            Position = Position.PadRight(49, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PositionMax()
        {
            //create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Position = "";
            Position = Position.PadRight(50, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PositionMaxPlusOne()
        {
            //create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Position = "";
            Position = Position.PadRight(51, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PositionMid()
        {
            //create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Position = "";
            Position = Position.PadRight(25, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DepartmentMinLessOne()
        {
            //create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Department = "";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMin()
        {
            //create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Department = "a";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMinPlusOne()
        {
            //create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Department = "aa";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMaxLessOne()
        {
            //create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Department = "";
            Department = Department.PadRight(49, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMax()
        {
            //create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Department = "";
            Department = Department.PadRight(50, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMaxPlusOne()
        {
            //create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Department = "";
            Department = Department.PadRight(51, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMid()
        {
            //create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Department = "";
            Department = Department.PadRight(25, 'a');
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


    }
}
