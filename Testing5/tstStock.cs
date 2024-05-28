using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstStock
    {

        //good test data
        // create some data to pass the methods
        
        String stockName = "VW Golf";
        String stockDetails = "1 Litre";
        String quantity = "32";
        String unit_price = "10000";
        String last_restock_date = DateTime.Now.ToShortDateString();
        

        [TestMethod]
        public void InstanceOK()
        {

            clsStock AnStock = new clsStock();

            Assert.IsNotNull(AnStock);


        }



        [TestMethod]
        public void product_idPropertyOK()
        {


            clsStock AnStock = new clsStock();

            Int32 TestData = 10;
            AnStock.product_id = TestData;
            Assert.AreEqual(AnStock.product_id, TestData);
        }

        public void stockNamePropertyOK()
        {


            clsStock AnStock = new clsStock();

            String TestData = "VW Polo";
            AnStock.stockName = TestData;
            Assert.AreEqual(AnStock.stockName, TestData);
        }

        public void stockDetailsPropertyOK()
        {


            clsStock AnStock = new clsStock();

            String TestData = "1 Litre";
            AnStock.stockDetails = TestData;
            Assert.AreEqual(AnStock.stockDetails, TestData);
        }

        public void quantityPropertyOK()
        {


            clsStock AnStock = new clsStock();

            Int32 TestData = 32;
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

    


        public void Testproduct_idFound()
        {
            //Create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            // Boolean variable to store results of search
            Boolean Found = false;
            //Boolean to record if data is ok
            Boolean OK = true;
            // test data to use with the method
            Int32 product_id = 10;
            //invoke the method
            Found = AnStock.Find(product_id);
            //check the product id 
            if (AnStock.product_id != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);



        }

        public void stockNameFound()
        {
            //Create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            // Boolean variable to store results of search
            Boolean Found = false;
            //Boolean to record if data is ok
            Boolean OK = true;
            // test data to use with the method
            Int32 product_id = 10;
            //invoke the method
            Found = AnStock.Find(product_id);
            //check the product id 
            if (AnStock.stockName != "VW Golf")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);



        }

        public void stockDetailsFound()
        {
            //Create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            // Boolean variable to store results of search
            Boolean Found = false;
            //Boolean to record if data is ok
            Boolean OK = true;
            // test data to use with the method
            Int32 product_id = 10;
            //invoke the method
            Found = AnStock.Find(product_id);
            //check the product id 
            if (AnStock.stockDetails != "1 Litre")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);



        }

        public void quantityFound()
        {
            //Create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            // Boolean variable to store results of search
            Boolean Found = false;
            //Boolean to record if data is ok
            Boolean OK = true;
            // test data to use with the method
            Int32 product_id = 10;
            //invoke the method
            Found = AnStock.Find(product_id);
            //check the product id 
            if (AnStock.quantity != 32)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);



        }

        public void unit_priceFound()
        {
            //Create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            // Boolean variable to store results of search
            Boolean Found = false;
            //Boolean to record if data is ok
            Boolean OK = true;
            // test data to use with the method
            Int32 product_id = 10;
            //invoke the method
            Found = AnStock.Find(product_id);
            //check the product id 
            if (AnStock.unit_price != 10000)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);



        }
        public void last_restock_dateFound()
        {
            //Create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            // Boolean variable to store results of search
            Boolean Found = false;
            //Boolean to record if data is ok
            Boolean OK = true;
            // test data to use with the method
            Int32 product_id = 10;
            //invoke the method
            Found = AnStock.Find(product_id);
            //check the product id 
            if (AnStock.last_restock_date != Convert.ToDateTime("1/01/2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);



        }

        public void discontinuedFound()
        {
            //Create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            // Boolean variable to store results of search
            Boolean Found = false;
            //Boolean to record if data is ok
            Boolean OK = true;
            // test data to use with the method
            Int32 product_id = 10;
            //invoke the method
            Found = AnStock.Find(product_id);
            //check the product id 
            if (AnStock.discontinued != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);



        }

        

       


    }
}