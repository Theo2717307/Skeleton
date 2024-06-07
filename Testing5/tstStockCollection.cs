using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


namespace Testing5
{
    [TestClass]
    public class tstStockCollection
    {
        

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class 
            clsStockCollection AllStock = new clsStockCollection();
            //test to see if it exists
            Assert.IsNotNull(AllStock);
        }


        [TestMethod]

        public void StockListOK()
        {
            //create an instancE of class to create
            clsStockCollection AllStock = new clsStockCollection();
            //some test data to assign to the property
            //in this case data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //Add item to the list
            //create the item of test data
            clsStock TestItem = new clsStock();
            {
                // setting the properties
                TestItem.discontinued = true;
                TestItem.vehicle_id = 9;
                TestItem.stockName = "VW Golf";
                TestItem.stockDetails = "1 litre";
                TestItem.quantity = "30";
                TestItem.unit_price = "13k";
                TestItem.last_restock_date = DateTime.Now;
                //add item to the test list
                TestList.Add(TestItem);
                //assign the data to the property
                AllStock.StockList = TestList;
                // Test to see both values are the same
                Assert.AreEqual(AllStock.StockList, TestList);
            }
        }

       


        [TestMethod]
        public void ThisStockPropertyOK()
        {
            //create an instancE of class to create
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock TestStock = new clsStock();
            //setting the properties
            TestStock.discontinued = true;
            TestStock.stockName = "VW Golf";
            TestStock.stockDetails = "1 litre";
            TestStock.quantity = "30";
            TestStock.unit_price = "13k";
            TestStock.last_restock_date = DateTime.Now;
            TestStock.vehicle_id = 9;
            //assign the data to the property
            AllStock.ThisStock = TestStock;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestStock);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instancE of class to create
            clsStockCollection AllStock = new clsStockCollection();
            //some test data to assign to the property
            //in this case data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //Add item to the list
            //create the item of test data
            clsStock TestItem = new clsStock();
            // setting the properties
            TestItem.discontinued = true;
            TestItem.vehicle_id = 9;
            TestItem.stockName = "VW Golf";
            TestItem.stockDetails = "1 litre";
            TestItem.quantity = "30";
            TestItem.unit_price = "13k";
            TestItem.last_restock_date = DateTime.Now;
            //add item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStock.StockList = TestList;
            // Test to see both values are the same
            Assert.AreEqual(AllStock.Count, TestList.Count);

        }

        [TestMethod]





        public void AddMethodOK()
        {

            //create an instancE of class to create
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            // Variable to store primary key
            Int32 PrimaryKey = 0;
            // set the properties
            TestItem.discontinued = true;
            TestItem.vehicle_id = 9;
            TestItem.stockName = "VW Golf";
            TestItem.stockDetails = "1 litre";
            TestItem.quantity = "30";
            TestItem.unit_price = "13k";
            TestItem.last_restock_date = DateTime.Now;
            //set ThisStock to the test data
            AllStock.ThisStock =TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.vehicle_id = PrimaryKey;
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestItem);

        }

        [TestMethod]
        public void UpdateMethodOK()

        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.discontinued = true;
            TestItem.stockName = "VW Golf";
            TestItem.stockDetails = "1 litre";
            TestItem.last_restock_date = DateTime.Now;
            TestItem.unit_price = "13k";
            TestItem.quantity = "30";
            //set ThisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.vehicle_id = PrimaryKey;
            //modify the test record
            TestItem.discontinued = false;
            TestItem.stockName = "BMW 2 Series";
            TestItem.stockDetails = "2 litre";
            TestItem.last_restock_date = DateTime.Now;
            TestItem.unit_price = "12k";
            TestItem.quantity = "15";
            //set the record based on the new test data
            AllStock.ThisStock = TestItem;
            //update the record
            AllStock.Update();
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see if ThisStaff matche sthe test data
            Assert.AreEqual(AllStock.ThisStock, TestItem);

        }

        [TestMethod]

        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestItem = new clsStock();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.discontinued = true;
            TestItem.stockName = "VW Golf";
            TestItem.stockDetails = "1 litre";
            TestItem.last_restock_date = DateTime.Now;
            TestItem.unit_price = "13k";
            TestItem.quantity = "30";
            //Assign the data to the property
            AllStock.ThisStock = TestItem;

            //Add the record
            PrimaryKey = AllStock.Add();
            //Set the primary key of the test data
            TestItem.vehicle_id = PrimaryKey;
            //find the record
            AllStock.ThisStock = TestItem;
            //Delet the record
            AllStock.Delete();
            //Now find the record
            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);
            //test to see that two values are the same
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportBystockDetailsMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsStockCollection AllStock = new clsStockCollection();
            //create an instance of the filtered data
            clsStockCollection FilteredStock = new clsStockCollection();
            //apply a blank string (return all records ?
            FilteredStock.ReportBystockDetails("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, FilteredStock.Count);

        }

        [TestMethod]
        public void ReportBystockDetailsNoneFound()
        {
            //create an instance of the class we want to create
            clsStockCollection FilteredStock = new clsStockCollection();
            //apply a department that doesnt exists
            FilteredStock.ReportBystockDetails("Jeep");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStock.Count);

        }

        [TestMethod]
        public void ReportBystockDetailsTestDataFound()
        {
            //CREATE an instance of the filtered data
            clsStockCollection FilteredStock = new clsStockCollection();
            //variable to store the outcome
            Boolean OK = true;
            //search stock that doesnt exist
            FilteredStock.ReportBystockDetails("2 litre");
            //check the correct number of records are found
            if (FilteredStock.Count == 2)
            {
                //check to see th first record is 11
                if (FilteredStock.StockList[0].vehicle_id != 11)
                {
                    OK = false;
                }
                //check to see that the first record is 12
                if (FilteredStock.StockList[1].vehicle_id != 12)
                {
                    OK = false;
                }
                else
                {
                    OK = false;

                }
                //test to see that there are no records
                Assert.IsTrue(OK);
            }
        }


    }
}