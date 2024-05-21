using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Testing3
{
    [TestClass]
    public class tstStaff
    {
        // Good test data
        // Create some test data to pass the meth
        string FirstName = "Smith";
        string LastName = "Davis";
        string Position = "Assistant";
        string Department = "Saloon";
        string StartDate = DateTime.Now.ToShortDateString();

        /*************** Instance of the CLASS TEST ***********/
        [TestMethod]
        public void InstanceOK()
        {
            // Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            // Test to see that it exits
            Assert.IsNotNull(AnStaff);
        }

        /*************************** PROPERTY OK TESTS *************/
        [TestMethod]
        public void IsManagerPropertyOK()
        {
            // Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            // Create some test data to assign to the property
            Boolean TestData = true;
            // Assign the data to the property
            AnStaff.IsManager = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnStaff.IsManager, TestData);
        }

        [TestMethod]
        public void StartDatePropertyOK()
        {
            // Create and instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            // Create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            // Assign the data to the property
            AnStaff.StartDate = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnStaff.StartDate, TestData);
        }

        [TestMethod]
        public void Staff_IdPropertyOK()
        {
            // Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            // Create some test data to assign to the property
            Int32 TestData = 1;
            // Assign the data to the property
            AnStaff.Staff_ID = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnStaff.Staff_ID, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            // Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            // Create some test data to assign to the property
            string TestData = "John";
            // Assign the data to the property
            AnStaff.FirstName = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnStaff.FirstName, TestData);
        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            // Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            // Create some test data to assign to the property
            string TestData = "Wick";
            // Assign the data to the property
            AnStaff.LastName = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnStaff.LastName, TestData);
        }

        [TestMethod]
        public void PositionPropertyOK()
        {
            // Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            // Create some test data to assign to the property
            string TestData = "Sales Assistant";
            // Assign the data to the property
            AnStaff.Position = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnStaff.Position, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            // Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            // Create some test data to assign to the property
            string TestData = "Sales";
            // Assign the data to the property
            AnStaff.Department = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnStaff.Department, TestData);
        }

        /************************** FIND METHOD TEST ************/
        [TestMethod]
        public void FindMethodOK()
        {
            // Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            // Create a boolean variable to store the results of the validation
            Boolean Found = false;
            // Create a boolean var to record if the data is OK
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 Staff_ID = 2;
            // Invoke the method
            Found = AnStaff.Find(Staff_ID);
            // Check the staff id
            if (AnStaff.Staff_ID != 2)
            {
                OK = false;
            }
            // Test to see if the result is correct
            Assert.IsTrue(OK);
        }

        /***************** PROPERTY DATA TEST **************************/
        [TestMethod]
        public void TestStaff_IDFound()
        {
            // Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            // Create a Boolean variable to store the result of the search
            Boolean Found = false;
            // Create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 Staff_Id = 2;
            // Invoke the method
            Found = AnStaff.Find(Staff_Id);
            // Check the Staff ID property
            if (AnStaff.Staff_ID != 2)
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            // Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            // Create a Boolean variable to store the result of the search
            Boolean Found = false;
            // Create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 Staff_Id = 2;
            // Invoke the method
            Found = AnStaff.Find(Staff_Id);
            // Check the First Name property
            if (AnStaff.FirstName != "Wayne")
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastNameFound()
        {
            // Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            // Create a Boolean variable to store the result of the search
            Boolean Found = false;
            // Create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 Staff_ID = 2;
            // Invoke the method
            Found = AnStaff.Find(Staff_ID);
            // Check the Last Name property
            if (AnStaff.LastName != "Rooney")
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPositionFound()
        {
            // Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            // Create a Boolean variable to store the result of the search
            Boolean Found = false;
            // Create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 Staff_ID = 2;
            // Invoke the method
            Found = AnStaff.Find(Staff_ID);
            // Check the Position property
            if (AnStaff.Position != "Assistant")
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDepartmentFound()
        {
            // Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            // Create a Boolean variable to store the result of the search
            Boolean Found = false;
            // Create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 Staff_ID = 2;
            // Invoke the method
            Found = AnStaff.Find(Staff_ID);
            // Check the Department property
            if (AnStaff.Department != "Saloon")
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStartDateFound()
        {
            // Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            // Create a Boolean variable to store the result of the search
            Boolean Found = false;
            // Create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 Staff_ID = 2;
            // Invoke the method
            Found = AnStaff.Find(Staff_ID);
            // Check the StartDate property
            if (AnStaff.StartDate != Convert.ToDateTime("12/03/2023"))
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsManagerFound()
        {
            // Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            // Create a Boolean variable to store the result of the search
            Boolean Found = false;
            // Create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 Staff_ID = 2;
            // Invoke the method
            Found = AnStaff.Find(Staff_ID);
            // Check the IsManager property
            if (AnStaff.IsManager != false)
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        /************* Test for method ******************/

        [TestMethod]
        public void ValidMethodOK()
        {
            // Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            // String variable to store any error msg
            String Error = "";
            // Invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            // Test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        ///*************** Tests for MID, MIN, MAX, PLUSONE, LESSONE *****************////////////

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            // Create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // This should fail
            string FirstName = "";
            // Invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMin()
        {
            // Create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // This should pass
            string FirstName = "a";
            // Invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            // Create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // This should pass
            string FirstName = "aa";
            // Invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            // Create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // This should pass
            string FirstName = "";
            FirstName = FirstName.PadRight(49, 'a');
            // Invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMax()
        {
            // Create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // This should pass
            string FirstName = "";
            FirstName = FirstName.PadRight(50, 'a');
            // Invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            // Create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // This should fail
            string FirstName = "";
            FirstName = FirstName.PadRight(51, 'a');
            // Invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMid()
        {
            // Create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // This should pass
            string FirstName = "";
            FirstName = FirstName.PadRight(25, 'a');
            // Invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        ////**************** START DATE TEST *****************************//
        [TestMethod]
        public void StartDateExtremeMin()
        {
            // Create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // Create a variable to store the test date data
            DateTime TestDate;
            // Set the date to today's date
            TestDate = DateTime.Now.Date;
            // Change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            // Convert the date variable to a string variable
            string StartDate = TestDate.ToString("dd/MM/yyyy");
            // Invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StartDateAddedMinLessOne()
        {
            // Create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // Create a variable to store the test date data
            DateTime TestDate = new DateTime(2017, 12, 31);
            // Convert the date variable to a string variable
            string StartDate = TestDate.ToString("dd/MM/yyyy");
            // Invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StartDateAddedMin()
        {
            // Create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // Create a variable to store the test date data
            DateTime TestDate = new DateTime(2018, 1, 1);
            // Convert the date variable to a string variable
            string StartDate = TestDate.ToString("dd/MM/yyyy");
            // Invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StartDateAddedMinPlusOne()
        {
            // Create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // Create a variable to store the test date data
            DateTime TestDate = new DateTime(2018, 1, 2);
            // Convert the date variable to a string variable
            string StartDate = TestDate.ToString("dd/MM/yyyy");
            // Invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StartDateExtremeMax()
        {
            // Create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // Create a variable to store the test date data
            DateTime TestDate;
            // Set the date to today's date
            TestDate = DateTime.Now.Date;
            // Change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            // Convert the date variable to a string variable
            string StartDate = TestDate.ToString("dd/MM/yyyy");
            // Invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StartDateInvalidData()
        {
            // Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            // String variable to store an error message
            String Error = "";
            // String variable to store the err msg
            string StartDate = "this is not a date!";
            // Invoke the meth
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinLessOne()
        {
            // Create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // This should fail
            string LastName = "";
            // Invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMin()
        {
            // Create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // This should pass
            string LastName = "a";
            // Invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            // Create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // This should pass
            string LastName = "aa";
            // Invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxLessOne()
        {
            // Create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // This should pass
            string LastName = "";
            LastName = LastName.PadRight(49, 'a');
            // Invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMax()
        {
            // Create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // This should pass
            string LastName = "";
            LastName = LastName.PadRight(50, 'a');
            // Invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            // Create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // This should fail
            string LastName = "";
            LastName = LastName.PadRight(51, 'a');
            // Invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMid()
        {
            // Create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // This should pass
            string LastName = "";
            LastName = LastName.PadRight(25, 'a');
            // Invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PositionMinLessOne()
        {
            // Create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // This should fail
            string Position = "";
            // Invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PositionMin()
        {
            // Create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // This should pass
            string Position = "a";
            // Invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PositionMinPlusOne()
        {
            // Create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // This should pass
            string Position = "aa";
            // Invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PositionMaxLessOne()
        {
            // Create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // This should pass
            string Position = "";
            Position = Position.PadRight(49, 'a');
            // Invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PositionMax()
        {
            // Create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // This should pass
            string Position = "";
            Position = Position.PadRight(50, 'a');
            // Invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PositionMaxPlusOne()
        {
            // Create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // This should fail
            string Position = "";
            Position = Position.PadRight(51, 'a');
            // Invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PositionMid()
        {
            // Create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // This should pass
            string Position = "";
            Position = Position.PadRight(25, 'a');
            // Invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMinLessOne()
        {
            // Create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // This should fail
            string Department = "";
            // Invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMin()
        {
            // Create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // This should pass
            string Department = "a";
            // Invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMinPlusOne()
        {
            // Create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // This should pass
            string Department = "aa";
            // Invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMaxLessOne()
        {
            // Create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // This should pass
            string Department = "";
            Department = Department.PadRight(49, 'a');
            // Invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMax()
        {
            // Create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // This should pass
            string Department = "";
            Department = Department.PadRight(50, 'a');
            // Invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMaxPlusOne()
        {
            // Create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // This should fail
            string Department = "";
            Department = Department.PadRight(51, 'a');
            // Invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMid()
        {
            // Create an instance of the class we want to test
            clsStaff AnStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // This should pass
            string Department = "";
            Department = Department.PadRight(25, 'a');
            // Invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}
