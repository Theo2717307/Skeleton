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
    }
}