using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography.X509Certificates;

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
            string TestData = "0";
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

        [TestMethod]
        public void FindMethodOK()
        {
            clsSupply ExampleSupplier = new clsSupply();
            Boolean Found = false;
            string Supplier70 = "John";
            Found = ExampleSupplier.Find(Supplier70);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestSupplier_First_NameFound()
        {
            clsSupply Example_Supplier = new clsSupply();
            Boolean Found = false;
            Boolean OK = true;
            String Supplier70 = "John";
            Found = Example_Supplier.Find(Supplier70);
            if (Example_Supplier.Supplier_Name != "John")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplier_Phone_NumberFound()
        {
            clsSupply Example_Supplier = new clsSupply();
            Boolean Found = false;
            Boolean OK = true;
            string PNumber = "07376106016";
            Found = Example_Supplier.Find(PNumber);
            if (Example_Supplier.Supplier_Phone_Number != "07376106016")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplier_AddressFound()
        {
            clsSupply Example_Supplier = new clsSupply();
            Boolean Found = false;
            Boolean OK = true;
            string SAddress = "12 Darwin Close";
            Found = Example_Supplier.Find(SAddress);
            if (Example_Supplier.Supplier_Address != "12 Darwin Close")
            {
                OK = false;
                {
                    Assert.IsTrue(OK);
                }
            }
        }

        [TestMethod]
        public void TestSupplier_EmailFound()
        {
            clsSupply Example_Supplier = new clsSupply();
            Boolean Found = false;
            Boolean OK = true;
            string SEmail = "jhigginson@gmail.com";
            Found = Example_Supplier.Find(SEmail);
            if (Example_Supplier.Supplier_Email != "jhigginson@gmail.com")
            {
                OK = false;
                {
                    Assert.IsTrue(OK);
                }
            }
        }

        [TestMethod]
        public void TestSupplier_CountryFound()
        {
            clsSupply Example_Supplier = new clsSupply();
            Boolean Found = false;
            Boolean OK = true;
            string SCountry = "England";
            Found = Example_Supplier.Find(SCountry);
            if (Example_Supplier.Supplier_Country != "England")
            {
                OK = false;
                {
                    Assert.IsTrue(OK);
                }
            }
        }

        [TestMethod]
        public void TestSupplier_ExportFound()
        {
            clsSupply Example_Supplier = new clsSupply();
            Boolean Found = false;
            Boolean OK = true;
            String SExport = "false";
            Found = Example_Supplier.Find(SExport);
            if (Example_Supplier.Supplier_Export != false)
            {
                OK = false;
                {
                    Assert.IsTrue(OK);
                }
            }
        }

        [TestMethod]
        public void TestSupplier_Trade_RestrictionsFound()
        {
            clsSupply Example_Supplier = new clsSupply();
            Boolean Found = false;
            Boolean OK = true;
            String SRestrictions = "false";
            Found = Example_Supplier.Find(SRestrictions);
            if (Example_Supplier.Supplier_Trade_Restrictions != false)
            {
                OK = false;
                {
                    Assert.IsTrue(OK);
                }
            }
        }
    }
 }

 