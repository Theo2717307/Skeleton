using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsStock AnStock = new clsStock();

            Assert.IsNotNull(AnStock);
            //test
        }


        [TestMethod]
        public void product_idPropertyOK()
        {

            clsStock AnStock = new clsStock();
            Int32 TestData = 1;
            AnStock.Active = TestData;
            Assert.AreEqual(AnStock.Active, TestData);
        }
    }
}