using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStaff);

        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to creater
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some tst data to assign to the propery
            //data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.IsManager = true;
            TestItem.Staff_ID = 1;
            TestItem.FirstName = "John";
            TestItem.LastName = "Wick";
            TestItem.StartDate = DateTime.Now;
            TestItem.Department = "Luxury";
            TestItem.Position = "Assistant";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to o se that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);



        }


        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //creat some test data to assing to the property
            clsStaff TestStaff = new clsStaff();
            //set the properties of the test objects
            TestStaff.IsManager = true;
            TestStaff.FirstName = "John";
            TestStaff.LastName = "Wick";
            TestStaff.Department = "Luxury";
            TestStaff.Position = "Assistant";
            TestStaff.StartDate = DateTime.Now;
            TestStaff.Staff_ID = 1;
            //assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an isntance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.IsManager = true;
            TestItem.Staff_ID = 1;
            TestItem.FirstName = "John";
            TestItem.LastName = "Wick";
            TestItem.StartDate = DateTime.Now;
            TestItem.Department = "Luxury";
            TestItem.Position = "Assistant";
            //add the item to the test lists
            TestList.Add(TestItem);
            //assign the data to the propert
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);

        }
        //****** ADD , Updare & Delete Tests **********//

        [TestMethod]
        public void AddMethodOK() 
        {
            //create an isntance of the class we want to creat
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set it's properties
            TestItem.IsManager = true;
            TestItem.Staff_ID = 1;
            TestItem.FirstName = "John";
            TestItem.LastName = "Wick";
            TestItem.StartDate = DateTime.Now;
            TestItem.Department = "Luxury";
            TestItem.Position = "Assistant";
            //set ThisStaff to the test data 
            AllStaff.ThisStaff =  TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primau key of the test data
            TestItem.Staff_ID = PrimaryKey;
            //find this record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);

        }

        [TestMethod]
        public void UpdateMethodOK() 
        
            {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.IsManager = true;
            TestItem.FirstName = "John";
            TestItem.LastName = "Wick";
            TestItem.StartDate = DateTime.Now;
            TestItem.Department = "Luxury";
            TestItem.Position = "Assistant";
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.Staff_ID = PrimaryKey;
            //modify the test record
            TestItem.IsManager = false;
            TestItem.FirstName = "Sam";
            TestItem.LastName = "Davids";
            TestItem.StartDate = DateTime.Now;
            TestItem.Department = "Saloon";
            TestItem.Position = "Manager";
            //set the record based on the new test data
            AllStaff.ThisStaff = TestItem;
            //update the record
            AllStaff.Update();
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see if ThisStaff matche sthe test data
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);

        }   

        [TestMethod]

        public void DeleteMethod()
            {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.IsManager = true;
            TestItem.Staff_ID = 1;
            TestItem.FirstName = "John";
            TestItem.LastName = "Wick";
            TestItem.StartDate = DateTime.Now;
            TestItem.Department = "Luxury";
            TestItem.Position = "Assistant";
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey=AllStaff.Add();
            //set the primary key of the test data
            TestItem.Staff_ID = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //delete the record
            AllStaff.Delete();
            //now find the record
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found );



        }

        
        
    
    }
}
