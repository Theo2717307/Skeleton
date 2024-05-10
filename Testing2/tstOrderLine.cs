using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstOrderLine
    {
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
            AnOrderLine.Customer_id = TestData;
            //test to see if the values are equal
            Assert.AreEqual(AnOrderLine.Customer_id, TestData);
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
            Int32 TestOrderID = 15;
            Int32 TestCustomerID = 26;
            Found = AnOrderLine.Find(TestOrderID, TestCustomerID);
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
            Int32 TestOrderID = 15;
            Int32 TestCustomerID = 26;
            //invoke the method
            Found = AnOrderLine.Find(TestOrderID, TestCustomerID);
            //check the order id
            if (AnOrderLine.Order_id != 15)
            {
                OK = false;
            }
            //test to see that the result is ok
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerIdFound()
        {
            //create and instance of order class
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create boolean var to store the result of the search
            Boolean Found = false;
            //create boolean var to store if the method is ok
            Boolean OK = true;
            //create test data
            Int32 TestOrderID = 15;
            Int32 TestCustomerID = 26;
            //invoke the method
            Found = AnOrderLine.Find(TestOrderID, TestCustomerID);
            //check the order id
            if (AnOrderLine.Customer_id != 26)
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
            Int32 TestOrderID = 15;
            Int32 TestCustomerID = 26;
            //invoke the method
            Found = AnOrderLine.Find(TestOrderID, TestCustomerID);
            //check the order id
            if (AnOrderLine.Price != 560)
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
            Int32 TestOrderID = 15;
            Int32 TestCustomerID = 26;
            //invoke the method
            Found = AnOrderLine.Find(TestOrderID, TestCustomerID);
            //check the order id
            if (AnOrderLine.Quantity != 45)
            {
                OK = false;
            }
            //test to see that the result is ok
            Assert.IsTrue(OK);
        }
    }
}