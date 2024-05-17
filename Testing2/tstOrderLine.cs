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
            //assign the integer to customer_id
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
    }
}