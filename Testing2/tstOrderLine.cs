using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstOrderLine
    {
        //Good test data
        //Create some test data to pass the method
        String order_id = "2";
        String product_id = "3";
        String quantity = "20";
        String price = "230";


        /******************INSTANCE OF THE CLASS TEST******************/
        [TestMethod]
        public void InstanceOK()
        {
            //create instance of a new class
            clsOrderLine AnOrderLine = new clsOrderLine();
            //test to see if it exists
            Assert.IsNotNull(AnOrderLine);
        }

        [TestMethod]
        public void Order_idPropertyOK()
        {
            //create instance of orderLine class
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create a test integer
            Int32 TestData = 1;
            //assign the integer to order_id
            AnOrderLine.Order_id = TestData;
            //test to see if the values are the same 
            Assert.AreEqual(AnOrderLine.Order_id, TestData);
        }
        [TestMethod]
        public void Product_idPropertyOK()
        {
            //create an instance of orderLine class
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create a test integer
            Int32 TestData = 1;
            //assign the integer to product_id
            AnOrderLine.Product_id = TestData;
            //test to see if the values are equal
            Assert.AreEqual(AnOrderLine.Product_id, TestData);
        }
        [TestMethod]
        public void QuantityPropertyOK()
        {
            //create an instance of orderLine class
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create a test integer
            Int32 TestData = 25;
            //assign the integer to quantity
            AnOrderLine.Quantity = TestData;
            //test to see if the values are the same
            Assert.AreEqual(AnOrderLine.Quantity, TestData);
        }
        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance of orderLine class
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create a test integer
            Int32 TestData = 199;
            //assign the integer to price
            //with the two number counting from the right being decimal places
            AnOrderLine.Price = TestData;
            //test to see if the values are the same
            Assert.AreEqual(AnOrderLine.Price, TestData);
        }

        /******************FIND METHOD TEST******************/
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the order class
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create a boolean variable to store the results of validation 
            Boolean Found = false;
            //create a test data to use with the method
            Int32 TestOrderID = Convert.ToInt32(order_id);
            Int32 TestProductID = Convert.ToInt32(product_id);
            Found = AnOrderLine.Find(TestOrderID, TestProductID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        /******************PROPERTY DATA TESTS******************/
        [TestMethod]
        public void TestOrderIdFound()
        {
            //create and instance of order class
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create boolean var to store the result of the search
            Boolean Found = false;
            //create boolean var to store if the method is ok
            Boolean OK = true;
            //create test data
            Int32 TestOrderID = Convert.ToInt32(order_id);
            Int32 TestProductID = Convert.ToInt32(product_id);
            //invoke the method
            Found = AnOrderLine.Find(TestOrderID, TestProductID);
            //check the order id
            if (AnOrderLine.Order_id != TestOrderID)
            {
                OK = false;
            }
            //test to see that the result is ok
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestProductIdFound()
        {
            //create and instance of order class
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create boolean var to store the result of the search
            Boolean Found = false;
            //create boolean var to store if the method is ok
            Boolean OK = true;
            //create test data
            Int32 TestOrderID = Convert.ToInt32(order_id);
            Int32 TestProductID = Convert.ToInt32(product_id);
            //invoke the method
            Found = AnOrderLine.Find(TestOrderID, TestProductID);
            //check the order id
            if (AnOrderLine.Product_id != TestProductID)
            {
                OK = false;
            }
            //test to see that the result is ok
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPriceFound()
        {
            //create and instance of order class
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create boolean var to store the result of the search
            Boolean Found = false;
            //create boolean var to store if the method is ok
            Boolean OK = true;
            //create test data
            Int32 TestOrderID = Convert.ToInt32(order_id);
            Int32 TestProductID = Convert.ToInt32(product_id);
            Int32 TestPrice = Convert.ToInt32(price);
            //invoke the method
            Found = AnOrderLine.Find(TestOrderID, TestProductID);
            //check the order id
            if (AnOrderLine.Price != TestPrice)
            {
                OK = false;
            }
            //test to see that the result is ok
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestQuantityFound()
        {
            //create and instance of order class
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create boolean var to store the result of the search
            Boolean Found = false;
            //create boolean var to store if the method is ok
            Boolean OK = true;
            //create test data
            Int32 TestOrderID = Convert.ToInt32(order_id);
            Int32 TestProductID = Convert.ToInt32(product_id);
            Int32 TestQuantity = Convert.ToInt32(quantity);
            //invoke the method
            Found = AnOrderLine.Find(TestOrderID, TestProductID);
            //check the order id
            if (AnOrderLine.Quantity != TestQuantity)
            {
                OK = false;
            }
            //test to see that the result is ok
            Assert.IsTrue(OK);
        }
        /******************VALID DATA TESTS******************/
        [TestMethod]
        public void ValidMethodOK()
        {
            //create and instance of order class
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create a string var to store any error message
            string error_message = "";
            //invoke the method 
            error_message = AnOrderLine.Valid(order_id, product_id, quantity, price);
            //Test to see that the result is correct
            Assert.AreEqual(error_message, "");
        }


        /******************Order ID TESTS******************/
        [TestMethod]
        public void OrderIdMinExtreme()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String error_message = "";
            String test_order_id = "-2147483648";
            error_message = AnOrderLine.Valid(test_order_id, product_id, quantity, price);
            //test to see if pass or fail
            Assert.AreNotEqual(error_message, "");
        }
        [TestMethod]
        public void OrderIdMinMinus1()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String error_message = "";
            String test_order_id = "-1";
            error_message = AnOrderLine.Valid(test_order_id, product_id, quantity, price);
            //test to see if pass or fail
            Assert.AreNotEqual(error_message, "");
        }
        [TestMethod]
        public void OrderIdMinBoundary()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String error_message = "";
            String test_order_id = "0";
            error_message = AnOrderLine.Valid(test_order_id, product_id, quantity, price);
            //test to see if pass or fail
            Assert.AreEqual(error_message, "");
        }
        [TestMethod]
        public void OrderIdMinPlus1()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String error_message = "";
            String test_order_id = "1";
            error_message = AnOrderLine.Valid(test_order_id, product_id, quantity, price);
            //test to see if pass or fail
            Assert.AreEqual(error_message, "");
        }
        [TestMethod]
        public void OrderIdMaxMinus1()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String error_message = "";
            String test_order_id = "2147483646";
            error_message = AnOrderLine.Valid(test_order_id, product_id, quantity, price);
            //test to see if pass or fail
            Assert.AreEqual(error_message, "");
        }
        [TestMethod]
        public void OrderIdMaxBoundary()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String error_message = "";
            String test_order_id = "2147483647";
            error_message = AnOrderLine.Valid(test_order_id, product_id, quantity, price);
            //test to see if pass or fail
            Assert.AreEqual(error_message, "");
        }
        [TestMethod]
        public void OrderIdMaxPlus1()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String error_message = "";
            String test_order_id = "2147483648";
            error_message = AnOrderLine.Valid(test_order_id, product_id, quantity, price);
            //test to see if pass or fail
            Assert.AreNotEqual(error_message, "");
        }
        [TestMethod]
        public void OrderIdMid()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String error_message = "";
            String test_order_id = "1073741823";
            error_message = AnOrderLine.Valid(test_order_id, product_id, quantity, price);
            //test to see if pass or fail
            Assert.AreEqual(error_message, "");
        }
        [TestMethod]
        public void OrderIdInvalidString()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String error_message = "";
            String test_order_id = "an invalid string";
            error_message = AnOrderLine.Valid(test_order_id, product_id, quantity, price);
            //test to see if pass or fail
            Assert.AreNotEqual(error_message, "");
        }
        [TestMethod]
        public void OrderIdInvalidNull()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String error_message = "";
            String test_order_id = null;
            error_message = AnOrderLine.Valid(test_order_id, product_id, quantity, price);
            //test to see if pass or fail
            Assert.AreNotEqual(error_message, "");
        }
        /******************Product ID TESTS******************/
        [TestMethod]
        public void ProductIdMinExtreme()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String error_message = "";
            String test_product_id = "-2147483648";
            error_message = AnOrderLine.Valid(order_id, test_product_id, quantity, price);
            //test to see if pass or fail
            Assert.AreNotEqual(error_message, "");
        }
        [TestMethod]
        public void ProductIdMinMinus1()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String error_message = "";
            String test_product_id = "-1";
            error_message = AnOrderLine.Valid(order_id, test_product_id, quantity, price);
            //test to see if pass or fail
            Assert.AreNotEqual(error_message, "");
        }
        [TestMethod]
        public void ProductIdMinBoundary()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String error_message = "";
            String test_product_id = "0";
            error_message = AnOrderLine.Valid(order_id, test_product_id, quantity, price);
            //test to see if pass or fail
            Assert.AreEqual(error_message, "");
        }
        [TestMethod]
        public void ProductIdMinPlus1()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String error_message = "";
            String test_product_id = "1";
            error_message = AnOrderLine.Valid(order_id, test_product_id, quantity, price);
            //test to see if pass or fail
            Assert.AreEqual(error_message, "");
        }
        [TestMethod]
        public void ProductIdMaxMinus1()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String error_message = "";
            String test_product_id = "2147483646";
            error_message = AnOrderLine.Valid(order_id, test_product_id, quantity, price);
            //test to see if pass or fail
            Assert.AreEqual(error_message, "");
        }
        [TestMethod]
        public void ProductIdMaxBoundary()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String error_message = "";
            String test_product_id = "2147483647";
            error_message = AnOrderLine.Valid(order_id, test_product_id, quantity, price);
            //test to see if pass or fail
            Assert.AreEqual(error_message, "");
        }
        [TestMethod]
        public void ProductIdMaxPlus1()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String error_message = "";
            String test_product_id = "2147483648";
            error_message = AnOrderLine.Valid(order_id, test_product_id, quantity, price);
            //test to see if pass or fail
            Assert.AreNotEqual(error_message, "");
        }
        [TestMethod]
        public void ProductIdMid()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String error_message = "";
            String test_product_id = "1073741823";
            error_message = AnOrderLine.Valid(order_id, test_product_id, quantity, price);
            //test to see if pass or fail
            Assert.AreEqual(error_message, "");
        }
        [TestMethod]
        public void ProductIdInvalidString()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String error_message = "";
            String test_product_id = "an invalid string";
            error_message = AnOrderLine.Valid(order_id, test_product_id, quantity, price);
            //test to see if pass or fail
            Assert.AreNotEqual(error_message, "");
        }
        [TestMethod]
        public void ProductIdInvalidNull()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String error_message = "";
            String test_product_id = null;
            error_message = AnOrderLine.Valid(order_id, test_product_id, quantity, price);
            //test to see if pass or fail
            Assert.AreNotEqual(error_message, "");
        }

        /******************Quantity TESTS******************/
        [TestMethod]
        public void QuantityMinExtreme()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String error_message = "";
            String test_quantity = "-2147483648";
            error_message = AnOrderLine.Valid(order_id, product_id, test_quantity, price);
            //test to see if pass or fail
            Assert.AreNotEqual(error_message, "");
        }
        [TestMethod]
        public void QuantityMinMinus1()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String error_message = "";
            String test_quantity = "-1";
            error_message = AnOrderLine.Valid(order_id, product_id, test_quantity, price);
            //test to see if pass or fail
            Assert.AreNotEqual(error_message, "");
        }
        [TestMethod]
        public void QuantityMinBoundary()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String error_message = "";
            String test_quantity = "0";
            error_message = AnOrderLine.Valid(order_id, product_id, test_quantity, price);
            //test to see if pass or fail
            Assert.AreEqual(error_message, "");
        }
        [TestMethod]
        public void QuantityMinPlus1()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String error_message = "";
            String test_quantity = "1";
            error_message = AnOrderLine.Valid(order_id, product_id, test_quantity, price);
            //test to see if pass or fail
            Assert.AreEqual(error_message, "");
        }
        [TestMethod]
        public void QuantityMaxMinus1()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String error_message = "";
            String test_quantity = "2147483646";
            error_message = AnOrderLine.Valid(order_id, product_id, test_quantity, price);
            //test to see if pass or fail
            Assert.AreEqual(error_message, "");
        }
        [TestMethod]
        public void QuantityMaxBoundary()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String error_message = "";
            String test_quantity = "2147483647";
            error_message = AnOrderLine.Valid(order_id, product_id, test_quantity, price);
            //test to see if pass or fail
            Assert.AreEqual(error_message, "");
        }
        [TestMethod]
        public void QuantityMaxPlus1()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String error_message = "";
            String test_quantity = "2147483648";
            error_message = AnOrderLine.Valid(order_id, product_id, test_quantity, price);
            //test to see if pass or fail
            Assert.AreNotEqual(error_message, "");
        }
        [TestMethod]
        public void QuantityMid()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String error_message = "";
            String test_quantity = "1073741823";
            error_message = AnOrderLine.Valid(order_id, product_id, test_quantity, price);
            //test to see if pass or fail
            Assert.AreEqual(error_message, "");
        }
        [TestMethod]
        public void QuantityInvalidString()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String error_message = "";
            String test_quantity = "an invalid string";
            error_message = AnOrderLine.Valid(order_id, product_id, test_quantity, price);
            //test to see if pass or fail
            Assert.AreNotEqual(error_message, "");
        }
        [TestMethod]
        public void QuantityInvalidNull()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String error_message = "";
            String test_quantity = null;
            error_message = AnOrderLine.Valid(order_id, product_id, test_quantity, price);
            //test to see if pass or fail
            Assert.AreNotEqual(error_message, "");
        }

        /******************Price TESTS******************/
        [TestMethod]
        public void PriceMinExtreme()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String error_message = "";
            String test_price = "-2147483648";
            error_message = AnOrderLine.Valid(order_id, product_id, quantity, test_price);
            //test to see if pass or fail
            Assert.AreNotEqual(error_message, "");
        }
        [TestMethod]
        public void PriceMinMinus1()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String error_message = "";
            String test_price = "-1";
            error_message = AnOrderLine.Valid(order_id, product_id, quantity, test_price);
            //test to see if pass or fail
            Assert.AreNotEqual(error_message, "");
        }
        [TestMethod]
        public void PriceMinBoundary()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String error_message = "";
            String test_price = "0";
            error_message = AnOrderLine.Valid(order_id, product_id, quantity, test_price);
            //test to see if pass or fail
            Assert.AreEqual(error_message, "");
        }
        [TestMethod]
        public void PriceMinPlus1()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String error_message = "";
            String test_price = "1";
            error_message = AnOrderLine.Valid(order_id, product_id, quantity, test_price);
            //test to see if pass or fail
            Assert.AreEqual(error_message, "");
        }
        [TestMethod]
        public void PriceMaxMinus1()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String error_message = "";
            String test_price = "2147483646";
            error_message = AnOrderLine.Valid(order_id, product_id, quantity, test_price);
            //test to see if pass or fail
            Assert.AreEqual(error_message, "");
        }
        [TestMethod]
        public void PriceMaxBoundary()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String error_message = "";
            String test_price = "2147483647";
            error_message = AnOrderLine.Valid(order_id, product_id, quantity, price);
            //test to see if pass or fail
            Assert.AreEqual(error_message, "");
        }
        [TestMethod]
        public void PriceMaxPlus1()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String error_message = "";
            String test_price = "2147483648";
            error_message = AnOrderLine.Valid(order_id, product_id, quantity, test_price);
            //test to see if pass or fail
            Assert.AreNotEqual(error_message, "");
        }
        [TestMethod]
        public void PriceMid()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String error_message = "";
            String test_price = "1073741823";
            error_message = AnOrderLine.Valid(order_id, product_id, quantity, test_price);
            //test to see if pass or fail
            Assert.AreEqual(error_message, "");
        }
        [TestMethod]
        public void PriceInvalidString()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String error_message = "";
            String test_price = "an invalid string";
            error_message = AnOrderLine.Valid(order_id, product_id, quantity, test_price);
            //test to see if pass or fail
            Assert.AreNotEqual(error_message, "");
        }
        [TestMethod]
        public void PriceInvalidNull()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String error_message = "";
            String test_price = null;
            error_message = AnOrderLine.Valid(order_id, product_id, quantity, test_price);
            //test to see if pass or fail
            Assert.AreNotEqual(error_message, "");
        }
    }
}