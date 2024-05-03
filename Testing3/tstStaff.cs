using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsStaff AnAddress = new clsStaff();
            //test to see thatit exists
            Assert.IsNotNull(AnAddress);
        }
    }
}
