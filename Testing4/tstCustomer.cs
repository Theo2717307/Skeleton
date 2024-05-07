using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstCustomer

    {
        [TestMethod]
        public void instanceOK()
        {
            clsCustomer anCustomer = new clsCustomer();
            Assert.IsNotNull(anCustomer);
        }

        [TestMethod]
        public void CustomerIdPropertyOK() {
            clsCustomer anCustomer = new clsCustomer();
            Int32 TestData = 1;
            anCustomer.CustomerId = TestData;
            Assert.AreEqual(anCustomer.CustomerId, TestData);
        }
    }
}
