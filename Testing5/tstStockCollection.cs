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
                TestItem.product_id = 9;
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
            TestStock.product_id = 9;
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
            TestItem.product_id = 9;
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
            TestItem.product_id = 9;
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
            TestItem.product_id = PrimaryKey;
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
            TestItem.product_id = PrimaryKey;
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

    }
}