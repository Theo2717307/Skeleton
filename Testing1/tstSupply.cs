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
            string Supplier70 = "Bentley";
            Found = ExampleSupplier.Find(Supplier70);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestSupplier_NameFound()
        {
            clsSupply Example_Supplier = new clsSupply();
            Boolean Found = false;
            Boolean OK = true;
            String Supplier70 = "Bentley";
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
            string Supplier_Name = "Bentley";
            Boolean Found = false;
            Boolean OK = true;
            Found = Example_Supplier.Find(Supplier_Name);
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
            string Supplier_Name = "Bentley";
            Boolean Found = false;
            Boolean OK = true;
            Found = Example_Supplier.Find(Supplier_Name);
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
            string Supplier_Name = "Bentley";
            Boolean Found = false;
            Boolean OK = true;
            Found = Example_Supplier.Find(Supplier_Name);
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
            string Supplier_Name = "Bentley";
            Boolean Found = false;
            Boolean OK = true;
            Found = Example_Supplier.Find(Supplier_Name);
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

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsSupply Supplier_Name = new clsSupply();
            //string variable to store any error message 
            string Error = "";
            //invoke the method
            Error = Supplier_Name.Valid(Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Supplier_Phone_NumberMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupply Supplier_Name = new clsSupply();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Supplier_Phone_Number = ""; //this should trigger an error
            //invoke the method 
            Error = Supplier_Name.Valid(Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Supplier_Phone_NumberMin()
        {
            //create an instance of the class we want to create
            clsSupply Supplier_Name = new clsSupply();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Supplier_Phone_Number = "a"; //this should trigger an error
            //invoke the method 
            Error = Supplier_Name.Valid(Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Supplier_Phone_NumberMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupply Supplier_Name = new clsSupply();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Supplier_Phone_Number = "aa"; //this should trigger an error
            //invoke the method 
            Error = Supplier_Name.Valid(Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Supplier_Phone_NumberMax()
        {
            //create an instance of the class we want to create
            clsSupply Supplier_Name = new clsSupply();
            //string variable to store any error message
            String Error = "";
            string Supplier_Phone_Number = "";
            Supplier_Phone_Number = Supplier_Phone_Number.PadRight(50, 'a'); //this should fail
            //invoke the method
            Error = Supplier_Name.Valid(Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Supplier_Phone_NumberMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSupply Supplier_Name = new clsSupply();
            //string variable to store any error message
            String Error = "";
            string Supplier_Phone_Number = "";
            Supplier_Phone_Number = Supplier_Phone_Number.PadRight(51, 'a'); //this should fail
            //invoke the method
            Error = Supplier_Name.Valid(Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Supplier_Phone_NumberExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupply Supplier_Name = new clsSupply();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Supplier_Phone_Number = "";
            Supplier_Phone_Number = Supplier_Phone_Number.PadRight(100, 'a'); //this should fail
            //invoke the method
            Error = Supplier_Name.Valid(Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Supplier_AddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupply Supplier_Name = new clsSupply();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Supplier_Address = ""; //this should trigger an error
            //invoke the method 
            Error = Supplier_Name.Valid(Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Supplier_AddressMin()
        {
            //create an instance of the class we want to create
            clsSupply Supplier_Name = new clsSupply();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Supplier_Address = "aaaaaa"; //this should trigger an error
            //invoke the method 
            Error = Supplier_Name.Valid(Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Supplier_AddressMax()
        {
            //create an instance of the class we want to create
            clsSupply Supplier_Name = new clsSupply();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Supplier_Address = "";
            Supplier_Address = Supplier_Address.PadRight(50, 'a');
            //invoke the method
            Error = Supplier_Name.Valid(Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Supplier_Address_MinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupply Supplier_Name = new clsSupply();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Supplier_Address = "aaaaaaa"; //this should trigger an error
            //invoke the method 
            Error = Supplier_Name.Valid(Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Supplier_Address_MaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSupply Supplier_Name = new clsSupply();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Supplier_Address = "";
            Supplier_Address = Supplier_Address.PadRight(51, 'a'); //this should fail
            //invoke the method
            Error = Supplier_Name.Valid(Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Supplier_Address_ExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupply Supplier_Name = new clsSupply();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Supplier_Address = "";
            Supplier_Address = Supplier_Address.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = Supplier_Name.Valid(Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void Supplier_EmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupply Supplier_Name = new clsSupply();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Supplier_Email = "aa"; //this should trigger an error
            //invoke the method 
            Error = Supplier_Name.Valid(Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Supplier_EmailMin()
        {
            //create an instance of the class we want to create
            clsSupply Supplier_Name = new clsSupply();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Supplier_Email = "aaa"; //this should trigger an error
            //invoke the method 
            Error = Supplier_Name.Valid(Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Supplier_EmailMax()
        {
            //create an instance of the class we want to create
            clsSupply Supplier_Name = new clsSupply();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Supplier_Email = "";
            Supplier_Email = Supplier_Email.PadRight(30, 'a');
            //invoke the method
            Error = Supplier_Name.Valid(Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Supplier_EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupply Supplier_Name = new clsSupply();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Supplier_Email = "aaaa"; //this should trigger an error
            //invoke the method 
            Error = Supplier_Name.Valid(Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Supplier_EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSupply Supplier_Name = new clsSupply();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Supplier_Email = "";
            Supplier_Email = Supplier_Email.PadRight(31, 'a'); //this should fail
            //invoke the method
            Error = Supplier_Name.Valid(Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Supplier_EmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupply Supplier_Name = new clsSupply();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Supplier_Email = "";
            Supplier_Email = Supplier_Email.PadRight(100, 'a'); //this should fail
            //invoke the method
            Error = Supplier_Name.Valid(Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Supplier_CountryMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupply Supplier_Name = new clsSupply();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Supplier_Country = "aaa"; //this should trigger an error
            //invoke the method 
            Error = Supplier_Name.Valid(Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Supplier_CountryMin()
        {
            //create an instance of the class we want to create
            clsSupply Supplier_Name = new clsSupply();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Supplier_Email = "aaaa"; //this should trigger an error
            //invoke the method 
            Error = Supplier_Name.Valid(Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Supplier_CountryMax()
        {
            //create an instance of the class we want to create
            clsSupply Supplier_Name = new clsSupply();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Supplier_Country = "";
            Supplier_Country = Supplier_Country.PadRight(20, 'a');
            //invoke the method
            Error = Supplier_Name.Valid(Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Supplier_CountryMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupply Supplier_Name = new clsSupply();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Supplier_Country = "aaaaa"; //this should trigger an error
            //invoke the method 
            Error = Supplier_Name.Valid(Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Supplier_CountryPlusOne()
        {
            //create an instance of the class we want to create
            clsSupply Supplier_Name = new clsSupply();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Supplier_Country = "";
            Supplier_Country = Supplier_Country.PadRight(21, 'a'); //this should fail
            //invoke the method
            Error = Supplier_Name.Valid(Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Supplier_CountryExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupply Supplier_Name = new clsSupply();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Supplier_Country = "";
            Supplier_Country = Supplier_Country.PadRight(100, 'a'); //this should fail
            //invoke the method
            Error = Supplier_Name.Valid(Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}

 