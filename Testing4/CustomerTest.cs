using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer AnAddress = new clsCustomer();

            Assert.IsNotNull(AnAddress);
        }
    }
}
