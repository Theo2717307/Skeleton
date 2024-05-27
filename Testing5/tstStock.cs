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
            Assert.AreEqual(AnStock.unit_price, TestData);
        }

        public void last_restock_datePropertyOK()
        {

             
            clsStock AnStock = new clsStock();

            DateTime TestData = DateTime.Now.Date;
            AnStock.last_restock_date = TestData;
            Assert.AreEqual(AnStock.last_restock_date, TestData);
        }

        public void discontinuedPropertyOK()
        {


            clsStock AnStock = new clsStock();

            Boolean TestData = false;
            AnStock.discontinued = TestData;
            Assert.AreEqual(AnStock.discontinued, TestData);
        }


        public void FindMethodOK()

        {
            //Create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            // Boolean variable to store results of validation
            Boolean Found = false;
            //Test data to use with the method
            Int32 product_id = 10;
            //Invoke the method
            Found = AnStock.Find(product_id);
            //test to see if results are true
            Assert.IsTrue(Found);

        }



    }
}