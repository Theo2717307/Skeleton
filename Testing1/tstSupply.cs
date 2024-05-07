using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstSupply
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSupply Supplier_Name = new clsSupply();
            Assert.IsNotNull(Supplier_Name);
        }
        [TestMethod]
        public void Supplier_NamePropertyOK()
        {
            clsSupply Supply = new clsSupply();
            String TestData = "abc";
            Supply.Supplier_Name = TestData;
            Assert.AreEqual(Supply.Supplier_Name, TestData);
        }

        [TestMethod]
        public void Supplier_Phone_NumberPropertyOK()
        {
            clsSupply Supply = new clsSupply();
            String TestData = "abc";
            Supply.Supplier_Phone_Number = TestData;
            Assert.AreEqual(Supply.Supplier_Phone_Number, TestData);
        }

        [TestMethod]
        public void Supplier_AddressPropertyOK()
        {
            clsSupply Supply = new clsSupply();
            String TestData = "abc";
            Supply.Supplier_Address = TestData;
            Assert.AreEqual(Supply.Supplier_Address, TestData);
        }

        [TestMethod]
        public void Supplier_EmailPropertyOK()
        {
            clsSupply Supply = new clsSupply();
            String TestData = "abc";
            Supply.Supplier_Email = TestData;
            Assert.AreEqual(Supply.Supplier_Email, TestData);
        }

        [TestMethod]
        public void Supplier_CountryPropertyOK()
        {
            clsSupply Supply = new clsSupply();
            String TestData = "abc";
            Supply.Supplier_Country = TestData;
            Assert.AreEqual(Supply.Supplier_Country, TestData);
        }

        [TestMethod]
        public void Supplier_ExportPropertyOK()
        {
            clsSupply Supply = new clsSupply();
            bool TestData = true;
            Supply.Supplier_Export = TestData;
            Assert.AreEqual(Supply.Supplier_Export, TestData);
        }

        [TestMethod]
        public void Supplier_Trade_RestrictionsPropertyOK()
        {
            clsSupply Supply = new clsSupply();
            bool TestData = true;
            Supply.Supplier_Trade_Restrictions = TestData;
            Assert.AreEqual(Supply.Supplier_Trade_Restrictions, TestData);
        }
    }      
}
