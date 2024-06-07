using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstOrder
    {
        //Good test data
        //Create some test data to pass the method
        String order_id = "2";
        String customer_id = "2";
        String order_timestamp = DateTime.Now.ToShortDateString();
        Boolean order_processed = true;

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

        /******************VALID DATA TESTS******************/
        [TestMethod]
        public void ValidMethodOK()
        {
            //create and instance of order class
            clsOrder AnOrder = new clsOrder();
            //create a string var to store any error message
            string error_message = "";
            //invoke the method 
            error_message = AnOrder.Valid(order_id, customer_id, order_timestamp, order_processed);
            //Test to see that the result is correct
            Assert.AreEqual(error_message, "");
        }

        /******************ORDER_TIMESTAMP TESTS******************/
        [TestMethod]
        public void Order_TimestampExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            String error_message = "";
            DateTime TestDate = DateTime.Now.Date;
            //change the date to the extreme minimum
            TestDate = TestDate.AddYears(-50);
            //convert the date to a string
            string test_order_timestamp = TestDate.ToString();
            //invoke method
            error_message = AnOrder.Valid(order_id, customer_id, test_order_timestamp, order_processed);
            //test to see the string is correct
            Assert.AreNotEqual(error_message, "");

        }
        [TestMethod]
        public void Order_TimestampMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String error_message = "";
            DateTime TestDate = DateTime.Now.Date;
            //change the date to the extreme minimum
            TestDate = TestDate.AddDays(-1);
            //convert the date to a string
            string test_order_timestamp = TestDate.ToString();
            //invoke method
            error_message = AnOrder.Valid(order_id, customer_id, test_order_timestamp, order_processed);
            //test to see the string is correct
            Assert.AreNotEqual(error_message, "");
        }
        [TestMethod]
        public void Order_TimestampMin()
        {
            clsOrder AnOrder = new clsOrder();
            String error_message = "";
            DateTime TestDate = DateTime.Now.Date;
            //convert the date to a string
            String test_order_timestamp = TestDate.ToString();
            //invoke method
            error_message = AnOrder.Valid(order_id, customer_id, test_order_timestamp, order_processed);
            //test to see the string is correct
            Assert.AreEqual(error_message, "");
        }
        [TestMethod]
        public void Order_TimestampMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String error_message = "";
            DateTime TestDate = DateTime.Now.Date;
            //change the date to the extreme minimum
            TestDate = TestDate.AddDays(1);
            //convert the date to a string
            string test_order_timestamp = TestDate.ToString();
            //invoke method
            error_message = AnOrder.Valid(order_id, customer_id, test_order_timestamp, order_processed);
            //test to see the string is correct
            Assert.AreNotEqual(error_message, "");
        }
        [TestMethod]
        public void Order_TimestampExtremePlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String error_message = "";
            DateTime TestDate = DateTime.Now.Date;
            //change the date to the extreme minimum
            TestDate = TestDate.AddYears(50);
            //convert the date to a string
            string test_order_timestamp = TestDate.ToString();
            //invoke method
            error_message = AnOrder.Valid(order_id, customer_id, test_order_timestamp, order_processed);
            //test to see the string is correct
            Assert.AreNotEqual(error_message, "");
        }
        [TestMethod]
        public void Order_TimestampNonDate()
        {
            clsOrder AnOrder = new clsOrder();
            String error_message = "";
            //blank date
            string test_order_timestamp = "";
            //invoke method
            error_message = AnOrder.Valid(order_id, customer_id, test_order_timestamp, order_processed);
            //test to see the string is correct
            Assert.AreNotEqual(error_message, "");
        }
        /******************ORDER_PROCESSED TESTS******************/
        [TestMethod]
        public void Order_ProcessedMin()
        {
            clsOrder AnOrder = new clsOrder();
            String error_message = "";
            Boolean test_order_processed = false;
            error_message = AnOrder.Valid(order_id, customer_id, order_timestamp, test_order_processed);
            //test to see if pass or fail
            Assert.AreEqual(error_message, "");
        }
        [TestMethod]
        public void Order_ProcessedMax()
        {
            clsOrder AnOrder = new clsOrder();
            String error_message = "";
            Boolean test_order_processed = true;
            error_message = AnOrder.Valid(order_id, customer_id, order_timestamp, test_order_processed);
            //test to see if pass or fail
            Assert.AreEqual(error_message, "");
        }


        /******************Customer ID TESTS******************/
        [TestMethod]
        public void CustomerIdMinExtreme()
        {
            clsOrder AnOrder = new clsOrder();
            String error_message = "";
            String test_customer_id = "-2147483648";
            error_message = AnOrder.Valid(order_id, test_customer_id, order_timestamp, order_processed);
            //test to see if pass or fail
            Assert.AreNotEqual(error_message, "");
        }
        [TestMethod]
        public void CustomerIdMinMinus1()
        {
            clsOrder AnOrder = new clsOrder();
            String error_message = "";
            String test_customer_id = "-1";
            error_message = AnOrder.Valid(order_id, test_customer_id, order_timestamp, order_processed);
            //test to see if pass or fail
            Assert.AreNotEqual(error_message, "");
        }
        [TestMethod]
        public void CustomerIdMinBoundary()
        {
            clsOrder AnOrder = new clsOrder();
            String error_message = "";
            String test_customer_id = "0";
            error_message = AnOrder.Valid(order_id, test_customer_id, order_timestamp, order_processed);
            //test to see if pass or fail
            Assert.AreEqual(error_message, "");
        }
        [TestMethod]
        public void CustomerIdMinPlus1()
        {
            clsOrder AnOrder = new clsOrder();
            String error_message = "";
            String test_customer_id = "1";
            error_message = AnOrder.Valid(order_id, test_customer_id, order_timestamp, order_processed);
            //test to see if pass or fail
            Assert.AreEqual(error_message, "");
        }
        [TestMethod]
        public void CustomerIdMaxMinus1()
        {
            clsOrder AnOrder = new clsOrder();
            String error_message = "";
            String test_customer_id = "2147483646";
            error_message = AnOrder.Valid(order_id, test_customer_id, order_timestamp, order_processed);
            //test to see if pass or fail
            Assert.AreEqual(error_message, "");
        }
        [TestMethod]
        public void CustomerIdMaxBoundary()
        {
            clsOrder AnOrder = new clsOrder();
            String error_message = "";
            String test_customer_id = "2147483647";
            error_message = AnOrder.Valid(order_id, test_customer_id, order_timestamp, order_processed);
            //test to see if pass or fail
            Assert.AreEqual(error_message, "");
        }
        [TestMethod]
        public void CustomerIdMaxPlus1()
        {
            clsOrder AnOrder = new clsOrder();
            String error_message = "";
            String test_customer_id = "2147483648";
            error_message = AnOrder.Valid(order_id, test_customer_id, order_timestamp, order_processed);
            //test to see if pass or fail
            Assert.AreNotEqual(error_message, "");
        }
        [TestMethod]
        public void CustomerIdMid()
        {
            clsOrder AnOrder = new clsOrder();
            String error_message = "";
            String test_customer_id = "1073741823";
            error_message = AnOrder.Valid(order_id, test_customer_id, order_timestamp, order_processed);
            //test to see if pass or fail
            Assert.AreEqual(error_message, "");
        }
        [TestMethod]
        public void CustomerIdInvalidString()
        {
            clsOrder AnOrder = new clsOrder();
            String error_message = "";
            String test_customer_id = "an invalid string";
            error_message = AnOrder.Valid(order_id, test_customer_id, order_timestamp, order_processed);
            //test to see if pass or fail
            Assert.AreNotEqual(error_message, "");
        }
        [TestMethod]
        public void CustomerIdInvalidNull()
        {
            clsOrder AnOrder = new clsOrder();
            String error_message = "";
            String test_customer_id = null;
            error_message = AnOrder.Valid(order_id, null, order_timestamp, order_processed);
            //test to see if pass or fail
            Assert.AreNotEqual(error_message, "");
        }



    }
}
