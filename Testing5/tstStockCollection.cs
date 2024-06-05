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
        public void CountPropertyOK()
        {
            //create an instancE of class to create
            clsStockCollection AllStock = new clsStockCollection();
            //some test data to assign to the property
            Int32 SomeCount = 2;
            //assign the data to the property
            AllStock.Count = SomeCount;
            //Test to see that two values are the same
            Assert.AreEqual(AllStock.Count, SomeCount);

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
        public void TwoRecordsPresent()
        {
            //create an instancE of class to create
            clsStockCollection AllStock = new clsStockCollection();
            // Test to see both values are the same
            Assert.AreEqual(AllStock.Count, 2);
        }

    
    }
}