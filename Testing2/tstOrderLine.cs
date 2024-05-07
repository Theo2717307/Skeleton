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
            Assert.AreEqual(AnOrderLine.Price, TestData)
        }
    }
}