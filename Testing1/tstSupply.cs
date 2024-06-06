using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Testing1
{
    [TestClass]
    public class tstSupply
    {

        //good test data 
        //create some test data to pass the method
        string Supplier_Name = "BMW";
        string Supplier_Phone_Number = "1168327625";
        string Supplier_Address = "Watermead Business Park";
        string Supplier_Email = "bentleyleicester@gmail.com";
        string Supplier_Country = "England";
        Boolean Supplier_Export = false;
        Boolean Supplier_Trade_Restrictions = false;

        [TestMethod]
        public void InstanceOK()
        {
            clsSupply Supplier_Name = new clsSupply();
            Assert.IsNotNull(Supplier_Name);
        }

        [TestMethod]
        public void Supplier_IdPropertyOK()
        {
            clsSupply Supply = new clsSupply();
            Int32 TestData = 1;
            Supply.Supplier_Id = TestData;
            Assert.AreEqual(Supply.Supplier_Id, TestData);
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
            Int32 Supplier_Id = 1;
            Found = ExampleSupplier.Find(Supplier_Id);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestSupplier_IdFound()
        {
            clsSupply Example_Supplier = new clsSupply();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Supplier70 = 1;
            Found = Example_Supplier.Find(Supplier70);
            if (Example_Supplier.Supplier_Id != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplier_NameFound()
        {
            clsSupply Example_Supplier = new clsSupply();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Supplier70 = 1;
            Found = Example_Supplier.Find(Supplier70);
            if (Example_Supplier.Supplier_Name != "Bentley")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplier_Phone_NumberFound()
        {
            clsSupply Example_Supplier = new clsSupply();
            Int32 Supplier_Id = 1;
            Boolean Found = false;
            Boolean OK = true;
            Found = Example_Supplier.Find(Supplier_Id);
            if (Example_Supplier.Supplier_Phone_Number != "1168327625")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplier_AddressFound()
        {
            clsSupply Example_Supplier = new clsSupply();
            Int32 Supplier_Id = 1;
            Boolean Found = false;
            Boolean OK = true;
            Found = Example_Supplier.Find(Supplier_Id);
            if (Example_Supplier.Supplier_Address != "Watermead Business Park")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplier_EmailFound()
        {
            clsSupply Example_Supplier = new clsSupply();
            Int32 Supplier_Id = 1;
            Boolean Found = false;
            Boolean OK = true;
            Found = Example_Supplier.Find(Supplier_Id);
            if (Example_Supplier.Supplier_Email != "bentleyleicester@gmail.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplier_CountryFound()
        {
            clsSupply Example_Supplier = new clsSupply();
            Int32 Supplier_Id = 1;
            Boolean Found = false;
            Boolean OK = true;
            Found = Example_Supplier.Find(Supplier_Id);
            if (Example_Supplier.Supplier_Country != "England")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplier_ExportFound()
        {
            clsSupply Example_Supplier = new clsSupply();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Supplier_Id = 1;
            Found = Example_Supplier.Find(Supplier_Id);
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
            Int32 Supplier_Id = 1;
            Found = Example_Supplier.Find(Supplier_Id);
            if (Example_Supplier.Supplier_Trade_Restrictions != false)
            {
                OK = false;
                {
                    Assert.IsTrue(OK);
                }
            }
        }
        [TestMethod]
        public void ValidMethodOK() 
        {
            //create an instance of the class
            clsSupply anSupply = new clsSupply();
            //string variable to store error
            String Error = "";
            //invoke the methods
            Error = anSupply.Valid(Supplier_Name, Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
        }

        [TestMethod]
        public void Supplier_NameMinlessOne()
        {
            //create an instance of the class
            clsSupply anSupply = new clsSupply();
            //string variable to store error
            String Error = "";
            //this should failed
            string Supplier_Name = "a";
            //invoke the methods
            Error = anSupply.Valid(Supplier_Name, Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Supplier_NameMin()
        {
            //create an instance of the class
            clsSupply anSupply = new clsSupply();
            //string variable to store error
            String Error = "";
            //this should failed
            string Supplier_Name = "aa";
            //invoke the methods
            Error = anSupply.Valid(Supplier_Name, Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Supplier_NameMinPlusOne()
        {
            //create an instance of the class
            clsSupply anSupply = new clsSupply();
            //string variable to store error
            String Error = "";
            //this should failed
            string Supplier_Name = "aaa";
            //invoke the methods
            Error = anSupply.Valid(Supplier_Name, Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Supplier_NameMaxLessOne()
        {
            //create an instance of the class
            clsSupply anSupply = new clsSupply();
            //string variable to store error
            String Error = "";
            //this should failed
            string Supplier_Name = "";
            Supplier_Name = Supplier_Name.PadRight(49, 's');
            //invoke the methods
            Error = anSupply.Valid(Supplier_Name, Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Supplier_NameMax()
        {
            //create an instance of the class
            clsSupply anSupply = new clsSupply();
            //string variable to store error
            String Error = "";
            //this should failed
            string Supplier_Name = "";
            Supplier_Name = Supplier_Name.PadRight(50, 's');
            //invoke the methods
            Error = anSupply.Valid(Supplier_Name, Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Supplier_NameMaxPlusOne()
        {
            //create an instance of the class
            clsSupply anSupply = new clsSupply();
            //string variable to store error
            String Error = "";
            //this should failed
            string Supplier_Name = "";
            Supplier_Name = Supplier_Name.PadRight(51, 's');
            //invoke the methods
            Error = anSupply.Valid(Supplier_Name, Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Supplier_NameMid()
        {
            //create an instance of the class
            clsSupply anSupply = new clsSupply();
            //string variable to store error
            String Error = "";
            //this should failed
            string Supplier_Name = "";
            Supplier_Name = Supplier_Name.PadRight(25, 's');
            //invoke the methods
            Error = anSupply.Valid(Supplier_Name, Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Supplier_NameExtremeMax()
        {
            //create an instance of the class
            clsSupply anSupply = new clsSupply();
            //string variable to store error
            String Error = "";
            //this should failed
            string Supplier_Name = "";
            Supplier_Name = Supplier_Name.PadRight(100, 's');
            //invoke the methods
            Error = anSupply.Valid(Supplier_Name, Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void Supplier_Phone_NumberMinlessOne()
        {
            //create an instance of the class
            clsSupply anSupply = new clsSupply();
            //string variable to store error
            String Error = "";
            //this should failed
            string Supplier_Phone_Number = "";
            //invoke the methods
            Error = anSupply.Valid(Supplier_Name, Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Supplier_Phone_NumberMin()
        {
            //create an instance of the class
            clsSupply anSupply = new clsSupply();
            //string variable to store error
            String Error = "";
            //this should failed
            string Supplier_Phone_Number = "07979481290";
            //invoke the methods
            Error = anSupply.Valid(Supplier_Name, Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Supplier_Phone_NumberMinPlusOne()
        {
            //create an instance of the class
            clsSupply anSupply = new clsSupply();
            //string variable to store error
            String Error = "";
            //this should failed
            string Supplier_Phone_Number = "079794812929";
            //invoke the methods
            Error = anSupply.Valid(Supplier_Name, Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Supplier_Phone_NumberMaxLessOne()
        {
            //create an instance of the class
            clsSupply anSupply = new clsSupply();
            //string variable to store error
            String Error = "";
            //this should failed
            string Supplier_Phone_Number = "";
            Supplier_Phone_Number = Supplier_Phone_Number.PadRight(19, 's');
            //invoke the methods
            Error = anSupply.Valid(Supplier_Name, Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Supplier_Phone_NumberMax()
        {
            //create an instance of the class
            clsSupply anSupply = new clsSupply();
            //string variable to store error
            String Error = "";
            //this should failed
            string Supplier_Phone_Number = "";
            Supplier_Phone_Number = Supplier_Phone_Number.PadRight(20, 's');
            //invoke the methods
            Error = anSupply.Valid(Supplier_Name, Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Supplier_Phone_NumberMaxPlusOne()
        {
            //create an instance of the class
            clsSupply anSupply = new clsSupply();
            //string variable to store error
            String Error = "";
            //this should failed
            string Supplier_Phone_Number = "";
            Supplier_Phone_Number = Supplier_Phone_Number.PadRight(21, 's');
            //invoke the methods
            Error = anSupply.Valid(Supplier_Name, Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Supplier_Phone_NumberMid()
        {
            //create an instance of the class
            clsSupply anSupply = new clsSupply();
            //string variable to store error
            String Error = "";
            //this should failed
            string Supplier_Phone_Number = "";
            Supplier_Phone_Number = Supplier_Phone_Number.PadRight(10, 's');
            //invoke the methods
            Error = anSupply.Valid(Supplier_Name, Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Supplier_Phone_NumberExtremeMax()
        {
            //create an instance of the class
            clsSupply anSupply = new clsSupply();
            //string variable to store error
            String Error = "";
            //this should failed
            string Supplier_Phone_Number = "";
            Supplier_Phone_Number = Supplier_Phone_Number.PadRight(100, 's');
            //invoke the methods
            Error = anSupply.Valid(Supplier_Name, Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}

 