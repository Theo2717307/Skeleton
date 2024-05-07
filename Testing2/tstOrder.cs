using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create instance of the order class
            clsOrder AnOrder = new clsOrder();
            //test to see if it exists
            Assert.IsNotNull( AnOrder );
        }
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
    }
}
