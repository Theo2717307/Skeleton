using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void TestMethod1()
        {

            clsStock AnStock = new clsStock();

            Assert.IsNotNull(AnStock);


        }


        [TestMethod]
        public void product_idPropertyOK()
        {
            

            clsStock AnStock = new clsStock();

            Int32 TestData = 1;
            AnStock.product_id = TestData;
            Assert.AreEqual(AnStock.product_id, TestData);
        }

        public void stockNamePropertyOK()
        {


            clsStock AnStock = new clsStock();

            String TestData = "Mercedes";
            AnStock.stockName = TestData;
            Assert.AreEqual(AnStock.stockName, TestData);
        }

        public void stockDetailsPropertyOK()
        {


            clsStock AnStock = new clsStock();

            String TestData = "Vehicle Description";
            AnStock.stockDetails = TestData;
            Assert.AreEqual(AnStock.stockDetails, TestData);
        }

        public void quantityPropertyOK()
        {


            clsStock AnStock = new clsStock();

            Int32 TestData = 1;
            AnStock.quantity = TestData;
            Assert.AreEqual(AnStock.quantity, TestData);
        }

        public void unit_pricePropertyOK()
        {


            clsStock AnStock = new clsStock();

            Int32 TestData = 1;
            AnStock.unit_price = TestData;
            Assert.AreEqual(AnStock.product_id, TestData);
        }

        public void last_restock_datePropertyOK()
        {

             
            clsStock AnStock = new clsStock();

        date TestData = 14/01/2024;
            AnStock.last_restock_date = TestData;
            Assert.AreEqual(AnStock.last_restock_date, TestData);
        }

        public void discontinuedPropertyOK()
        {


            clsStock AnStock = new clsStock();

            bool TestData = false;
            AnStock.product_id = TestData;
            Assert.AreEqual(AnStock.product_id, TestData);
        }



    }
}