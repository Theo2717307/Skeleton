using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstOrder
    {
        /******************INSTANCE OF THE CLASS TEST******************/
        [TestMethod]
        public void InstanceOK()
        {
            //create instance of the order class
            clsOrder AnOrder = new clsOrder();
            //test to see if it exists
            Assert.IsNotNull( AnOrder );
        }
        /******************PROPERTY OK TESTS******************/
        [TestMethod]
        public void Order_processedPropertyOK()
        {
            //create an instance of the order class
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign the property
            bool TestData = true;
            //Assign the data to the property 
            AnOrder.Order_processed = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Order_processed, TestData);
        }
        [TestMethod]
        public void Order_timestampPropertyOK()
        {
            //create an instance of the order class
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign the property
            DateTime TestData = DateTime.Now.Date;
            //Assign the data to the property 
            AnOrder.Order_timestamp= TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Order_timestamp, TestData);
        }

        [TestMethod]
        public void Order_idPropertyOK() 
        {
            //create an instance of order class
            clsOrder AnOrder = new clsOrder();
            //create a test integer
            Int32 TestData = 1;
            //assign the integer to order_id
            AnOrder.Order_id = TestData;
            //test to see the values are the same
            Assert.AreEqual(AnOrder.Order_id, TestData);
        }
        [TestMethod]
        public void Customer_idPropertyOK()
        {
            //create an instance of the order class
            clsOrder AnOrder = new clsOrder();
            //create a test integer
            Int32 TestData = 1;
            //assign the integer to the customer_id
            AnOrder.Customer_id = TestData;
            //test to see the values are the same
            Assert.AreEqual(AnOrder.Customer_id, TestData);
        }

        /******************FIND METHOD TEST******************/
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the order class
            clsOrder AnOrder = new clsOrder();
            //create a boolean variable to store the results of validation 
            Boolean Found = false;
            //create a test data to use with the method
            Int32 TestOrderID = 2;
            Found = AnOrder.Find(TestOrderID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        /******************PROPERTY DATA TESTS******************/
        [TestMethod]
        public void TestOrderIdFound()
        {
            //create and instance of order class
            clsOrder AnOrder = new clsOrder();
            //create boolean var to store the result of the search
            Boolean Found = false;
            //create boolean var to store if the method is ok
            Boolean OK = true;
            //create test data
            Int32 OrderID = 2;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the order 
            if(AnOrder.Order_id != 2)
            {
                OK = false;
            }
            //test to see that the result is ok
            Assert.IsTrue(OK);
        }
        public void TestCustomerIdFound()
        {
            //create and instance of order class
            clsOrder AnOrder = new clsOrder();
            //create boolean var to store the result of the search
            Boolean Found = false;
            //create boolean var to store if the method is ok
            Boolean OK = true;
            //create test data
            Int32 OrderID = 2;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the order id
            if (AnOrder.Customer_id != 2)
            {
                OK = false;
            }
            //test to see that the result is ok
            Assert.IsTrue(OK);
        }
        public void TestOrderTimestampFound()
        {
            //create and instance of order class
            clsOrder AnOrder = new clsOrder();
            //create boolean var to store the result of the search
            Boolean Found = false;
            //create boolean var to store if the method is ok
            Boolean OK = true;
            //create test data
            Int32 OrderID = 2;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the order id
            if (AnOrder.Order_timestamp != Convert.ToDateTime("10/05/24"))
            {
                OK = false;
            }
            //test to see that the result is ok
            Assert.IsTrue(OK);
        }
        public void TestOrderProcessedFound()
        {
            //create and instance of order class
            clsOrder AnOrder = new clsOrder();
            //create boolean var to store the result of the search
            Boolean Found = false;
            //create boolean var to store if the method is ok
            Boolean OK = true;
            //create test data
            Int32 OrderID = 2;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the order id
            if (AnOrder.Order_processed != true)
            {
                OK = false;
            }
            //test to see that the result is ok
            Assert.IsTrue(OK);
        }
    }
}
