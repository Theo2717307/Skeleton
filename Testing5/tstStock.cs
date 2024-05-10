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
            //Please test your changes before you commit to the master branch
            //clsStock did not exist and it does not have a .Active method

            //clsStock AnStock = new clsStock();
            //Int32 TestData = 1;
            //AnStock.Active = TestData;
            //Assert.AreEqual(AnStock.Active, TestData);
        }
    }
}