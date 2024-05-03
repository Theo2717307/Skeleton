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
            //create instance of a new class
            clsOrder AnOrder = new clsOrder();
            //test to see if it exists
            Assert.IsNotNull( AnOrder );
        }
    }
}
