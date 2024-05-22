using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class TstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class 
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //test to see that is exists
            Assert.IsNotNull(AllCustomer);
        }
        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property
            //in the caase the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //create the itesm of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Active = true;
            TestItem.Customer_Id = 1;
            TestItem.Customer_FirstName = "Sahil";
            TestItem.Customer_LastName = "Suresh";
            TestItem.Customer_PhoneNumber = "1234567890";
            TestItem.Customer_Email = "sahilsuresh@gmail.com";
            TestItem.Customer_Address = "Some Street";
            TestItem.Customer_PostCode = "LE4 5UU";
            TestItem.Registration = DateTime.Now;
            //Add the items to the test list 
            TestList.Add(TestItem);
            //Assign the data to the property
            AllCustomer.CustomerList = TestList;
            //test to see that two values are the same
            Assert.AreEqual(AllCustomer.CustomerList, TestList);
        }

        /*[TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of class
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create sine test data
            Int32 SomeCount = 2;
            //assign the data to the property
            AllCustomer.Count = SomeCount;
            //Test To see that the two values are the same
            Assert.AreEqual(AllCustomer.Count, SomeCount);
        }*/

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Active = true;
            TestItem.Customer_Id = 1;
            TestItem.Customer_FirstName = "Sahil";
            TestItem.Customer_LastName = "Suresh";
            TestItem.Customer_PhoneNumber = "1234567890";
            TestItem.Customer_Email = "sahilsuresh@gmail.com";
            TestItem.Customer_Address = "Some Street";
            TestItem.Customer_PostCode = "LE4 5UU";
            TestItem.Registration = DateTime.Now;
            //Assign the data to the property
            AllCustomer.ThisCustomer = TestItem;
            //test to see that two values are the same
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.Customer_Id = 1;
            TestItem.Customer_FirstName = "Sahil";
            TestItem.Customer_LastName = "Suresh";
            TestItem.Customer_PhoneNumber = "1234567890";
            TestItem.Customer_Email = "sahilsuresh@gmail.com";
            TestItem.Customer_Address = "Some Street";
            TestItem.Customer_PostCode = "LE4 5UU";
            TestItem.Registration = DateTime.Now;
            //Assign the data to the property
            AllCustomer.ThisCustomer = TestItem;

            //Add the record
            PrimaryKey = AllCustomer.Add();
            //Set the primary key of the test data
            TestItem.Customer_Id = PrimaryKey;
            //find the record
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            //test to see that two values are the same
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.Customer_Id = 1;
            TestItem.Customer_FirstName = "Sahil";
            TestItem.Customer_LastName = "Suresh";
            TestItem.Customer_PhoneNumber = "1234567890";
            TestItem.Customer_Email = "sahilsuresh@gmail.com";
            TestItem.Customer_Address = "Some Street";
            TestItem.Customer_PostCode = "LE4 5UU";
            TestItem.Registration = DateTime.Now;
            //Assign the data to the property
            AllCustomer.ThisCustomer = TestItem;

            //Add the record
            PrimaryKey = AllCustomer.Add();
            //Set the primary key of the test data
            TestItem.Customer_Id = PrimaryKey;
            //modify the test record
            TestItem.Active = false;
            TestItem.Customer_Id = 4;
            TestItem.Customer_FirstName = "Romesh";
            TestItem.Customer_LastName = "July";
            TestItem.Customer_PhoneNumber = "07979481293";
            TestItem.Customer_Email = "RomeshJly@gmail.com";
            TestItem.Customer_Address = "Another Street";
            TestItem.Customer_PostCode = "BS9 5UU";
            TestItem.Registration = DateTime.Now;
            //set the record based on the new test data
            AllCustomer.ThisCustomer = TestItem;
            //update the record
            AllCustomer.Update();
            //Find the record
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            //test to see that two values are the same
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }


        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property
            //in the caase the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //create the itesm of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Active = true;
            TestItem.Customer_Id = 1;
            TestItem.Customer_FirstName = "Sahil";
            TestItem.Customer_LastName = "Suresh";
            TestItem.Customer_PhoneNumber = "1234567890";
            TestItem.Customer_Email = "sahilsuresh@gmail.com";
            TestItem.Customer_Address = "Some Street";
            TestItem.Customer_PostCode = "LE4 5UU";
            TestItem.Registration = DateTime.Now;
            //Add the items to the test list 
            TestList.Add(TestItem);
            //Assign the data to the property
            AllCustomer.CustomerList = TestList;
            //test to see that two values are the same
            Assert.AreEqual(AllCustomer.Count, TestList.Count);
        }

        /*[TestMethod]
        public void TwoRecordsPresent()
        {
            //create an instance of the class
            clsCustomerCollection Customer = new clsCustomerCollection();
            //test to see that two values are the same
            Assert.AreEqual(Customer.Count, 2);
        }*/

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.Customer_Id = 1;
            TestItem.Customer_FirstName = "Sahil";
            TestItem.Customer_LastName = "Suresh";
            TestItem.Customer_PhoneNumber = "1234567890";
            TestItem.Customer_Email = "sahilsuresh@gmail.com";
            TestItem.Customer_Address = "Some Street";
            TestItem.Customer_PostCode = "LE4 5UU";
            TestItem.Registration = DateTime.Now;
            //Assign the data to the property
            AllCustomer.ThisCustomer = TestItem;

            //Add the record
            PrimaryKey = AllCustomer.Add();
            //Set the primary key of the test data
            TestItem.Customer_Id = PrimaryKey;
            //find the record
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            //Delet the record
            AllCustomer.Delete();
            //Now find the record
            Boolean Found = AllCustomer.ThisCustomer.Find(PrimaryKey);
            //test to see that two values are the same
            Assert.IsFalse(Found );
        }

        [TestMethod]
        public void ReportByPostCodeMethodOK() 
        {
            //create an instance of the class containing unfiltered results
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create an instance of te filtered data 
            clsCustomerCollection FilterCustomer = new clsCustomerCollection();
            //Apply a blank string (should return all records);
            FilterCustomer.ReportByPostCode("");
            //test to see that the two values rae the same
            Assert.AreEqual(AllCustomer.Count, FilterCustomer.Count);
        }

        [TestMethod]
        public void ReportByPostCodeNoneFound() 
        {
            //create an instance of the class
            clsCustomerCollection FilteredCutomers = new clsCustomerCollection();
            //variable to store the outcome
            Boolean OK = true;
            //Apply a post code that doesn't exist
            FilteredCutomers.ReportByPostCode("YYY YYY");
            if (FilteredCutomers.Count == 2)
            {
                //check to see that fist record is 25
                if (FilteredCutomers.CustomerList[0].Customer_Id != 25)
                {
                    OK = false;
                }
                if (FilteredCutomers.CustomerList[1].Customer_Id != 26)
                {
                    OK = false;
                }
            }
            else 
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue( OK );
        }

    }
}
